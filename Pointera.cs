using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using MemoryLibrary;

namespace SekiroSpeedrunUtil.tracking {
    internal class Pointera {

        private IntPtr _basePtr;
        private int[] _offsets;
        private ObjectWrapper _object;
        private Thread _listener;
        private EThreadPriority _threadPriority;

        public Pointera(ObjectWrapper obj, IntPtr basePtr, int[] offsets, EThreadPriority threadPriority = EThreadPriority.Normal) {
            _object = obj;
            _basePtr = basePtr;
            _offsets = offsets;
            _threadPriority = threadPriority;

            _listener = new Thread(ListenerThread) {
                IsBackground = true
            };

            _listener.Start();
        }

        public void ResetAddress(IntPtr basePtr, int[] offsets) {
            _basePtr = basePtr;
            _offsets = offsets;
        }

        private bool _paused = false;
        private bool _stopped = false;
        private void ListenerThread() {
            while (!_stopped) {
                if (_paused) {
                    Thread.Sleep((int)EThreadPriority.Normal);
                    continue;
                }

                Thread.Sleep((int)_threadPriority);

                try {
                    var remoteProc = new RemoteProcess(Process.GetProcessesByName("Sekiro")[0]);
                    var addr = _basePtr;
                    if (_offsets.Length > 0) {
                        addr = _offsets.Aggregate(addr, (current, offset) => remoteProc.Read<IntPtr>(current) + offset);
                    }

                    object val = null;
                    if (_object.ObjType == typeof(byte)) {
                        val = remoteProc.Read<byte>(addr);
                    } else if (_object.ObjType == typeof(float)) {
                        val = remoteProc.Read<float>(addr);
                    }

                    _object.SetValue(val);
                } catch (Exception e) {
                    //Debug.WriteLine("Thread exception");
                }
            }
            Debug.WriteLine("Pointerthread stopped");
        }

        public void Pause() => _paused = true;
        public void Stop() => _stopped = true;
        public bool Alive() => _listener.IsAlive;

        public enum EThreadPriority {
            Low = 2000,
            Normal = 1000,
            High = 100,
            Ultra = 10,
            Stupid = 1
        }

    }
}

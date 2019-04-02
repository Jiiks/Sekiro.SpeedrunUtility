using System;
using System.Threading;
using SekiroSpeedrunUtil.structs;

namespace SekiroSpeedrunUtil {
    public class MemoryThread {

        private readonly string _processName;
        private readonly IntPtrE _ptr;
        private readonly EMemoryThreadPriority _threadPriority;
        public Thread Thread { get; private set; }

        public int ThreadId;

        private readonly ManualResetEvent _manualResetEvent = new ManualResetEvent(true);

        private readonly int _bytesToRead;
        private byte[] _value;
        private readonly string _name;

        public EventHandler<MemoryThreadEventArgs> ValueChanged;

        public MemoryThread(string procName, IntPtrE intPtrE, int bytesToRead, string name, EMemoryThreadPriority threadPriority = EMemoryThreadPriority.Normal) {
            _processName = procName;
            _ptr = intPtrE;
            _threadPriority = threadPriority;
            _bytesToRead = bytesToRead;
            _value = new byte[bytesToRead];
            _name = name;
        }

        private bool _stopped;
        private void ThreadProc() {
            while (!_stopped) {
                _manualResetEvent.WaitOne();
                Thread.Sleep((int)_threadPriority);
                try {

                    var remoteProc = RemoteProc.Instance();
                    if(remoteProc == null) continue;

                    var addr = _ptr.GetAddress(remoteProc);
                    if (addr == IntPtr.Zero) continue;
                    var bytes = remoteProc.ReadBytes(addr, _bytesToRead);
                    if(bytes.IsEqual(_value)) continue;
                    _value = bytes;

                    ValueChanged?.Invoke(this, new MemoryThreadEventArgs { Bytes = _value });

                } catch (Exception e) {
                    Diag.WriteLine($"[MemoryThread {_name}] {e.Message}");
                }                
            }
            Diag.WriteLine($"[MemoryThread {_name}] stopped");
        }

        public void Start() {
            Thread = new Thread(ThreadProc) {
                IsBackground = true
            };
            Thread.Start();
            MemoryThreadMan.Join(this);
        }

        public void Stop() => _stopped = true;
        public void Pause() => _manualResetEvent.Reset();
        public void Resume() => _manualResetEvent.Set();

    }

    public class MemoryThreadEventArgs : EventArgs {
        public byte[] Bytes;
    }

    public enum EMemoryThreadPriority {
        Low = 2000,
        Normal = 1000,
        High = 100,
        Ultra = 10,
        Stupid = 1
    }
}

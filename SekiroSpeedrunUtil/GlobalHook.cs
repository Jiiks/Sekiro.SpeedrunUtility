using System;
using System.Collections.Generic;
using SekiroSpeedrunUtil.enums;

namespace SekiroSpeedrunUtil {
    public class GlobalHook
    {
        private IntPtr _hookId = IntPtr.Zero;
        private readonly Native.WinEventDelegate _hookDelegate;

        public event EventHandler<HookEventArgs> OnHookEvent;
        public List<HookEvent> SubscribedEvents { get; } = new List<HookEvent>();

        public GlobalHook() {
            _hookDelegate = WinEventProc;
        }

        public GlobalHook(HookEvent subcriptions) : this() {
            SubscribedEvents.Add(subcriptions);
        }

        ~GlobalHook() {
            RemoveHook();
        }

        public void UnSubscribe(HookEvent eventType) {
            SubscribedEvents.RemoveAll(e => e == eventType);
        }

        public void Subscribe(HookEvent eventType) {
            SubscribedEvents.Add(eventType);
        }

        public bool InitHook() {
            if (_hookId != IntPtr.Zero && !RemoveHook()) return false;
            _hookId = Native.SetWinEventHook((uint)HookEvent.EVENT_MIN, (uint)HookEvent.EVENT_MAX,
                IntPtr.Zero, _hookDelegate, 0, 0, (uint)HookFlag.WINEVENT_OUTOFCONTEXT);

            AppDomain.CurrentDomain.ProcessExit += delegate {
                RemoveHook();
            };

            return _hookId != IntPtr.Zero;
        }

        public bool RemoveHook() {
            if (_hookId == IntPtr.Zero || !Native.UnhookWinEvent(_hookId)) return false;
            _hookId = IntPtr.Zero;
            return true;
        }

        private void WinEventProc(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild,
            uint dwEventThread, uint dwmsEventTime) {
            if (SubscribedEvents.Contains(HookEvent.ALL_EVENTS)) {
                OnHookEvent?.Invoke(null, new HookEventArgs(hWinEventHook, eventType, hwnd, idObject, idChild,
                    dwEventThread, dwmsEventTime));
                return;
            }

            if (SubscribedEvents.Contains((HookEvent)eventType)) {
                OnHookEvent?.Invoke(null, new HookEventArgs(hWinEventHook, eventType, hwnd, idObject, idChild,
                    dwEventThread, dwmsEventTime));
            }
        }

        public class HookEventArgs : EventArgs
        {
            public HookEvent EventType { get; }
            public IntPtr WinEventHook { get; }
            public uint EventId { get; }
            public IntPtr HWnd { get; }
            public int ObjectId { get; }
            public int ChildId { get; }
            public uint EventThread { get; }
            public uint EventTime { get; }

            public HookEventArgs(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild,
            uint dwEventThread, uint dwmsEventTime) {
                EventType = (HookEvent)eventType;
                WinEventHook = hWinEventHook;
                EventId = eventType;
                HWnd = hwnd;
                ObjectId = idObject;
                ChildId = idChild;
                EventThread = dwEventThread;
                EventTime = dwmsEventTime;
            }
        }
    }
}

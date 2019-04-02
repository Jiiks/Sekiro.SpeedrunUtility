using System;
using System.Collections.Generic;

namespace SekiroSpeedrunUtil.globalevents {

    public static class GlobalEvents {

        private static readonly Dictionary<string, EventHandler<GlobalEventArgs>> _events = new Dictionary<string, EventHandler<GlobalEventArgs>>();

        public static void Add(string name, EventHandler<GlobalEventArgs> handler) {
            Diag.WriteLine($"[GlobalEvents Add] {name}");
            if (_events.ContainsKey(name)) return;
            _events.Add(name, handler);
        }

        public static void Subscribe(string name, EventHandler<GlobalEventArgs> handler) {
            Diag.WriteLine($"[GlobalEvents Subscribe] {name}");
            if (!_events.ContainsKey(name)) return;
            _events[name] += handler;
        }

        public static void Unsubscribe(string name, EventHandler<GlobalEventArgs> handler) {
            Diag.WriteLine($"[GlobalEvents Unsubscribe] {name}");
            if (!_events.ContainsKey(name)) return;
            _events[name] -= handler;
        }

        public static void Fire(string name, object sender, object value) {
            if (!_events.ContainsKey(name)) return;
            _events[name](sender, new GlobalEventArgs(){ Value = value });
        }

    }

    public class GlobalEventArgs : EventArgs {
        public object Value;
    }
}

using System;

namespace SekiroSpeedrunUtil.globalevents {
    public abstract class GlobalEvent {
        private event EventHandler<GlobalEventArgs> _event;
        public EventHandler<GlobalEventArgs> Event() => _event;

        private object _value;

        protected abstract string EventName();
        public abstract void Start();

        public string GetEventName() => EventName();

        protected GlobalEvent() {
            GlobalEvents.Add(EventName(), Event());
        }

        public void Fire() {
            GlobalEvents.Fire(EventName(), this, Value());
        }

        public object Value() {
            return _value;
        }

        public void SetValue(object newValue) {
            _value = newValue;
            Fire();
        }

        public void Subscribe(EventHandler<GlobalEventArgs> handler) => GlobalEvents.Subscribe(EventName(), handler);

        public void Unsubscribe(EventHandler<GlobalEventArgs> handler) => GlobalEvents.Unsubscribe(EventName(), handler);
    }
}

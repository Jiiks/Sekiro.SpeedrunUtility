using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using SekiroSpeedrunUtil.globalevents;

namespace SekiroSpeedrunUtil.tracking {
    public class ObjectWrappera : IComparable<object> {

        private object _value;
        public object GetValue() => _value;

        public Type ObjType;

        public ObjectWrappera(object initialValue) {
            _value = initialValue;
            ObjType = initialValue.GetType();
        }

        public void SetValue(object newValue) {
            if (CompareTo(newValue) < 1) return;
            
            _value = newValue;
            OnPropertyChanged();
        }

        public int CompareTo(object other) {
            if (other == null || _value == null) {
                return -1;
            }

            var type = other.GetType();

            if (type != _value.GetType() && !type.IsPrimitive && typeof(string) != type && typeof(byte[]) != type) {
                return -1;
            }

            if (type.IsPrimitive || typeof(string) == type) {
                return other.Equals(_value) ? 0 : 1;
            }

            if (!(_value is byte[] oldVal) || !(other is byte[] newVal)) {
                return -1;
            }

            return oldVal.SequenceEqual(newVal) ? 1 : 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

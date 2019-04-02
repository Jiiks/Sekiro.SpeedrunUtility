using System;
using System.Collections.Generic;

namespace SekiroSpeedrunUtil {
    public class IcDict<TKey, TValue> : Dictionary<TKey, TValue> {

        public TValue Find(TKey key) {
            foreach (var k in Keys) {
                if (string.Equals(k.ToString(), key.ToString(), StringComparison.CurrentCultureIgnoreCase)) return this[k];
            }

            return default(TValue);
        }

    }
}

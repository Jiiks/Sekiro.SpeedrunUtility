using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SekiroSpeedrunUtil {
    public static class Extensions {
        public static void InvokeIfRequired(this ISynchronizeInvoke obj, MethodInvoker action) {
            if (obj.InvokeRequired) {
                var args = new object[0];
                obj.Invoke(action, args);
                return;
            }
            action();
        }

        public static bool IsEqual(this byte[] b1, byte[] b2) {
            if (b1 == b2) return true;
            if (b1 == null || b2 == null) return false;
            if (b1.Length != b2.Length) return false;
            return !b1.Where((t, i) => t != b2[i]).Any();
        }

        public static byte[] HexBytes(this short i) => HexBytes(i.ToString("X"));
        public static byte[] HexBytes(this int i) => HexBytes(i.ToString("X"));
        public static byte[] HexBytes(this long i) => HexBytes(i.ToString("X"));
        public static byte[] HexBytes(this string hex) {
            if (hex.Length <= 2) return BitConverter.GetBytes(Convert.ToByte(hex, 16));
            if (hex.Length % 2 >= 1) hex = $"0{hex}";
            var retval = new byte[hex.Length / 2];
            for (var i = 0; i < hex.Length; i += 2) retval[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return retval;
        }

        public static void SlideToDestination(this Control control, int newY, int delay, Action onFinish) {
            new Task(() =>  {
                var directionX = newY > control.Top ? 1 : -1;

                while (control.Top != newY) {
                    try {
                        control.InvokeIfRequired(() => {
                            control.Top += directionX;
                        });
                        Thread.Sleep(delay);
                    } catch {
                        break;
                    }
                }

                onFinish?.Invoke();
            }).Start();
        }

        public static IEnumerable<T> FastReverse<T>(this IList<T> items) {
            for (var i = items.Count - 1; i >= 0; i--) {
                yield return items[i];
            }
        }

    }
}

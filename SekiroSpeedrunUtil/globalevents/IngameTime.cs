using System;

namespace SekiroSpeedrunUtil.globalevents {
    internal class IngameTime : GlobalEvent {
        protected override string EventName() => "IGT";

        private MemoryThread _thread;

        public override void Start() {
            _thread = new MemoryThread("Sekiro", Defs.PointerByName("IGT"), 4, EventName(), EMemoryThreadPriority.High);
            _thread.ValueChanged += (sender, args) => {
                try {
                    var ms = BitConverter.ToInt32(args.Bytes, 0);
                    var t = TimeSpan.FromMilliseconds(ms);
                    SetValue($"{t.Hours:D2}h:{t.Minutes:D2}m:{t.Seconds:D2}s:{t.Milliseconds:D3}ms");
                } catch {
                    // ignored
                }
            };
            _thread.Start();
        }
    }
}

using System;

namespace SekiroSpeedrunUtil.globalevents
{
    class LastIdol : GlobalEvent {
        protected override string EventName() => "LastIdol";

        private MemoryThread _thread;

        public override void Start() {
            _thread = new MemoryThread("Sekiro", Defs.PointerByName("LastCommutedIdol"), 4, EventName());
            _thread.ValueChanged += (sender, args) => {
                try {
                    var idol = Defs.IdolById(BitConverter.ToInt32(args.Bytes, 0));
                    if (idol == null) return;
                    SetValue(idol);
                } catch {
                    // Ignored
                }
            };
            _thread.Start();
        }
    }
}

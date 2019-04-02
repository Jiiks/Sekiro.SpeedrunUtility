using System;

namespace SekiroSpeedrunUtil.globalevents
{
    class LastIdol : GlobalEvent {
        protected override string EventName() => "LastIdol";

        private MemoryThread _thread;

        public override void Start() {
            _thread = new MemoryThread("Sekiro", Defs.PointerByName("LastCommutedIdol"), 4, EventName());
            _thread.ValueChanged += (sender, args) => {
                var idol = Defs.IdolById(BitConverter.ToInt32(args.Bytes, 0));
                SetValue(idol);
            };
            _thread.Start();
        }
    }
}

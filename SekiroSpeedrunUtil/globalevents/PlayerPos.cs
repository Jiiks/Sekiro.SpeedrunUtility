using System;
using SekiroSpeedrunUtil.structs;

namespace SekiroSpeedrunUtil.globalevents {
    internal class PlayerPos : GlobalEvent {
        protected override string EventName() => "PlayerPos";

        private MemoryThread _thread;

        public override void Start() {
            _thread = new MemoryThread("Sekiro", Defs.PointerByName("PlayerPosition"), 12, EventName());
            _thread.ValueChanged += (sender, args) => {
                try {
                    var posX = BitConverter.ToSingle(args.Bytes, 0);
                    var posY = BitConverter.ToSingle(args.Bytes, 4);
                    var posZ = BitConverter.ToSingle(args.Bytes, 8);
                    var vect3 = new Vector3(posX, posY, posZ);
                    SetValue(new Vector3(posX, posY, posZ));
                } catch {
                    // ignored
                }
            };
            _thread.Start();
        }
    }
}

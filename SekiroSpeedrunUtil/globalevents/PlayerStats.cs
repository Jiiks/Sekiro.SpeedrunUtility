using System;
using SekiroSpeedrunUtil.structs;

namespace SekiroSpeedrunUtil.globalevents {
    internal class PlayerStats : GlobalEvent {

        protected override string EventName() => "PlayerStats";

        private MemoryThread _thread;

        public override void Start() {
            _thread = new MemoryThread("Sekiro", Defs.PointerByName("PlayerStats"), 32, EventName());
            _thread.ValueChanged += (sender, args) => {
                try {
                    var curHealth = BitConverter.ToInt32(args.Bytes, 0);
                    var maxHealth = BitConverter.ToInt32(args.Bytes, 4);
                    var curPosture = BitConverter.ToInt32(args.Bytes, 24);
                    var maxPosture = BitConverter.ToInt32(args.Bytes, 28);

                    SetValue(new Player() {
                        CurrentHealth = curHealth,
                        MaximumHealth = maxHealth,
                        CurrentPosture = curPosture,
                        MaximumPosture = maxPosture
                    });
                } catch {
                    // ignored
                }
            };
            _thread.Start();
        }

    }
}

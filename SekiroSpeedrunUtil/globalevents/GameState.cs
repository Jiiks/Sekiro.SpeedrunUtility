namespace SekiroSpeedrunUtil.globalevents {
    public class GameState : GlobalEvent {
        protected override string EventName() => "GameState";

        private MemoryThread _thread;

        public override void Start() {
            _thread = new MemoryThread("Sekiro", Defs.PointerByName("GameState"), 1, EventName());
            _thread.ValueChanged += (sender, args) => {
                try {
                    SetValue(args.Bytes[0]);
                } catch {
                    // ignored
                }
            };
            _thread.Start();
        }
    }
}

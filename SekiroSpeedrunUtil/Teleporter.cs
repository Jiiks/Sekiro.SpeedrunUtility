using System;
using System.Linq;
using MemoryLibrary;
using SekiroSpeedrunUtil.globalevents;
using SekiroSpeedrunUtil.injects;
using SekiroSpeedrunUtil.structs;

namespace SekiroSpeedrunUtil {
    public static class Teleporter {

        public static void Teleport(Vector3 coords) {
            var sekiro = Utils.Sekiro();
            if (sekiro == null) return;

            using (var remoteProc = new RemoteProcess(sekiro)) {
                var address = Coordinates().BasePtr;

                try {
                    address = Coordinates().Offsets.Aggregate(address, (current, offset) => remoteProc.Read<IntPtr>(current) + offset);
                    remoteProc.WriteBytes(address, coords.ToByteArray());
                } catch (Exception e) {
                    Diag.WriteLine($"Exception in Coordinate Teleport {e.Message}");
                }
            }
        }

        public static void Teleport(Area area, Vector3 coords = null) {
            if (coords != null || area.Coords != null) {
                void TeleAfter(object sender, GlobalEventArgs e) {
                    if ((byte)e.Value != 1) return;
                    if (area.Coords != null) Teleport(area.Coords);
                    if (coords != null) Teleport(coords);
                    GlobalEvents.Unsubscribe("GameState", TeleAfter);
                }
                GlobalEvents.Subscribe("GameState", TeleAfter);
            }
            new AreaTeleport(area).Execute();
        }

        public static void Teleport(Idol idol, Vector3 coords) {
            void TeleAfter(object sender, GlobalEventArgs e) {
                if ((byte)e.Value != 1) return;
                Teleport(coords);
                GlobalEvents.Unsubscribe("GameState", TeleAfter);
            }
            GlobalEvents.Subscribe("GameState", TeleAfter);
            new IdolTeleport(idol).Execute();
        }

        public static void Teleport(Idol idol) {
            Teleport(idol.Area, idol.Coords);
        }

        public static void Teleport(Boss boss) {
            if(boss.Idol != null) Teleport(boss.Idol, boss.Coords);
            else Teleport(boss.Area, boss.Coords);
        }

        private static PointerStruct Coordinates() {
            return new PointerStruct() {
                BasePtr = new IntPtr(0x143B67DF0),
                Offsets = new[] {0x48, 0x28, 0x80}
            };
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using SekiroSpeedrunUtil.structs;
using SekiroSpeedrunUtil.ui;

namespace SekiroSpeedrunUtil {
    public static class Defs {

        public static List<Area> Areas;
        public static List<Boss> Bosses;
        public static List<Idol> Idols;
        public static List<Item> Items;
        public static List<Flag> Flags;
        public static List<Pattern> Patterns;
        public static List<PointerDef> PointerDefs;
        public static List<PointerStruct> Pointers = new List<PointerStruct>();

        public static void LoadDefs() {
            
            Areas = JsonConvert.DeserializeObject<List<Area>>(File.ReadAllText("defs/area.defs"));
            Bosses = JsonConvert.DeserializeObject<List<Boss>>(File.ReadAllText("defs/boss.defs"));
            Idols = JsonConvert.DeserializeObject<List<Idol>>(File.ReadAllText("defs/idol.defs"));
            Items = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText("defs/item.defs"));
            Patterns = JsonConvert.DeserializeObject<List<Pattern>>(File.ReadAllText("defs/pattern.defs"));

            PointerDefs = JsonConvert.DeserializeObject<List<PointerDef>>(File.ReadAllText("defs/pointer.defs"));
            if(File.Exists("custom_pointers.defs")) PointerDefs.AddRange(JsonConvert.DeserializeObject<List<PointerDef>>(File.ReadAllText("custom_pointers.defs")));
            foreach (var pointerDef in PointerDefs) {
                Pointers.Add(new PointerStruct { Name = pointerDef.Name, BasePtr = new IntPtr(pointerDef.Base), Offsets = pointerDef.Offsets });
            }
            Flags = JsonConvert.DeserializeObject<List<Flag>>(File.ReadAllText("defs/flags.defs"));
            if (File.Exists("custom_flags.defs")) Flags.AddRange(JsonConvert.DeserializeObject<List<Flag>>(File.ReadAllText("custom_flags.defs")));
        }

        public static Area Area(this string name) => AreaByName(name);
        public static Area AreaByName(string name) {
            foreach (var area in Areas) {
                if (string.Equals(area.Name, name, StringComparison.CurrentCultureIgnoreCase)) return area;
            }

            return null;
        }

        public static Boss Boss(this string name) => BossByName(name);
        public static Boss BossByName(string name) {
            foreach (var boss in Bosses) {
                if (string.Equals(boss.Name, name, StringComparison.CurrentCultureIgnoreCase)) return boss;
            }

            return null;
        }

        public static Idol Idol(this string name) => IdolByName(name);
        public static Idol IdolByName(string name) {
            foreach (var idol in Idols) {
                if (string.Equals(idol.Name, name, StringComparison.CurrentCultureIgnoreCase)) return idol;
            }

            return null;
        }

        public static Idol IdolById(int id) {
            foreach (var idol in Idols) {
                if (idol.Id == id) return idol;
            }

            return null;
        }

        public static IntPtrE PointerByName(string name) {
            foreach (var pointer in PointerDefs) {
                if (string.Equals(pointer.Name, name, StringComparison.CurrentCultureIgnoreCase)) return pointer.Base.Ptr(pointer.Offsets);
            }
            return null;
        }

        public static Item Item(this string name) => ItemByName(name);
        public static Item ItemByName(string name) {
            foreach (var item in Items) {
                if (string.Equals(item.Name, name, StringComparison.CurrentCultureIgnoreCase)) return item;
            }

            return null;
        }

        public static Item ItemById(int id) {
            foreach (var item in Items) {
                if (item.Id1 == id) return item;
            }

            return null;
        }

        public static Item ToItem(this SekiroItem sekiroItem) {
            foreach (var item in Items) {
                if (item.Id1 == sekiroItem.Id1 && item.Id2 == sekiroItem.Id2) return new Item {
                    Name = item.Name,
                    Id1 = item.Id1,
                    Id2 = item.Id2,
                    SekiroItem = sekiroItem
                };
            }

            var emptyItem = new SekiroItem() {
                Id1 = 0,
                Id2 = 0xFFFFFFFF,
                Quantity = 0,
                Garbage = 0
            };

            if (sekiroItem.Equals(emptyItem)) {
                return new Item {
                    Empty = true,
                    SekiroItem = sekiroItem
                };
            }

            return new Item {
                Name = "Unknown",
                Id1 = sekiroItem.Id1,
                Id2 = sekiroItem.Id2,
                SekiroItem = sekiroItem
            };
        }

        public static Pattern PatternByName(string name) {
            foreach (var pattern in Patterns) {
                if (string.Equals(pattern.Name, name, StringComparison.CurrentCultureIgnoreCase)) return pattern;
            }

            return new Pattern();
        }

    }
}

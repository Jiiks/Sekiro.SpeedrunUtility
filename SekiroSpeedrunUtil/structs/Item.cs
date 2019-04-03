namespace SekiroSpeedrunUtil.structs {
    public class Item {
        public string Name;
        public uint Id1;
        public uint Id2;
        public bool Empty;
        public int SpiderIndex;
        public SekiroItem SekiroItem;
        public bool Consumable; // Temp

        public int ShortId() {
            if (Consumable) return (short) Id1;
            return (short) Id2;
        }
    }

    public struct SekiroItem {
        public uint Id1;
        public uint Id2;
        public int Quantity;
        public uint Garbage;
    }
}

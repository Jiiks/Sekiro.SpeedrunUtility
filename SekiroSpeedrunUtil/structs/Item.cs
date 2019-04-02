namespace SekiroSpeedrunUtil.structs {
    public class Item {
        public string Name;
        public uint Id1;
        public uint Id2;
        public bool Empty;
        public int SpiderIndex;
        public SekiroItem SekiroItem;
    }

    public struct SekiroItem {
        public uint Id1;
        public uint Id2;
        public int Quantity;
        public uint Garbage;
    }
}

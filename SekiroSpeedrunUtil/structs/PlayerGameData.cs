using System.Runtime.InteropServices;

namespace SekiroSpeedrunUtil.structs {
    [StructLayout(LayoutKind.Explicit)]
    public struct PlayerGameData {
        [FieldOffset(24)] public int CurrentHealth; //0x0018
        [FieldOffset(28)] public int Health1; //0x001C
        [FieldOffset(32)] public int Health2; //0x0020
        [FieldOffset(52)] public int CurrentStamina; //0x0034
        [FieldOffset(56)] public int Stamina1; //0x0038
        [FieldOffset(60)] public int Stamina2; //0x003C
        [FieldOffset(72)] public int AttackPower; //0x0048
        [FieldOffset(124)] public int Coins; //0x007C
        [FieldOffset(236)] public int Status1; //0x00EC
        [FieldOffset(240)] public int BurningStatus; //0x00F0
        [FieldOffset(244)] public int Status3; //0x00F4
        [FieldOffset(248)] public int Status4; //0x00F8
        [FieldOffset(252)] public int Status5; //0x00FC
        [FieldOffset(328)] public int RealDeaths; //0x0148
        [FieldOffset(344)] public int TotalXP; //0x0158
        [FieldOffset(352)] public int XP; //0x0160
        [FieldOffset(420)] public float BurnTimer; //0x01A4
    }
}

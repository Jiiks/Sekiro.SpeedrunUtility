using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace SekiroSpeedrunUtil.structs {
    public class Vector3 {

        public float X;
        public float Y;
        public float Z;

        public byte[] XBytes;
        public byte[] YBytes;
        public byte[] ZBytes;

        [JsonConstructor]
        public Vector3(IReadOnlyList<float> xyz) : this(xyz[0], xyz[1], xyz[2]) { }

        public Vector3(float x, float y, float z) {
            X = x;
            Y = y;
            Z = z;

            XBytes = BitConverter.GetBytes(X);
            YBytes = BitConverter.GetBytes(Y);
            ZBytes = BitConverter.GetBytes(Z);
        }

        public byte[] ToByteArray() => XBytes.Concat(YBytes).Concat(ZBytes).ToArray();

    }
}

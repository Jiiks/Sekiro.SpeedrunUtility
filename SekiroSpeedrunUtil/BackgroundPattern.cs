using System;
using System.Diagnostics;
using System.Threading.Tasks;
using MemoryLibrary;
using SekiroSpeedrunUtil.structs;

namespace SekiroSpeedrunUtil {
    public static class BackgroundPattern  {
        public static Task<IntPtr?> FindPattern(Pattern pattern, Process proc) => 
        Task<IntPtr?>.Factory.StartNew(() => {
            using (var patternFinder = new PatternFinder(proc)) {
                var ptr = patternFinder.Find(pattern.PatternString);
                return ptr;
            }
        });

    }
}

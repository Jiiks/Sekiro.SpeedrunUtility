namespace SekiroSpeedrunUtil {
    public static class MemoryThreadMan {

        private static int _threadCount = 0;

        public static void Join(MemoryThread memoryThread) {
            _threadCount++;
            memoryThread.ThreadId = _threadCount;
            //memoryThread.Thread.Join(1000);
        }

    }
}

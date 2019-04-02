using MemoryLibrary;

namespace SekiroSpeedrunUtil {
    public static class RemoteProc {

        private static RemoteProcess _instance;

        public static RemoteProcess Instance() {
            if (Utils.Sekiro() != null) return _instance ?? (_instance = new RemoteProcess(Utils.Sekiro()));
            return _instance = null;
        }

    }
}



namespace EasyFarm.Engine {
    public class GameInstance {

        private Process _GameProcess;
        protected Process GameProcess {
            get { return _GameProcess; }
            set { _GameProcess = value; }
        }

        public GameInstance(Process process) {
            GameProcess = process;
        }

    }
}
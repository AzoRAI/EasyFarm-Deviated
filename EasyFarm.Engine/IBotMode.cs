
namespace EasyFarm.Engine {
    public interface IBotMode {
        string Name { get; }
        void Setup();
        void Start();
        void Stop();
    }
}
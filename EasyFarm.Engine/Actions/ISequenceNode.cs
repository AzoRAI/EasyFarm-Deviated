
namespace EasyFarm.Engine.Actions {
    public interface ISequenceNode {
        string Name { get; }
        ISequenceNode NextNode { get; }
        ISequenceNode PreviousNode { get; }
        
        void Init();
        void Execute();
        void Next();
    }
}

namespace EasyFarm.Engine.Actions {
    public interface ISequenceNode {
        
        int Index { get; }

        // Name of the Node (I.E. TradeItemNode)
        string Name { get; }
        
        // What action to do after this node
        // TODO: Do we really need this? Won't it just be handled by a list?
        // ISequenceNode NextNode { get; }

        // Built in check to see if we should call this node "Completed"
        bool Completed { get; }

        bool RepeatOnError { get; }

        bool CanContinueOnError { get; }

        // The result of the sequence or any data that needs to be passed on
        ISequenceNodeData SequenceData { get; }

        void Init(ISequenceNodeData data = null);
        Task ExecuteAsync();
        Task PauseAsync();
    }
}
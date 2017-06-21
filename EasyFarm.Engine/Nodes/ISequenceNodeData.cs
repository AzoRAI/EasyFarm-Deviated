namespace EasyFarm.Engine.Actions {
  public class ISequenceNodeData {

    // Node that generated this data
    ISequenceNode Node { get; }
    // Data that needs to be passed on to the next node if any
    object Result { get; }

  }
}
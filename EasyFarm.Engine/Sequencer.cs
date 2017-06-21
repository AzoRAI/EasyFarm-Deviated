namespace EasyFarm.Engine {
    public enum SequencerState {
        Stopped,
        Running,
        Paused
    }

    public class Sequencer {    
        private SequencerState _State;
        public SequencerState State {
            get { return _State; }
        }


        private IEnumerable<ISequenceNode> _Nodes;
        protected IEnumerable<ISequenceNode> Nodes {
            get { return _Nodes; }
        }

        private ISequenceNode _CurrentNode; 
        protected ISequenceNode CurrentNode {
            get { return _CurrentNode; }
            set { _CurrentNode = value; }
        }

        public Sequencer(IEnumerable<ISequenceNode> nodes) {
            // Order the nodes by index
            _Nodes = nodes.OrderBy(x => x.Index);
            _State = SequencerState.Stopped;
            // Setup the first node 
            CurrentNode = Nodes.First();
            // Initialize it so we're ready to go
            CurrentNode.Init()
        }

        public async void StartAsync() {
            _State = SequencerState.Running;

            try {    
                while(CurrentNode != null && CurrentNode != default(ISequenceNode)) {
                    // Execute the Task and wait for it to return
                    await CurrentNode.ExecuteAsync();
                    
                    // If the node finished successfully
                    if (CurrentNode.Completed ||  (CurrentNode.CanContinueOnError && !CurrentNode.RepeatOnError)) {
                        var target = CurrentNode.Index + 1;
                        CurrentNode = Nodes.Where(x => x.Index == target)
                            .FirstOrDefault();
                    } else if (!CurrentNode.Completed && !CurrentNode.RepeatOnError && !CurrentNode.CanContinueOnError) {
                        CurrentNode = null;
                    } 
                }
                
            } catch (Exception ex) {
                //TODO: Add Logging
            }

            _State = SequencerState.Stopped;
        }

        public async void PauseAsync() {
            try {
                await CurrentNode.PauseAsync();
                _State = SequencerState.Paused;
            } catch (Exception ex) {
                // TODO: Add Logging
            }
        }

        public async void StopAsync() {
            try {
                await CurrentMode.StopAsync();
                _State = SequencerState.Stopped;
            } catch (Exception ex) {
                // Enable logging
            }
        }
        
    }
}
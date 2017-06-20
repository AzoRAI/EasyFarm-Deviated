using System;
using System.Linq;
using System.Collections.Generic;

namespace EasyFarm.Engine.Models {
    public class CampSequence {

        private List<CampStep> _Steps;
        public List<CampStep> Steps {
            get { reutrn _Steps; }
            set { _Steps = value; }
        }

        public bool IsDone {
            get { return false; }
        }

        public CampSequence() {
            _Steps = new List<CampStep>();
        }


        public async void Advance() {
            
        }
        
    }
}
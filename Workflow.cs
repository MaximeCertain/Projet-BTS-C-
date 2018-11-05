using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gesAMM
{
    class Workflow
    {
        private DateTime dateDecision;
        private int numEtape;
        private int idDecision;

        public Workflow(DateTime ladateDecision, int lenumEtape, int leidDecision)
        {
            this.dateDecision = ladateDecision;
            this.numEtape = lenumEtape;
            this.idDecision = leidDecision;
        }
        public int getIdDecision() { return this.idDecision; }
        public DateTime getDateDecision() { return this.dateDecision; }
        public int getNumEtape() { return this.numEtape; }
    }
}


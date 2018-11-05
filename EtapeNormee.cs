using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gesAMM
{
    class EtapeNormee : Etape
    {
        private string etapeNormee;
        private DateTime dateEtapeNormee;
        public EtapeNormee(int leNum, string leLibelle, string laEtapeNormee, DateTime laDateEtapeNormee)
            : base(leNum, leLibelle)
        {
            this.etapeNormee = laEtapeNormee;
            this.dateEtapeNormee = laDateEtapeNormee;
        }
        public string getEtapeNormee() { return this.etapeNormee; } 
    public DateTime getDateEtapeNormee() { return this.dateEtapeNormee;  }
    }
}

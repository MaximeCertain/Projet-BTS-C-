using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gesAMM
{
   class Etape
    {
        private int num;
        private string libelle;
   
        public Etape(int leNum, string leLibelle)
        {
            this.num = leNum;
            this.libelle = leLibelle;
        }
        public string getLibelle() { return this.libelle; }
        public int getnum() { return this.num; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gesAMM
{
    class Famille
    {
        private string code;
        private string libelle;
        private int nbMediAmm;

        public Famille(string uncode, string unlibelle, int unNbMediAmm)
        {
            this.code = uncode;
            this.libelle = unlibelle;
            this.nbMediAmm = unNbMediAmm;
        }        
        public string getcodefamille() {  return this.code; }
        public string getlibelle() { return this.libelle; }
        public int getnbMediAmm() { return this.nbMediAmm; }
    }
}

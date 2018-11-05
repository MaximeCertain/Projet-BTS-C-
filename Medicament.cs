using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gesAMM
{
    class Medicament
    {
        private string depotLegal;
        private string nomCommercial;
        private string composition;
        private string effets;
        private string contreIndications;
        private string amm;
        private int derniereEtape;
        private string codeFamille;
        private List<Workflow> lesEtapes;

        public Medicament(string ledepotLegal, string lenomCommercial, string laComposition, string leEffets,
           string laContreIndications, string lamm, int laderniereEtape, string lecodeFamille )
        {
            this.depotLegal = ledepotLegal;
            this.nomCommercial = lenomCommercial;
            this.composition = laComposition;
            this.effets = leEffets;
            this.contreIndications = laContreIndications;
            this.amm = lamm;
            this.derniereEtape = laderniereEtape;
            this.codeFamille = lecodeFamille;
            this.lesEtapes = new List<Workflow>();

        }

        public void ajouterWorkflow(Workflow unWorkflow)
        {
            this.lesEtapes.Add(unWorkflow);   
        }
        public string getDepotLegal() { return this.depotLegal; }
        public string getNomCommercial() { return this.nomCommercial; }
        public string getComposition() { return this.composition; }
        public string getEffets() { return this.effets; }
        public string getContreIndications() { return this.contreIndications; }
        public string getAmm() { return this.amm; }
        public int getDerniereEtape() { return this.derniereEtape; }
        public string getCodeFamille() { return this.codeFamille; }
        public List<Workflow> getlesEtapes() { return this.lesEtapes; }

    }
}

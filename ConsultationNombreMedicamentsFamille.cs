using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gesAMM
{
    public partial class ConsultationNombreMedicamentsFamille : Form
    {
        public ConsultationNombreMedicamentsFamille()
        {
            InitializeComponent();
        }

        private void ConsultationNombreMedicamentsFamille_Load(object sender, EventArgs e)
        {
            foreach (string lecode in Globale.lesFamilles.Keys)
            {
                Famille laFamille = Globale.lesFamilles[lecode];
                ListViewItem laligne = new ListViewItem();
                laligne.Text = Convert.ToString(laFamille.getcodefamille());
                laligne.SubItems.Add(laFamille.getlibelle().ToString());
                laligne.SubItems.Add(laFamille.getnbMediAmm().ToString());

                lvTableau.Items.Add(laligne);

            }
        }

        private void BtnConsultationMedicament_Click(object sender, EventArgs e)
        {
            lvMedicamentsAutorisees.Items.Clear();
            int numligne = lvTableau.SelectedIndices[0];
            string numfamille = lvTableau.Items[numligne].SubItems[0].Text;

            foreach (string lecode in Globale.lesMedicaments.Keys)
            {
                Medicament leMedicament = Globale.lesMedicaments[lecode];
                ListViewItem laligne = new ListViewItem();

                if (leMedicament.getCodeFamille().ToString() == numfamille && 
                    leMedicament.getAmm() != "" )
                {
                    laligne.Text = Convert.ToString(leMedicament.getDepotLegal());
                    laligne.SubItems.Add(leMedicament.getNomCommercial());
                    laligne.SubItems.Add(leMedicament.getComposition());
                    laligne.SubItems.Add(leMedicament.getEffets());
                    laligne.SubItems.Add(leMedicament.getContreIndications());
                    laligne.SubItems.Add(leMedicament.getAmm());
                    laligne.SubItems.Add(leMedicament.getDerniereEtape().ToString());
                    laligne.SubItems.Add(leMedicament.getCodeFamille());

                    lvMedicamentsAutorisees.Items.Add(laligne);
                }
            }
            
        }

        private void lvTableau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

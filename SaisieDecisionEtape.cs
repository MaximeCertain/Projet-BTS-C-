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
    public partial class SaisieDecisionEtape : Form
    {
        public SaisieDecisionEtape()
        {
            InitializeComponent();
        }

        private void SaisieDecisionEtape_Load(object sender, EventArgs e)
        {
            foreach (string leCode in Globale.lesMedicaments.Keys)
            {
                Medicament leMedicament = Globale.lesMedicaments[leCode];
                ListViewItem laligne = new ListViewItem();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvMedicamentsAutorisees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvMedicamentsAutorisees_Click(object sender, EventArgs e)
        {
            int idxEtape = 0;
            
            tbDernierLibelle.Text = ""; tbDerniereNorme.Text = ""; tbNumDerniereEtape.Text = "";
            lblAMM.Visible = false;  tbAMM.Visible = false;

            int derniereetape = 0;
            int resultat = 0;
            int numligne = lvMedicamentsAutorisees.SelectedIndices[0];
            string depotlegal = lvMedicamentsAutorisees.Items[numligne].Text;
            int nouvelleEtape = 0;
            Medicament unMedicament = Globale.lesMedicaments[depotlegal];
            if (Globale.lesMedicaments[depotlegal].getlesEtapes().Count == 0)
            {
                nouvelleEtape = 1;
            }
            else
            {
                idxEtape =unMedicament.getlesEtapes().Count-1;
                derniereetape = unMedicament.getlesEtapes().Count;

                if (derniereetape == 8)
                {
                    MessageBox.Show("toutes les étapes de validation ont déjà été réalisées pour ce Médicament.");
                }
                else
                {
                     resultat = Globale.lesMedicaments[depotlegal].
                        getlesEtapes().ElementAt(idxEtape).getIdDecision();

                    if (resultat == 2)
                    {
                        MessageBox.Show("Dernière étape non validée, il n'est plus possible de saisir d'étapes pour ce médicament");
                    }
                    else
                    {
                        nouvelleEtape = derniereetape + 1;
                    }
                }
            }

            if (nouvelleEtape != 1)
            {
                //dernière Etape Validée

                tbNumDerniereEtape.Text = Convert.ToString(derniereetape);
                tbDernierLibelle.Text = Globale.lesEtapes.ElementAt(derniereetape - 1).getLibelle();

                DateTime dateDerniere = unMedicament.getlesEtapes().ElementAt(idxEtape).getDateDecision();
                dtpDate.Value = dateDerniere;

                Etape unetape = Globale.lesEtapes.ElementAt(idxEtape);
                if (unetape.GetType().ToString() == "gesAMM.EtapeNormee") //debug projet //si l'étape est normée
                {
                    DateTime dateDerniereNorme = (unetape as EtapeNormee).getDateEtapeNormee();

                    tbDerniereNorme.Text = (unetape as EtapeNormee).getEtapeNormee();
                    dtpDerniereDateNorme.Value = dateDerniereNorme;
                }

            }

            if (nouvelleEtape != 0)
            {

                //-- Nouvelle étape
                tbNumEtape.Text = Convert.ToString(nouvelleEtape);
                tbLibelle.Text = Globale.lesEtapes.ElementAt(nouvelleEtape - 1).getLibelle();

                Etape uneNouvelleetape = Globale.lesEtapes.ElementAt(nouvelleEtape - 1);
                if (uneNouvelleetape.GetType().ToString() == "gesAMM.EtapeNormee") //debug projet //si l'étape est normée
                {
                    DateTime dateDerniereNorme = (uneNouvelleetape as EtapeNormee).getDateEtapeNormee();

                    tbNorme.Text = (uneNouvelleetape as EtapeNormee).getEtapeNormee();
                    dtpNorme.Value = dateDerniereNorme;
                }
            }
        }
        private void BtValider_Click(object sender, EventArgs e)
        {
            int numEtape = 0;
            numEtape = Convert.ToInt16(tbNumEtape.Text);
            int coche = 0;
            if (cbEtape.Checked)
            {
                coche = 1;
            }
            else
            {
                coche = 2;
            }

            int numligne = lvMedicamentsAutorisees.SelectedIndices[0];
            string depotlegal = lvMedicamentsAutorisees.Items[numligne].Text;
            Medicament unMedicament = Globale.lesMedicaments[depotlegal];
            Workflow unWorflow = new Workflow(dtpDate.Value, numEtape, coche);
            unMedicament.ajouterWorkflow(unWorflow);

            if (bd.ajouterWorklow(depotlegal, dtpDate.Value, numEtape, coche))
            {
                MessageBox.Show("Le médicament a bien été enregistré");

                if (numEtape == 8 && coche == 1 && tbAMM.Text != "")
                {
                    bd.modifierMedicamentAMM(depotlegal, tbAMM.Text);
                }          
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void lblAMM_Click(object sender, EventArgs e)
        {

        }
        private void cbEtape_CheckedChanged(object sender, EventArgs e)
        {
            if (tbNumEtape.Text == "8" && cbEtape.Checked)
            {
                lblAMM.Visible = true; tbAMM.Visible = true;
            }
        }
    } 
 }

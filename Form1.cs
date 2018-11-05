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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //Connexion à la base de données
            Globale.cnx = new System.Data.SqlClient.SqlConnection();
            Globale.cnx.ConnectionString = "Data Source=HPG3-06;Initial Catalog=GSB_gesAMM;Integrated Security=True;MultipleActiveResultSets=True";
            Globale.cnx.Open();
            Globale.lesDecisions = new List<Decision>();
            Globale.lesEtapes = new List<Etape>();
            bd.lireLesFamilles();
            bd.lireLesMedicaments();
            bd.lireLesMedicamentsAvecEtapes();
            bd.lireLesEtapes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultationNombreMedicamentsFamille lafenetre = new ConsultationNombreMedicamentsFamille();
            lafenetre.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaisieDecisionEtape  lafenetre = new SaisieDecisionEtape();
            lafenetre.Show();
        }
    }
}

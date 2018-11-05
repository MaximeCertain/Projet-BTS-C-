using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace gesAMM
{
    public static class bd
    {
        public static void lireLesFamilles()
        {
            Globale.lesFamilles.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_listeToutesLesFamilles", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                string codeFamille = SqlExec["FAM_CODE"].ToString();
                string libelleFamille = SqlExec["FAM_LIBELLE"].ToString();
                int medicfamille = 0;
                if(SqlExec["FAM_NB_MEDI"].ToString() != "" )
                {
                     medicfamille = int.Parse(SqlExec["FAM_NB_MEDI"].ToString());
                }
                
                

                Famille uneFamille = new Famille(codeFamille, libelleFamille, medicfamille);
                Globale.lesFamilles.Add(codeFamille, uneFamille);
            }
        }
        public static void lireLesMedicaments()
        {
            Globale.lesMedicaments.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_listeMedicaments", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                string DepotLegalMedicament = SqlExec["MED_DEPOT_LEGAL"].ToString().Trim();
                string NomCommercialMedicament = SqlExec["MED_NOMCOMMERCIAL"].ToString();
                string CompositionMedicament = SqlExec["MED_COMPOSITION"].ToString();
                string EffetsMedicament = SqlExec["MED_EFFETS"].ToString();
                string ContreIndicMedicament = SqlExec["MED_CONTREINDIC"].ToString();
                string AMMMedicament = SqlExec["MED_AMM"].ToString();
                int EtapeNumMedicament = 0;
                if (SqlExec["MED_ETP_NUM"].ToString() != "")
                {
                    EtapeNumMedicament = int.Parse(SqlExec["MED_ETP_NUM"].ToString());
                }

                
                string CodeFamilleMedicament = SqlExec["MED_FAM_CODE"].ToString();


                Medicament unMedicament = new Medicament(DepotLegalMedicament, NomCommercialMedicament, CompositionMedicament,
                    EffetsMedicament, ContreIndicMedicament, AMMMedicament, EtapeNumMedicament, CodeFamilleMedicament);
               
                Globale.lesMedicaments.Add(DepotLegalMedicament, unMedicament);
            }
        }



        public static void lireLesDecisions()
        {
            Globale.lesDecisions.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_listeToutesLesDecisions", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                int idDecision = int.Parse(SqlExec["DCS_ID"].ToString());
                string libelleDecision = SqlExec["DSC_LIBELLE"].ToString();

                Decision uneDecision = new Decision(idDecision, libelleDecision);
                Globale.lesDecisions.Add(uneDecision);
            }
        }



        public static void lireLesEtapes()
        {
            Globale.lesEtapes.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_listeEtapes", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                int etapeNum = int.Parse(SqlExec["ETP_NUM"].ToString());
                string libelleEtape = SqlExec["ETP_LIBELLE"].ToString();
                string etpnorme = "";
                DateTime dateNorme = new DateTime();
                if (SqlExec["ETP_NORME"].ToString() != "")
                {
                    etpnorme = (SqlExec["ETP_NORME"].ToString());
                    dateNorme = DateTime.Parse(SqlExec["ETP_DATE_NORME"].ToString());
                }
                if (SqlExec["ETP_NORME"].ToString() != "")
                {
                    Etape uneEtape  = new EtapeNormee(etapeNum, libelleEtape, etpnorme, dateNorme);
                    Globale.lesEtapes.Add(uneEtape as EtapeNormee);
                }
                else
                {
                    Etape uneEtape = new Etape(etapeNum, libelleEtape);
                    Globale.lesEtapes.Add(uneEtape);
                }
                
                
            }
        }



        public static Boolean ajouterWorklow(string depotlegal, DateTime DateDecision, int numEtape, int idDecision)
        {
            SqlCommand maRequete = new SqlCommand("prc_ajouterWorkflow", Globale.cnx);
            // Il s’agit d’une procédure stockée: 
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // Ajouter les parameters à la procédure stockée
            SqlParameter paramDepotLegal = new SqlParameter("@depotlegal", System.Data.SqlDbType.VarChar, 50);
            paramDepotLegal.Value = depotlegal;
            SqlParameter paramDateDecision = new SqlParameter("@DateDecision", System.Data.SqlDbType.Date);
            paramDateDecision.Value = DateDecision.Date;
            SqlParameter paramNumEtape = new SqlParameter("@numEtape", System.Data.SqlDbType.Int);
            paramNumEtape.Value = numEtape;
            SqlParameter paramIdDecision = new SqlParameter("@idDecision", System.Data.SqlDbType.Int);
            paramIdDecision.Value = idDecision;
            maRequete.Parameters.Add(paramDepotLegal);
            maRequete.Parameters.Add(paramDateDecision);
            maRequete.Parameters.Add(paramNumEtape);
            maRequete.Parameters.Add(paramIdDecision);
            // exécuter la procedure stockée
           

                maRequete.ExecuteNonQuery();
                return true;
                  
        }
        public static Boolean modifierMedicamentAMM(string depotlegal,string AMM)
        {
            SqlCommand maRequete = new SqlCommand("prc_modifierMedicamentAMM", Globale.cnx);
            // Il s’agit d’une procédure stockée: 
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // Ajouter les parameters à la procédure stockée
            SqlParameter paramDepotLegal = new SqlParameter("@depotlegal", System.Data.SqlDbType.VarChar, 50);
            paramDepotLegal.Value = depotlegal;
            SqlParameter paramDateDecision = new SqlParameter("@AMM", System.Data.SqlDbType.VarChar,50);
            paramDateDecision.Value = AMM;
            maRequete.Parameters.Add(paramDepotLegal);
            maRequete.Parameters.Add(paramDateDecision);
            // exécuter la procedure stockée

            maRequete.ExecuteNonQuery();
            return true;


        }

        public static void lireLesMedicamentsAvecEtapes()
        {
            Globale.lesMedicaments.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_listeMedicaments", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des medicaments avec ajout dans la collection
            while (SqlExec.Read())
            {
                string DepotLegalMedicament = SqlExec["MED_DEPOT_LEGAL"].ToString();
                string NomCommercialMedicament = SqlExec["MED_NOMCOMMERCIAL"].ToString();
                string CompositionMedicament = SqlExec["MED_COMPOSITION"].ToString();
                string EffetsMedicament = SqlExec["MED_EFFETS"].ToString();
                string ContreIndicMedicament = SqlExec["MED_CONTREINDIC"].ToString();
                string AMMMedicament = SqlExec["MED_AMM"].ToString();
                int EtapeNumMedicament = 0;
                if (SqlExec["MED_ETP_NUM"].ToString() != "")
                {
                    EtapeNumMedicament = int.Parse(SqlExec["MED_ETP_NUM"].ToString());
                }
                string CodeFamilleMedicament = SqlExec["MED_FAM_CODE"].ToString();

                Medicament leMedicament = new Medicament(DepotLegalMedicament, NomCommercialMedicament, CompositionMedicament, EffetsMedicament, ContreIndicMedicament, AMMMedicament, EtapeNumMedicament, CodeFamilleMedicament);

                //gestion des workflow du client
                SqlCommand maRequeteWorkflow = new SqlCommand("prc_listeWorkflowMedicament", Globale.cnx);
                maRequeteWorkflow.CommandType = System.Data.CommandType.StoredProcedure;
                // Ajouter le paramètre idClient à la procédure stockée
                SqlParameter paramIdMedicament = new SqlParameter("@DepotLegalMedicament", System.Data.SqlDbType.VarChar, 50);
                paramIdMedicament.Value = DepotLegalMedicament;
                //ajout du paramètre à la procédure stockée
                maRequeteWorkflow.Parameters.Add(paramIdMedicament);

                // exécuter la procedure stockée dans un curseur 
                SqlDataReader SqlExecWorkflow = maRequeteWorkflow.ExecuteReader();

                //boucle de lecture des clients avec ajout dans la collection
                while (SqlExecWorkflow.Read())
                {
                    DateTime dateDecisionWorkflow = DateTime.Parse(SqlExecWorkflow["WKR_DATEDECISION"].ToString());
                    int numEtapeWorkflow = int.Parse(SqlExecWorkflow["WKR_ETP_NUM"].ToString());
                    int idDecisionWorkflow = int.Parse(SqlExecWorkflow["WKR_DCS_ID"].ToString());

                    Workflow unWorkflow = new Workflow(dateDecisionWorkflow, numEtapeWorkflow, idDecisionWorkflow);
                    leMedicament.ajouterWorkflow(unWorkflow);
                }
                Globale.lesMedicaments.Add(DepotLegalMedicament, leMedicament);
            }

        }
    }
}
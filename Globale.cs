using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace gesAMM
{
    class Globale
    {
        public static SqlConnection cnx;

        public static Dictionary<string, Famille> lesFamilles = new Dictionary<string, Famille>();
        public static Dictionary<string, Medicament> lesMedicaments = new Dictionary<string, Medicament>();

        public static List<Etape> lesEtapes;
        public static List<Decision> lesDecisions;
    }
}

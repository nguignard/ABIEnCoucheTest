using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    public partial class StageE : ContratTemporaireE
    {
        public StageE()
        {
        }

        public StageE(int idContrat, DateTime dateDebutContrat, String qualification, String statut, Decimal salaireContractuel, DateTime? dateFinReelle,
            DateTime dateFin, string motif,
            string ecole, string mission)
        {
            this.ecoleE = ecole;
            this.missionE = mission;


        }

    }
}

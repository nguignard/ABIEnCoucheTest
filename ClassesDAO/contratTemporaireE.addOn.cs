using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    public partial class ContratTemporaireE : ContratTypeE
    {
        public ContratTemporaireE()
        {
        }

        public ContratTemporaireE(int idContrat, DateTime dateDebutContrat, String qualification, String statut, Decimal salaireContractuel, DateTime? dateFinReelle,
            DateTime dateFin, string motif)
            :base( idContrat,  dateDebutContrat,  qualification,  statut,  salaireContractuel, dateFinReelle)
        {
            this.dateFinE = dateFin;
            this.motifE = motif;
        }

    }
}

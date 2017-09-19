using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    public partial class ContratTypeE
    {
        public ContratTypeE()
        {
        }

        public ContratTypeE(int idContrat, DateTime dateDebutContrat, String qualification, String statut, Decimal salaireContractuel, DateTime? dateFinReelle)
        {
            this.idContratE = idContrat;
            this.dateDebutE = dateDebutContrat;
            this.qualificationE = qualification;
            this.statutE = statut;
            this.salaireE = salaireContractuel;
            this.finReelleE = dateFinReelle;
    }

    }
}

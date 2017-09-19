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

        public ContratTypeE(DateTime dateDebutContrat, String qualification, String statut, Decimal salaireContractuel)
        {
            //this.IdContrat = GetNewIdContrat();

            this.dateDebutE = dateDebutContrat;
            this.qualificationE = qualification;
            this.statutE = statut;
            this.salaireE = salaireContractuel;
    }

    }
}

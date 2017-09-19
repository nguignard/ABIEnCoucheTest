using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    public partial class CdiE
    {
        public CdiE()
        {
        }

        public CdiE(int idContrat, DateTime dateDebutContrat, String qualification, String statut, Decimal salaireContractuel, DateTime? dateFinReelle)
                :base(  idContrat,            dateDebutContrat,       qualification,        statut,           salaireContractuel, dateFinReelle)
        {
        }

    }
}

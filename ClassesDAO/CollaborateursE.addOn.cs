using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    public partial class CollaborateursE
    {
        //public CollaborateursE()
        //{

        //}

        public CollaborateursE(int matriculeE, string civiliteE, string nomE, string prenomE, string situationE, string photoE, bool actifE)
        {
            this.matriculeE = matriculeE;
            this.civiliteE = civiliteE;
            this.nomE = nomE;
            this.prenomE = prenomE;
            this.situationE = situationE;
            this.photoE = photoE;
            this.actifE = actifE;
        }
    }
}

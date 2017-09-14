using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIEnCouches
{
    class ctrlVisuContrat
    {

        frmVisuContrat leForm;
        ContratType leContrat;

        public ctrlVisuContrat(ContratType unContrat)
        {
            this.leContrat = unContrat;
            this.leForm = new frmVisuContrat(leContrat);

            this.leForm.ShowDialog();
            this.leForm.AfficheContrat(unContrat);



        }
        
        




        


    }
}

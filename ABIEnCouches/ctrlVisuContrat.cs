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

            this.leForm.btnCloturer.Click += new System.EventHandler(this.btnCloturer_Click);

            this.leForm.Show();
            this.leForm.AfficheContrat(unContrat);



        }

        public frmVisuContrat frmVisuContrat
        {
            get => default(frmVisuContrat);
            set
            {
            }
        }

        private void btnCloturer_Click(object sender, EventArgs e)
        {
            //TODO

        }






    }
}

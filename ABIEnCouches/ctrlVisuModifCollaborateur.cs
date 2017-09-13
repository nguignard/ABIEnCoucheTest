using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIEnCouches
{
    class ctrlVisuModifCollaborateur
    {
        private Collaborateur leCollaborateur;
        frmVisuCollaborateur leForm;

        public ctrlVisuModifCollaborateur(Collaborateur leCollaborateur)
        {
            this.leCollaborateur = leCollaborateur;
            this.leForm = new frmVisuCollaborateur(leCollaborateur);
            this.leForm.Text = leCollaborateur.ToString();

            this.leForm.ShowDialog();




        }










    }
}

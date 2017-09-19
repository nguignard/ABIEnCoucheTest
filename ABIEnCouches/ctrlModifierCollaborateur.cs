using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIEnCouches
{
    class ctrlModifierCollaborateur
    {
        Collaborateur leCollaborateur;
        frmModifierCollaborateur frmModifierCollab;

        public ctrlModifierCollaborateur(Collaborateur unCollaborateur)
        {
            this.leCollaborateur = unCollaborateur;
            frmModifierCollab = new frmModifierCollaborateur(this.leCollaborateur);
            this.frmModifierCollab.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            frmModifierCollab.Show();
        }


        private void btnValider_Click(object sender, EventArgs e)
        {
            this.frmModifierCollab.modifieCollaborateur();







        }

    }
}

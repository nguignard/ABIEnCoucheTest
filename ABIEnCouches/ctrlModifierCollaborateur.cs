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

        public ctrlModifierCollaborateur(Collaborateur unCollaborateur)
        {
            this.leCollaborateur = unCollaborateur;

            frmModifierCollaborateur frmModifierCollab = new frmModifierCollaborateur(this.leCollaborateur);

            frmModifierCollab.ShowDialog();

        }



    }
}

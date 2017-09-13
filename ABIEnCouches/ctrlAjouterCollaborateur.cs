using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIEnCouches
{
    class ctrlAjouterCollaborateur
    {
        private frmAjouterCollab leForm;

        private Collaborateur leCollaborateur;
        private ContratType leContrat; 
        private DialogResult result;

        public ctrlAjouterCollaborateur()
        {
            leForm = new frmAjouterCollab();
           
            this.leForm.btnAjouterPhoto.Click += new System.EventHandler(this.btnAjouterPhoto_Click);
            this.leForm.btnValider.Click += new System.EventHandler(this.btnValider_Click);

            this.leForm.ShowDialog();
        }

        //GET SUR VARIABLE A ENTRER DANS LES COLLECTIONS
        public Collaborateur LeCollaborateur
        {
            get
            {
                return leCollaborateur;
            }
        }
        
        public DialogResult Result
        {
            get
            {
                return result;
            }
        }


        //FONCTIONS-------------------------------------------------------------
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (this.leForm.Controle())
            {
                if (this.leForm.InstancieCollaborateur())
                {
                    this.leForm.DialogResult = DialogResult.OK;
                    this.result = DialogResult.OK;
                    this.leCollaborateur = this.leForm.NewCollaborateur;
                }
                else
                {
                    this.result = DialogResult.No;
                }
            }
        }


        private void btnAjouterPhoto_Click(object sender, EventArgs e)
        {
            //TODO
        }





    }
}

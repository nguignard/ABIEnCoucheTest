using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.leForm.AfficheCollaborateur(leCollaborateur);

            this.leForm.grdContrats.CellDoubleClick += new DataGridViewCellEventHandler(this.grdContrats_DoubleClick);
            this.leForm.btnContratInitial.Click += new System.EventHandler(this.btnContratInitial_Click);
            this.leForm.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            this.leForm.btnCreateContrat.Click += new System.EventHandler(this.btnCreateContrat_Click);

            //this.leForm.btnModifier.Click += new System.EventHandler(this.btnAjouter_Click);

            this.leForm.ShowDialog();
        }


        private void btnModifier_Click(object sender, EventArgs e)
        {
            ctrlModifierCollaborateur ctrl = new ctrlModifierCollaborateur(this.leCollaborateur);


            
            //TODO


        }
        private void btnCreateContrat_Click(object sender, EventArgs e)
        {
            //TODO
        }






        private void grdContrats_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ContratType leContrat;
            Int32 laCle; //idContra
            laCle = (Int32)leForm.grdContrats.CurrentRow.Cells[0].Value;
            leContrat = this.leCollaborateur.RestituerContrat(laCle);
            ctrlVisuContrat ctrl = new ctrlVisuContrat(leContrat);

            //leFormContrat.aff(leContrat);

        }



        private void btnContratInitial_Click(object sender, EventArgs e)
        {
            //ctrlVisuContrat ctrlInitial = new ctrlVisuContrat(leCollaborateur.ContratInitial());
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIEnCouches
{
    public class ctrlListerCollaborateur
    {
        private Collaborateurs listeCollaborateurs;
        private frmListCollab leForm;


        public ctrlListerCollaborateur()
        {
            this.instancieCollaborateurs();
            this.leForm = new frmListCollab(this.listeCollaborateurs);
            this.leForm.afficheCollaborateurs(this.listeCollaborateurs);

            this.leForm.grdCollaborateurs.CellContentClick  += new DataGridViewCellEventHandler(this.grdCollaborateurs_DoubleClick);
            this.leForm.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            this.leForm.MdiParent = frmMDI.Ref;
            this.leForm.Show();
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ctrlAjouterCollaborateur ctrl = new ctrlAjouterCollaborateur();

            if(ctrl.Result == DialogResult.OK)
            {
                this.listeCollaborateurs.AddCollaborateur(ctrl.LeCollaborateur);
                this.leForm.afficheCollaborateurs(this.listeCollaborateurs);

            }

        }

        private void grdCollaborateurs_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Collaborateur leCollaborateur;
            Int32 laCle; //matriculle
            laCle = (Int32)leForm.grdCollaborateurs.CurrentRow.Cells[0].Value;

            leCollaborateur = this.listeCollaborateurs.RestituerCollaborateur(laCle);
            ctrlVisuModifCollaborateur ctrlVisu = new ctrlVisuModifCollaborateur(leCollaborateur);
            
            this.leForm.afficheCollaborateurs(listeCollaborateurs);
        }






        /// <summary>
        /// initialiseListeCollab()
        /// </summary>
        private void instancieCollaborateurs()
        {

            listeCollaborateurs = new Collaborateurs();
            Collaborateur collaborateur = new Collaborateur("M", "DUPOND", "Roger", "marie", true);
            Cdi contrat = new Cdi(new DateTime(2010, 5, 5).Date, "Chef de Projet", "Cadre", 5000);

            collaborateur.AddContrat(contrat);
            listeCollaborateurs.AddCollaborateur(collaborateur);
            collaborateur = new Collaborateur("F", "DUPONt", "Rogee", "marie", false);
            contrat = new Cdi(new DateTime(2012, 6, 6).Date, "CDI", "employee", 1500);

            collaborateur.AddContrat(contrat);
            listeCollaborateurs.AddCollaborateur(collaborateur);
            Console.WriteLine(contrat.ToString());

            Console.Write(listeCollaborateurs.RestituerCollaborateur(2).ToString());
            Console.Write(collaborateur.RestituerContrat(2).ToString());
        }




    }
}

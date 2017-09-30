using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIEnCouches
{
    public partial class frmVisuCollaborateur : Form
    {

        Collaborateur leCollaborateur;

        public frmVisuCollaborateur(Collaborateur unCollab)
        {
            this.leCollaborateur = unCollab;
            InitializeComponent();
            this.AfficheCollab(this.leCollaborateur);
            this.AfficheContrats();



        }


        private void AfficheCollab(Collaborateur unCollab)
        {
            this.Text = this.leCollaborateur.ToString();
            this.txtNumeroMatricule.Text = unCollab.Matricule.ToString();
            this.txtNom.Text = unCollab.NomCollab;
            this.txtPrenom.Text = unCollab.PrenomCollab;
            this.rdbM.Checked = unCollab.Civilite == "M" ? true : false;
            this.rdbF.Checked = unCollab.Civilite == "F" ? true : false;
            this.cmbFamille.SelectedItem = unCollab.SituationFamiliale;
        }

        private void AfficheContrats()
        {
            //TODO : initialiser liste de contrats
        }



        private void btnModifier_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous fermer la fenêtre, Yes pour confirmer", "Fermeture", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}

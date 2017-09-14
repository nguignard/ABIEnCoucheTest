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
    public partial class frmModifierCollaborateur : Form
    {

        Collaborateur leCollaborateur;

        public frmModifierCollaborateur(Collaborateur unCollaborateur)
        {
            this.leCollaborateur = unCollaborateur;
            InitializeComponent();
            this.AfficheCollaborateur(unCollaborateur);

        }



        internal void AfficheCollaborateur(Collaborateur unCollab)
        {
            this.Text = unCollab.ToString();
            this.txtNumeroMatricule.Text = unCollab.Matricule.ToString();
            this.txtNom.Text = unCollab.NomCollab;
            this.txtPrenom.Text = unCollab.PrenomCollab;
            this.rdbM.Checked = unCollab.Civilite == "M" ? true : false;
            this.rdbF.Checked = unCollab.Civilite == "F" ? true : false;
            this.cmbFamille.SelectedItem = unCollab.SituationFamiliale;

            //this.grdContrats.DataSource = unCollab.GetContrats();
            //this.grdContrats.Refresh();
            this.btnFermer.Enabled = true;
        }


    }
}

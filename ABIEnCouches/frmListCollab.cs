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
    

    public partial class frmListCollab : Form
    {

        private Collaborateurs listeCollaborateurs;

        public frmListCollab(Collaborateurs uneliste)
        {
            InitializeComponent();
            this.listeCollaborateurs = uneliste;
        }

        internal void afficheCollaborateurs(Collaborateurs listeCollaborateurs)
        {
            this.grdCollaborateurs.DataSource = listeCollaborateurs.ListerCollaborateurs();
            this.grdCollaborateurs.Refresh();
            this.btnFermer.Enabled = true;
        }

        /// <summary>
        /// btnFermer_Click ferme l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




    }
}

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

        frmVisuCollaborateur leForm;
        ContratType leContrat;

        public ctrlVisuContrat()
        {
            leForm.grdContrats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdContrats_DoubleClick);

        }

        private void grdContrats_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {




            //frmVisuContrat visuContrat = new frmVisuContrat();

            




        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIEnCouches
{
    public static class Outils
    {
        public static void WhiteContrat(frmAjouterCollab leForm)
        {
                leForm.txtEcole.Text = "";
                leForm.txtMission.Text = "";
                leForm.txtMotif.Text = "";
                leForm.txtQualif.Text = "";
                leForm.txtSalaire.Text = "";
                leForm.txtStatut.Text = "";
                leForm.rdbCDI.Checked = true;
        }



        



    }
}

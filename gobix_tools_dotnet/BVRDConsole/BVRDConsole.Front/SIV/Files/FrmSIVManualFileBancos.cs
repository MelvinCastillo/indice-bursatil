using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BVRDConsole.Front.Files
{
    public partial class FrmSIVManualFileBancos : BVRD.Windows.Controls.Base.FrmBaseDialog
    {
        public FrmSIVManualFileBancos()
        {
            InitializeComponent();

            this.usFileManual._FilePatch = BVRD.Global.SIV_Parameters.FilePatchBancos;
            this.usFileManual._FilesExtensions = BVRD.Global.SIV_Parameters.FilesExtensionsBancos;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
 
    }
}

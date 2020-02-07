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
    public partial class FrmSIVManualFile : BVRD.Windows.Controls.Base.FrmBaseDialog
    {
        public FrmSIVManualFile()
        {
            InitializeComponent();

            this.usFileManual._FilePatch = BVRD.Global.SIV_Parameters.FilePatch;
            this.usFileManual._FilesExtensions = BVRD.Global.SIV_Parameters.FilesExtensions;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
 
    }
}

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
    public partial class FrmGobixManualFile : BVRD.Windows.Controls.Base.FrmBaseDialog
    {
        public FrmGobixManualFile()
        {
            InitializeComponent();

            this.usFileManual._FilePatch = BVRD.Global.Gobix_Parameters.FilePatch;
            this.usFileManual._FilesExtensions = BVRD.Global.Gobix_Parameters.FilesExtensions;
        }
    }
}

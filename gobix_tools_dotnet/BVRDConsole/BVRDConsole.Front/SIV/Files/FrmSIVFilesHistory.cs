using BVRD.Windows.Controls.Base;
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
    public partial class FrmSIVFilesHistory : FrmBaseDataView
    {
        private SIV.BusinessLayer.SIVData _SIVData = new SIV.BusinessLayer.SIVData();

        public FrmSIVFilesHistory()
        {
            InitializeComponent();

            usDataView._Dataset = _SIVData.exe_SP_Get_SIVVectoresEncabezado();
            usDataView._TableIndex = 0;
        }
    }
}

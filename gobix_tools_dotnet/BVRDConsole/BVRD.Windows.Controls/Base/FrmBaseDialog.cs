using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BVRD.Windows.Controls.Base
{
    public partial class FrmBaseDialog : BVRD.Windows.Controls.Base.FrmBase
    {
        public FrmBaseDialog()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }
    }
}

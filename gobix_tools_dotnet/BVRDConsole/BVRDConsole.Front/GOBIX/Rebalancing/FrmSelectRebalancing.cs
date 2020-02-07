using System;
using BVRD.Windows.Controls.Base;
using BVRDConsole.Front.GOBIX.Rebalancing;

namespace BVRDConsole.Front.Rebalancing
{
    public partial class FrmSelectRebalancing : FrmBase
    {
        public FrmSelectRebalancing()
        { InitializeComponent(); }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDoRebalancing frm = new FrmDoRebalancing();
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                { this.Close(); }
            }
            catch
            { }
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            try
            {
                FrmRebalancing_Ponderation frm = new FrmRebalancing_Ponderation();
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                { this.Close(); }
            }
            catch
            { }
        }
    }
}

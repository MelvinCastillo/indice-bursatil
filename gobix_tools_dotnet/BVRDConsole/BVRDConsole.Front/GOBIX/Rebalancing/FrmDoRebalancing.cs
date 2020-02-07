using System;
using BVRD.Windows.Controls.Base;

namespace BVRDConsole.Front.Rebalancing
{
    public partial class FrmDoRebalancing : FrmBaseDialog
    {
        public FrmDoRebalancing()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime RebalancingDate = this.monthCalendar.SelectionStart;
                double Tipp = 0;

                if (!string.IsNullOrEmpty(RebalancingDate.ToString()))
                {
                    if (double.TryParse(txtTipp.Text, out Tipp))
                    {
                        Gobix.BusinessLayer.GobixData GobixData = new Gobix.BusinessLayer.GobixData();
                        GobixData.exe_SP_Create_Rebalancing(RebalancingDate, Tipp);
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                        this.Close();
                    }
                }
            }
            catch
            { }
        }

        private void FrmDoRebalancing_Load(object sender, EventArgs e)
        { monthCalendar.MaxDate = DateTime.Now; }
    }
}

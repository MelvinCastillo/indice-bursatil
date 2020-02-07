using System;
using System.Data;

namespace BVRDConsole.Front.Index
{
    public partial class FrmRunIndex : BVRD.Windows.Controls.Base.FrmBaseDialog
    {

        private Gobix.BusinessLayer.GobixData _GobixData = new Gobix.BusinessLayer.GobixData();

        public FrmRunIndex()
        {
            InitializeComponent();
            btnOK.Enabled = false;
            usGobixResult._Dataset = null;
            base.ShowMsg(string.Empty);
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            btnOK.Enabled = false;
            usGobixResult._Dataset = null;

            if (!string.IsNullOrEmpty(dateFile.Value.ToString()))
            {
                DataSet ds = _GobixData.exe_SP_Validate_Before_Execute(dateFile.Value);  

                txtFileDate.Text = BVRD.Global.Gobix_Parameters.GetFileName(dateFile.Value);
                txtRegCount.Text = ds.Tables[0].Rows[0][1].ToString();
                int inxCount = Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString());

                if (inxCount > 0)
                //{ btnOK.Enabled = false; }
                { btnOK.Enabled = true; }
                else
                { btnOK.Enabled = true; }

                DataSet dsView = _GobixData.exe_SP_Sel_Index_Result(dateFile.Value);
                usGobixResult._Dataset = dsView;
            }
            else
            { btnOK.Enabled = false; }
        }

        private void FrmRunIndex_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = _GobixData.exe_SP_Sel_Rebalancing_Master(1);

                DataTable dt = ds.Tables[0];

                DataRow dr = dt.Rows[0];

                usViewRebalancing1._ID = Convert.ToInt32(dr[0].ToString());
                usViewRebalancing1._Date = Convert.ToDateTime(dr[1].ToString());
                usViewRebalancing1._LastDate = Convert.ToDateTime(dr[3].ToString());
                usViewRebalancing1._BeforeLastDate = Convert.ToDateTime(dr[4].ToString());
                usViewRebalancing1._TIPPP = Convert.ToDouble(dr[5].ToString());
                usViewRebalancing1._Status = Convert.ToBoolean(dr[6].ToString());
            }
            catch
            {
                throw;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int id = this.usViewRebalancing1._ID;

                if (id > 0)
                {
                    DataSet ds = _GobixData.exe_SP_CALC_Index_With_Result(dateFile.Value, id);
                    usGobixResult._Dataset = ds;

                    base.ShowMsg("Procesado!");
                }
                else
                {
                    base.ShowMsg("Debe Seleccionar un Rebalanceo valido, Verifique!");
                }
            }
            catch (Exception ex)
            {
                base.ShowMsg(ex.Message);
            }
        }

    }
}

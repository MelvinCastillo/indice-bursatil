using BVRD.Windows.Controls.Base;
using System;
using System.Data;
using System.Windows.Forms;

namespace BVRDConsole.Front.Rebalancing
{
    public partial class FrmViewRebalancing : FrmBaseDataView
    {
        private Gobix.BusinessLayer.GobixData _GobixData = new Gobix.BusinessLayer.GobixData();
        public int page;

        DataTable dtRebalancingMaster = new DataTable();

        public FrmViewRebalancing()
        {
            InitializeComponent();


            Application.DoEvents();

            this.WindowState = FormWindowState.Maximized;

            
            Application.DoEvents();
        }

        private void FrmViewRebalancing_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            try
            {
                DataSet dsRebalancingMaster = _GobixData.exe_SP_Sel_Rebalancing_Master(null);
                lvRebalancing.Items.Clear();
                dtRebalancingMaster = dsRebalancingMaster.Tables[0];

                foreach (DataRow row in dtRebalancingMaster.Rows)
                {
                    ListViewItem item = new ListViewItem(row["ID"].ToString());
                    item.SubItems.Add(row["CurrentDate"].ToString());
                    lvRebalancing.Items.Add(item);
                }

                if (page == 1)
                {
                    this.qTabControl.ActiveTabPage = this.qtpRebalancing;
                }
                else
                {
                    this.qTabControl.ActiveTabPage = this.qtpWeights;
                }

                tsActiveRebalancing.Enabled = false;
            }
            catch
            {  }
        }

        private void lvRebalancing_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvRebalancing.SelectedItems.Count > 0)
                {
                    int selectId = Convert.ToInt32(lvRebalancing.SelectedItems[0].Text.ToString());

                    dataBind(selectId);

                    ShowRebalancing(selectId);

                    tsActiveRebalancing.Enabled = true;
                    usViewRebalancing.Visible = true;
                }
                else
                {
                    this.udvRebalancing._Dataset = null;
                    this.udvWeights._Dataset = null;

                    tsActiveRebalancing.Enabled = false;
                    usViewRebalancing.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataBind(int id)
        {
            try
            {
                if (id > 0)
                {
                    udvRebalancing._Dataset = null;
                    udvWeights._Dataset = null;

                    Application.DoEvents();

                    DataSet ds = _GobixData.exe_SP_Sel_Rebalancing(id);

                    DataSet dsRebalancing = new DataSet();

                    dsRebalancing.Tables.Add(ds.Tables[0].Copy());
                    dsRebalancing.Tables.Add(ds.Tables[1].Copy());

                    DataSet dsWeights = new DataSet();

                    dsWeights.Tables.Add(ds.Tables[2].Copy());
                    dsWeights.Tables.Add(ds.Tables[3].Copy());

                    ds.Dispose();

                    if (ds.Tables.Count > 2)
                    {
                        udvRebalancing._Dataset = dsRebalancing;
                        udvRebalancing._TableIndex = 0;

                        Application.DoEvents();

                        udvWeights._Dataset = dsWeights;
                        udvWeights._TableIndex = 0;

                        Application.DoEvents();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsActiveRebalancing_Click(object sender, EventArgs e)
        {
            try
            {
                int selectId = Convert.ToInt32(usViewRebalancing._ID.ToString());

                _GobixData.exe_SP_Set_Activate_Rebalancing(selectId);

                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowRebalancing(int id)
        {
            try
            {
                DataRow[] dr = dtRebalancingMaster.Select("ID = " + id.ToString());

                usViewRebalancing._ID = id;
                usViewRebalancing._Date = Convert.ToDateTime(dr[0][1].ToString());
                usViewRebalancing._LastDate = Convert.ToDateTime(dr[0][3].ToString());
                usViewRebalancing._BeforeLastDate = Convert.ToDateTime(dr[0][4].ToString());
                usViewRebalancing._TIPPP = Convert.ToDouble(dr[0][5].ToString());
                usViewRebalancing._Status = Convert.ToBoolean(dr[0][6].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
    }
}

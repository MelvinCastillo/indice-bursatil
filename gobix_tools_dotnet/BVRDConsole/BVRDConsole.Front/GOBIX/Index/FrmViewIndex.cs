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

namespace BVRDConsole.Front.Index
{
    public partial class FrmViewIndex : FrmBaseDataView
    {
        private Gobix.BusinessLayer.GobixData _GobixData = new Gobix.BusinessLayer.GobixData();

        public FrmViewIndex()
        {
            InitializeComponent();

            try
            {
                DataSet ds = _GobixData.exe_SP_GET_TBL_INDEX_MASTER();

                cmbIndexList.DataSource = ds.Tables[0];
                cmbIndexList.DisplayMember = "Descripcion";
                cmbIndexList.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cmbIndexList.SelectedValue);
                DateTime dtIni = dtpDateini.Value;
                DateTime dtFin = dtpDatefin.Value;

                DataSet ds = _GobixData.exe_SP_Sel_Index_View(id, dtIni, dtFin);

                usDataView._Dataset = ds;
                usDataView._TableIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

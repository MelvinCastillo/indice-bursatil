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
    public partial class FrmViewDataSivResult : FrmBaseDataView
    {
        private SIV.BusinessLayer.SIVData _SIVData = new SIV.BusinessLayer.SIVData();

        public FrmViewDataSivResult()
        {
            InitializeComponent();            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.usDataView._Clear();

                int idFiltro = cmbFiltros.SelectedIndex +1;

                this.usDataView._Dataset = _SIVData.exe_SP_GEN_PIPCA_DATA_OTC_SIV_GRID(dateTimePicker.Value,
                    Convert.ToInt32(cmbCargas.SelectedValue),
                    idFiltro);

                this.usDataView._TableIndex = 0;

                if ((this.usDataView._RecordCount > 0) && (cmbFiltros.SelectedIndex == 3))
                {
                    btnSendFile.Enabled = true;
                }
                else
                {
                    btnSendFile.Enabled = false;
                }
            }  
            catch (Exception ex)  { string Msg = "{0} Exception caught." +  ex;
                    base.ShowMsg(Msg); }
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    int idFiltro = cmbFiltros.SelectedIndex + 1;

                    FrmSIVPublish frm = new FrmSIVPublish();
                    frm._currentDate = dateTimePicker.Value;
                    frm._ID_Carga = Convert.ToInt32(cmbCargas.SelectedValue);
                    frm._OpcionData = idFiltro;

                    frm.ShowDialog();
                }
                catch 
                { }
            }
            catch { }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            cmbCargas.DataSource = null;

            try
            {
                DataSet ds = _SIVData.exe_sp_SIVGetCargas(dateTimePicker.Value);

                cmbCargas.ValueMember = "ID_Carga";
                cmbCargas.DisplayMember = "ID_Carga";

                cmbCargas.DataSource = ds.Tables[0];

                if (ds.Tables[0].Rows.Count > 0)
                {
                    btnSearch.Enabled = true;
                }
                else
                {
                    btnSearch.Enabled = false;
                }
            }
            catch 
            { }

        }

        private void usDataView_Load(object sender, EventArgs e)
        {

        }
    }
}

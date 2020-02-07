using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BVRDConsole.Front.Files;
using BVRDConsole.Front.Index;
using BVRDConsole.Front.Rebalancing;
using Qios.DevSuite.Components.Ribbon;

namespace BVRDConsole.Front
{
    public partial class frmMain : QRibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.label1.Text = "Año Actual: " + BVRD.Global.Global_Parameters.Year.ToString();
                txtYearEdit.Text = BVRD.Global.Global_Parameters.Year.ToString();

                this.Text = string.Format(this.Text, Application.ProductVersion);
                this.tsUserName.Text = string.Format(tsUserName.Text, BVRD.Global.Global_Parameters.UserName);
                this.tsDomain.Text = string.Format(tsDomain.Text, BVRD.Global.Global_Parameters.AppDomain);            
            }
            catch 
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            if (txtYearEdit.Text.Length ==4)
            {
                Gobix.BusinessLayer.BussinessDays vBussinessDays = new Gobix.BusinessLayer.BussinessDays();
                vBussinessDays.generate(Convert.ToInt32(txtYearEdit.Text));
            }

            button1.Enabled = true;

            MessageBox.Show("Done!");
        }

        private void qrItemProcessFile_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            try
            {
                FrmGobixProcessFiles frm = new FrmGobixProcessFiles();
                frm.ShowDialog();
            }
            catch 
            { }
        }

        private void qcbFtpFiles_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            try
            {
                FrmGobixFtpFiles frm = new FrmGobixFtpFiles();
                frm.ShowDialog();
            }
            catch 
            { }
        }

        private void qrItemCalIndix_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            try
            {
                FrmRunIndex frm = new FrmRunIndex();
                frm.ShowDialog();
            }
            catch 
            { }
        }

        private void qrItemPublishIndex_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            try
            {
                FrmPublish frm = new FrmPublish();
                frm.ShowDialog();
            }
            catch 
            { }
        }

        private void qrItemRebalancing_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            try
            {
                FrmSelectRebalancing frm = new FrmSelectRebalancing();

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                {
                    qcbViewRebalancing_ItemActivated(sender, e);
                }
            }
            catch 
            { }
        }

        private void qcbViewRebalancing_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            try
            {
                FrmViewRebalancing frm = new FrmViewRebalancing();
                frm.page = 1;
                frm.MdiParent = this;                
                frm.Show();
            }
            catch 
            { }
        }

        private void qcbWeight_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            try
            {
                FrmViewRebalancing frm = new FrmViewRebalancing();
                frm.page = 2;
                frm.MdiParent = this;                
                frm.Show();
            }
            catch 
            { }
        }

        private void qrItemViewIndex_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            try
            {
                FrmViewIndex frm = new FrmViewIndex();
                frm.MdiParent = this;
                frm.Show();
            }
            catch 
            { }
        }

        private void qrItemSIVProcessFile_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            try
            {
                FrmSIVProcessFiles frm = new FrmSIVProcessFiles();
                frm.ShowDialog();
            }
            catch 
            { }
        }

        private void qcbSIVFtpFiles_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            try
            {
                FrmSIVFtpFiles frm = new FrmSIVFtpFiles();
                frm.ShowDialog();
            }
            catch 
            { }
        }

        private void qrItemSIVFilesList_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {            
            try
            {
                FrmSIVFilesHistory frm = new FrmSIVFilesHistory();
                frm.MdiParent = this;
                frm.Show();
            }
            catch 
            { }
        }

        private void qrItemSIVViewResult_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            try
            {
                FrmViewDataSivResult frm = new FrmViewDataSivResult();
                frm.MdiParent = this;
                frm.Show();
            }
            catch 
            { }
        }

        private void qcbSIVManualFiles_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            try
            {
                FrmSIVManualFile frm = new FrmSIVManualFile();
                frm.MdiParent = this;
                frm.Show();
            }
            catch 
            { }
        }

        private void qcbGobixManualFiles_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            try
            {
                FrmGobixManualFile frm = new FrmGobixManualFile();
                frm.MdiParent = this;
                frm.Show();
            }
            catch 
            { }
        }

        private void qrbSIV_Activated(object sender, EventArgs e)
        {

        }

        private void qrbGobix_Activated(object sender, EventArgs e)
        {

        }

        private void qRibbonItem1_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            try
            {
                FrmSIVFilesHistoryBancos frm = new FrmSIVFilesHistoryBancos();
                frm.MdiParent = this;
                frm.Show();
            }
            catch
            { }
        }

        private void qCompositeButton1_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            try
            {
                FrmSIVFtpFilesBancos frm = new FrmSIVFtpFilesBancos();
                frm.ShowDialog();
            }
            catch
            { }
        }

        private void qrItemSIVFilesList_ItemActivating(object sender, Qios.DevSuite.Components.QCompositeCancelEventArgs e)
        {

        }

        private void qCompositeButton2_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            try
            {
                FrmSIVManualFileBancos frm = new FrmSIVManualFileBancos();
                frm.MdiParent = this;
                frm.Show();
            }
            catch
            { }
        }

        private void qRibbonItem2_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            try
            {
                FrmSIVProcessFilesBancos frm = new FrmSIVProcessFilesBancos();
                frm.ShowDialog();
            }
            catch
            { }
        }

        private void qRibbonItem3_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            try
            {
                FrmViewDataSivResult frm = new FrmViewDataSivResult();
                frm.MdiParent = this;
                frm.Show();
            }
            catch
            { }
        }
    }
}

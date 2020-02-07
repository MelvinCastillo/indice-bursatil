using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BVRDConsole.Front.Files
{
    public partial class FrmSIVPublish : BVRD.Windows.Controls.Base.FrmBaseDialog
    {
        SIV.BusinessLayer.SIVData _SIVData = new SIV.BusinessLayer.SIVData();

        string mask = BVRD.Global.SIV_Parameters.FilesExtensions;
        string patch = BVRD.Global.SIV_Parameters.SIV_SivDataPatch;

        public DateTime  _currentDate {get ; set; }

        public int _ID_Carga { get; set; }
        public int _OpcionData { get; set; }

        public FrmSIVPublish()
        {
            InitializeComponent();

            this.usFileBrowser._FilePatch = patch;
            this.usFileBrowser._FilesExtensions = mask;            
        }

        private void CreateFile()
        {
            try
            {
                if (!string.IsNullOrEmpty(patch) || Directory.Exists(patch))
                {
                    bool xmlr = _SIVData.exe_SP_GEN_PIPCA_DATA_OTC_SIV_XML(_currentDate, _ID_Carga, _OpcionData);

                    if (xmlr)
                    {
                        usFileBrowser._Refresh();
                    }                    
                }  
            }
            catch (Exception ex)
            {
                base.ShowMsg(ex.Message.ToString());
            }
        }

        private void FrmSIVPublish_Load(object sender, EventArgs e)
        {
            CreateFile();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                btnOK.Enabled = false;

                BVRD.FTP.Utils.clFTP.ftpServerIP = BVRD.Global.SIV_Parameters.UpLoadftpServerIP;
                BVRD.FTP.Utils.clFTP.ftpUserID = BVRD.Global.SIV_Parameters.UpLoadftpUserID;
                BVRD.FTP.Utils.clFTP.ftpPassword = BVRD.Global.SIV_Parameters.UpLoadftpPassword;

                BVRD.FTP.Utils.clFTP.ftpUploadPatch = BVRD.Global.SIV_Parameters.UpLoadftpPatch;

                string[] files = System.IO.Directory.GetFiles(patch, mask);

                int filesCount = 0;
                foreach (string s in files)
                {
                    BVRD.FTP.Utils.clFTP.Upload(s);
                    filesCount++;
                }                
            }
            catch (Exception ex)
            {
                base.ShowMsg(ex.Message.ToString());
            }
            finally
            {
                base.ShowMsg("Proceso Terminado Exitosamente!");
                btnOK.Enabled = true;
            }
        }
    }
}

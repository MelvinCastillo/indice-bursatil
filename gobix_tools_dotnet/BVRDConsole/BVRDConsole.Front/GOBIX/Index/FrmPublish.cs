using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace BVRDConsole.Front.Index
{
    public partial class FrmPublish : BVRD.Windows.Controls.Base.FrmBaseDialog
    {
        string mask = "*.*";
        string patch = BVRD.Global.Gobix_Parameters.GobixDataPatch;

        private Gobix.BusinessLayer.GobixData _GobixData = new Gobix.BusinessLayer.GobixData();

        public FrmPublish()
        {
            InitializeComponent();

            this.usFileBrowser._FilePatch = patch;
            this.usFileBrowser._FilesExtensions = mask;
        }

        private bool GenerateFiles(string patch)
        {
            try
            {
                if (!string.IsNullOrEmpty(patch) || Directory.Exists(patch))
                {
                    DataSet ds = _GobixData.exe_SP_GET_TBL_INDEX_MASTER();

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        int ID = Convert.ToInt32(row["ID"].ToString());

                        string _Descripcion = row["Descripcion"].ToString();

                        string _DataFileName = row["DataFileName"].ToString();
                        string _DashBoardFileName = row["DashBoardFileName"].ToString();

                        DataSet dsResult = _GobixData.exe_SP_GET_Gobix_Data(ID);

                        string DataFileName = patch + _DataFileName;

                        using (StreamWriter writerDataFileName = new StreamWriter(DataFileName))
                        {
                            Gobix.BusinessLayer.GobixFilesManager.WriteDataTable(dsResult.Tables[0], writerDataFileName, false);
                        }

                        string DashBoardFileName = patch + _DashBoardFileName;

                        using (StreamWriter writerDashBoardFileName = new StreamWriter(DashBoardFileName))
                        {
                            Gobix.BusinessLayer.GobixFilesManager.WriteDataTable(dsResult.Tables[1], writerDashBoardFileName, false);
                        }                        
                    }
                    return true;
                }
                else
                { 
                    return false; 
                }
            }
            catch (Exception ex)
            {
                base.ShowMsg(ex.Message.ToString());
                return false;
            }
            //return false; 
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                btnOK.Enabled = false;

                if (GenerateFiles(patch))
                {

                    BVRD.FTP.Utils.clFTP.ftpServerIP = BVRD.Global.Gobix_Parameters.UpLoadftpServerIP;
                    BVRD.FTP.Utils.clFTP.ftpUserID =  BVRD.Global.Gobix_Parameters.UpLoadftpUserID;
                    BVRD.FTP.Utils.clFTP.ftpPassword =BVRD.Global.Gobix_Parameters.UpLoadftpPassword;

                    BVRD.FTP.Utils.clFTP.ftpUploadPatch = BVRD.Global.Gobix_Parameters.UpLoadftpPatch;

                    string[] files = System.IO.Directory.GetFiles(patch, mask);

                    int filesCount = 0;
                    foreach (string s in files)
                    {
                        BVRD.FTP.Utils.clFTP.Upload(s);
                        filesCount++;
                    }

                    if (filesCount > 0)
                    {

                        if (!string.IsNullOrEmpty(BVRD.Global.Gobix_Parameters.GobixUpdateURL))
                        {
                            base.ShowMsg(BVRD.FTP.Utils.clFTP.ftpStatus);

                            var request = (HttpWebRequest)WebRequest.Create(BVRD.Global.Gobix_Parameters.GobixUpdateURL);

                            var response = (HttpWebResponse)request.GetResponse();

                            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();   
                        }
                    }
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

        private void usFileBrowser_Load(object sender, EventArgs e)
        {

        }
    }
}

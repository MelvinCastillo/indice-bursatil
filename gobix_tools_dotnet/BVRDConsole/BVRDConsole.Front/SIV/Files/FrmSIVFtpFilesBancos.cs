using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Net;


namespace BVRDConsole.Front.Files
{
    public partial class FrmSIVFtpFilesBancos : BVRD.Windows.Controls.Base.FrmBaseDialog
    {
        SIV.BusinessLayer.SIVData _SIVData = new SIV.BusinessLayer.SIVData();

        public FrmSIVFtpFilesBancos()
        {
            InitializeComponent();
    
            setDate();

            this.lbvServer.Text = BVRD.Global.SIV_Parameters.DownLoadftpServerIP;
            this.lbvUser.Text = BVRD.Global.SIV_Parameters.DownLoadftpUserID;
            this.lbvPassword.Text = "*************"; 
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnOK.Enabled = false;

            BVRD.FTP.Utils.clFTP.ftpServerIP = BVRD.Global.SIV_Parameters.DownLoadftpServerIP;
            BVRD.FTP.Utils.clFTP.ftpUserID = BVRD.Global.SIV_Parameters.DownLoadftpUserID;
            BVRD.FTP.Utils.clFTP.ftpPassword = BVRD.Global.SIV_Parameters.DownLoadftpPassword;

            var list = new List<string>(); 
            string filename = lbDefaultFileName.Text.ToString(); 

            list.AddRange(BVRD.FTP.Utils.clFTP.GetFileList());

            if (list.Contains(filename))
            {
                string destFile = BVRD.Global.SIV_Parameters.FilePatchBancos + @"\" + filename;

                if (System.IO.File.Exists(destFile))
                {
                    System.IO.File.Delete(destFile);
                }                
                BVRD.FTP.Utils.clFTP.Download(BVRD.Global.SIV_Parameters.FilePatchBancos, filename);

                base.ShowMsg(BVRD.FTP.Utils.clFTP.ftpStatus);

                /*Generacion de Log del archivo bitacora*/
                if (BVRD.FTP.Utils.clFTP.ftpStatusDescarga.ToString() == "SI")
                {
                    string uri = "ftp://" + BVRD.FTP.Utils.clFTP.ftpServerIP.ToString() + "/" + filename.ToString();
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
                    request.Proxy = null;
                    request.UseBinary = true;
                    request.Credentials = new NetworkCredential(BVRD.FTP.Utils.clFTP.ftpUserID, BVRD.FTP.Utils.clFTP.ftpPassword);
                    request.Method = WebRequestMethods.Ftp.GetDateTimestamp;
                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    //Console.WriteLine("{0} {1}", uri, response.LastModified);
                    //base.ShowMsg(response.LastModified.ToString());
                    if (response.LastModified.ToString() != "")
                    {
                        int a = _SIVData.exe_sp_LogOTCSIV(response.LastModified, "Transacciones_bancos.csv");   
                    }
                }
            }
           /* else
            {
                base.ShowMsg(string.Format("Archivo {0}, No se encuentra disponible.", filename));
                
            }*/

            btnOK.Enabled = true;
        }

        private void dateFile_ValueChanged(object sender, EventArgs e)
        {
            setDate();
        }

        private void setDate()
        {
            lbDefaultFileName.Text = BVRD.Global.SIV_Parameters.GetFileNameBancos();
        }       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BVRDConsole.Front.Files
{
    public partial class FrmGobixFtpFiles : BVRD.Windows.Controls.Base.FrmBaseDialog
    {
        public FrmGobixFtpFiles()
        {
            InitializeComponent();
            
            DateTime rightNow = DateTime.Now;

            dateFile.Value = rightNow;
            setDate();

            this.lbvServer.Text = BVRD.Global.Gobix_Parameters.DownLoadftpServerIPRdval;
            this.lbvUser.Text = BVRD.Global.Gobix_Parameters.DownLoadftpUserIDRdval;
            this.lbvPassword.Text = "*************";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnOK.Enabled = false;
            var list = new List<string>();
            string filename = lbDefaultFileName.Text.ToString();
            //string filename = "VectorPreciosRD_20180720.txt"; 
            /*Descargo el archivo desde la Fuente luego del problema con Rubycom y haber migrado a un nuevo servidor*/

            BVRD.FTP.Utils.clFTP.ftpServerIP = BVRD.Global.Gobix_Parameters.DownLoadftpServerIPRdval+"/etc/x.vectorbolsa";
            BVRD.FTP.Utils.clFTP.ftpUserID = BVRD.Global.Gobix_Parameters.DownLoadftpUserIDRdval;
            BVRD.FTP.Utils.clFTP.ftpPassword = BVRD.Global.Gobix_Parameters.DownLoadftpPasswordRdval;
            list.AddRange(BVRD.FTP.Utils.clFTP.GetFileListSFTP()); //cambiando a sftp 29-01-2020 
            if (list.Contains(filename))//filename
            {
                string destFile = BVRD.Global.Gobix_Parameters.FilePatch + @"\" + filename;

                if (System.IO.File.Exists(destFile))
                {
                    System.IO.File.Delete(destFile);
                }

                BVRD.FTP.Utils.clFTP.Download(BVRD.Global.Gobix_Parameters.FilePatch, filename);

                base.ShowMsg(BVRD.FTP.Utils.clFTP.ftpStatus);
            }
            else
            {
                base.ShowMsg(string.Format("Archivo {0}, Aun no se encuentra disponible en el FTP.", filename));

            }

            /*FIN Descargo del archivo VectorPreciosRD_LAFECHA*/
            /*
            BVRD.FTP.Utils.clFTP.ftpServerIP = BVRD.Global.Gobix_Parameters.DownLoadftpServerIP;
            BVRD.FTP.Utils.clFTP.ftpUserID = BVRD.Global.Gobix_Parameters.DownLoadftpUserID;
            BVRD.FTP.Utils.clFTP.ftpPassword = BVRD.Global.Gobix_Parameters.DownLoadftpPassword;
            list.AddRange(BVRD.FTP.Utils.clFTP.GetFileList());

           // MessageBox.Show(BVRD.Global.Gobix_Parameters.DownLoadftpUserID);
           // MessageBox.Show(BVRD.Global.Gobix_Parameters.DownLoadftpPassword);


            if (list.Contains(filename))
            {
                string destFile = BVRD.Global.Gobix_Parameters.FilePatch + @"\" + filename;

                if (System.IO.File.Exists(destFile))
                {
                    System.IO.File.Delete(destFile);
                }                

                BVRD.FTP.Utils.clFTP.Download(BVRD.Global.Gobix_Parameters.FilePatch, filename);

                base.ShowMsg(BVRD.FTP.Utils.clFTP.ftpStatus);
            }
            else
            {
                base.ShowMsg(string.Format("Archivo {0}, No se encuentra disponible.", filename));
                
            }
            */
            btnOK.Enabled = true;
        }

        private void dateFile_ValueChanged(object sender, EventArgs e)
        {
            setDate();
        }

        private void setDate()
        {
            lbDefaultFileName.Text = BVRD.Global.Gobix_Parameters.GetFileName(dateFile.Value);
        }       
    }
}

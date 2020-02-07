using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BVRDConsole.Front
{
    static class Program
    {
        static string Msg = string.Empty;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            if (setParameters())
            {
                if (TestParameters())
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);


                    FrmLogin login = new FrmLogin();
                    login.AppDomain = BVRD.Global.Global_Parameters.AppDomain;

                    if (login.ShowDialog() == DialogResult.OK)
                    {                        
                        Application.Run(new frmMain());
                    }
                    else
                    {
                        Application.Exit();
                    }
                    login.Dispose();
                }
                else
                {
                    MessageBox.Show(null, Msg, "GOBIXDR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(null, Msg, "GOBIXDR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool setParameters()
        {
            try
            {

                //GOBIX
                
                 string Gobix_ConectionString = BVRD.Security.Utils.CryptorEngine.Decrypt(
                     ConfigurationManager.AppSettings["GOBIX_ConectionString"].ToString().Trim(), true); 

                BVRD.Global.Gobix_Parameters.ConectionString = Gobix_ConectionString;

                string Gobix_DatePatter = ConfigurationManager.AppSettings["GOBIX_DatePatter"].ToString();

                BVRD.Global.Gobix_Parameters.DatePatter = Gobix_DatePatter;

                string Gobix_FilesExtensions = ConfigurationManager.AppSettings["GOBIX_FilesExtensions"].ToString();
                BVRD.Global.Gobix_Parameters.FilesExtensions = Gobix_FilesExtensions;

                string Gobix_SearchPatter = ConfigurationManager.AppSettings["GOBIX_SearchPatter"].ToString();
                BVRD.Global.Gobix_Parameters.SearchPatter = Gobix_SearchPatter;

                string Gobix_ErrorFiles = ConfigurationManager.AppSettings["GOBIX_ErrorFiles"].ToString();
                BVRD.Global.Gobix_Parameters.ErrorFiles = Gobix_ErrorFiles;

                string Gobix_FilePatch = ConfigurationManager.AppSettings["GOBIX_FilePatch"].ToString();
                BVRD.Global.Gobix_Parameters.FilePatch = Gobix_FilePatch;


                string Gobix_SuccessFiles = ConfigurationManager.AppSettings["GOBIX_SuccessFiles"].ToString();
                BVRD.Global.Gobix_Parameters.SuccessFiles = Gobix_SuccessFiles;

                string Gobix_DownLoadftpServerIP = ConfigurationManager.AppSettings["GOBIX_DownLoadftpServerIP"].ToString();
                BVRD.Global.Gobix_Parameters.DownLoadftpServerIP = Gobix_DownLoadftpServerIP;

                string Gobix_DownLoadftpUserID = ConfigurationManager.AppSettings["GOBIX_DownLoadftpUserID"].ToString();
                BVRD.Global.Gobix_Parameters.DownLoadftpUserID = Gobix_DownLoadftpUserID;

                string Gobix_DownLoadftpPassword = BVRD.Security.Utils.CryptorEngine.Decrypt(
                    ConfigurationManager.AppSettings["GOBIX_DownLoadftpPassword"].ToString().Trim(), true);
                BVRD.Global.Gobix_Parameters.DownLoadftpPassword = Gobix_DownLoadftpPassword;


                string Gobix_DownLoadftpServerIPRdval = ConfigurationManager.AppSettings["GOBIX_DownLoadftpServerIPRdval"].ToString();
                BVRD.Global.Gobix_Parameters.DownLoadftpServerIPRdval = Gobix_DownLoadftpServerIPRdval;

                string Gobix_DownLoadftpUserIDRdval = ConfigurationManager.AppSettings["GOBIX_DownLoadftpUserIDRdval"].ToString();
                BVRD.Global.Gobix_Parameters.DownLoadftpUserIDRdval = Gobix_DownLoadftpUserIDRdval;

                string Gobix_DownLoadftpPasswordRdval = BVRD.Security.Utils.CryptorEngine.Decrypt(
                    ConfigurationManager.AppSettings["GOBIX_DownLoadftpPasswordRdval"].ToString().Trim(), true);


                BVRD.Global.Gobix_Parameters.DownLoadftpPasswordRdval = Gobix_DownLoadftpPasswordRdval;

                string Gobix_UpLoadftpServerIP = ConfigurationManager.AppSettings["GOBIX_UpLoadftpServerIP"].ToString();
                BVRD.Global.Gobix_Parameters.UpLoadftpServerIP = Gobix_UpLoadftpServerIP;

                string Gobix_UpLoadftpUserID = ConfigurationManager.AppSettings["GOBIX_UpLoadftpUserID"].ToString();
                BVRD.Global.Gobix_Parameters.UpLoadftpUserID = Gobix_UpLoadftpUserID;

                string Gobix_UpLoadftpPassword =   BVRD.Security.Utils.CryptorEngine.Decrypt(
                ConfigurationManager.AppSettings["GOBIX_UpLoadftpPassword"].ToString().Trim(), true);

                BVRD.Global.Gobix_Parameters.UpLoadftpPassword = Gobix_UpLoadftpPassword;

                string Gobix_UpLoadftpPatch = ConfigurationManager.AppSettings["GOBIX_UpLoadftpPatch"].ToString();
                BVRD.Global.Gobix_Parameters.UpLoadftpPatch = Gobix_UpLoadftpPatch;

                string Gobix_GobixURL = ConfigurationManager.AppSettings["GOBIX_GobixURL"].ToString();
                BVRD.Global.Gobix_Parameters.GobixURL = Gobix_GobixURL;

                string Gobix_GobixDataPatch = ConfigurationManager.AppSettings["GOBIX_GobixDataPatch"].ToString();
                BVRD.Global.Gobix_Parameters.GobixDataPatch = Gobix_GobixDataPatch;

                string Gobix_GobixUpdateURL = ConfigurationManager.AppSettings["GOBIX_GobixUpdateURL"].ToString();
                BVRD.Global.Gobix_Parameters.GobixUpdateURL = Gobix_GobixUpdateURL;

                //SIV 
                string SIV_ConectionString = BVRD.Security.Utils.CryptorEngine.Decrypt(
                  ConfigurationManager.AppSettings["SIV_ConectionString"].ToString().Trim(), true);

                BVRD.Global.SIV_Parameters.ConectionString = SIV_ConectionString;

                string SIV_DatePatter = ConfigurationManager.AppSettings["SIV_DatePatter"].ToString();   

                BVRD.Global.SIV_Parameters.DatePatter = SIV_DatePatter;

                string SIV_FilesExtensions = ConfigurationManager.AppSettings["SIV_FilesExtensions"].ToString();
                BVRD.Global.SIV_Parameters.FilesExtensions = SIV_FilesExtensions;
                
                string FilesExtensionsBancos = ConfigurationManager.AppSettings["FilesExtensionsBancos"].ToString();
                BVRD.Global.SIV_Parameters.FilesExtensionsBancos = FilesExtensionsBancos;

                string SIV_SearchPatter = ConfigurationManager.AppSettings["SIV_SearchPatter"].ToString();
                BVRD.Global.SIV_Parameters.SearchPatter = SIV_SearchPatter;

                string SIV_SearchPatterBancos = ConfigurationManager.AppSettings["SIV_SearchPatterBancos"].ToString();
                BVRD.Global.SIV_Parameters.SearchPatterBancos = SIV_SearchPatterBancos;

                string SIV_ErrorFiles = ConfigurationManager.AppSettings["SIV_ErrorFiles"].ToString();
                BVRD.Global.SIV_Parameters.ErrorFiles = SIV_ErrorFiles;

                string SIV_FilePatch = ConfigurationManager.AppSettings["SIV_FilePatch"].ToString();
                BVRD.Global.SIV_Parameters.FilePatch = SIV_FilePatch;

                string FilePatchBancos = ConfigurationManager.AppSettings["FilePatchBancos"].ToString();
                BVRD.Global.SIV_Parameters.FilePatchBancos = FilePatchBancos;

                string SIV_SuccessFiles = ConfigurationManager.AppSettings["SIV_SuccessFiles"].ToString();
                BVRD.Global.SIV_Parameters.SuccessFiles = SIV_SuccessFiles;

                string SIV_DownLoadftpServerIP = ConfigurationManager.AppSettings["SIV_DownLoadftpServerIP"].ToString();
                BVRD.Global.SIV_Parameters.DownLoadftpServerIP = SIV_DownLoadftpServerIP;

                string SIV_DownLoadftpUserID = ConfigurationManager.AppSettings["SIV_DownLoadftpUserID"].ToString();
                BVRD.Global.SIV_Parameters.DownLoadftpUserID = SIV_DownLoadftpUserID;

                string SIV_DownLoadftpPassword = BVRD.Security.Utils.CryptorEngine.Decrypt(
                    ConfigurationManager.AppSettings["SIV_DownLoadftpPassword"].ToString().Trim(), true);

                BVRD.Global.SIV_Parameters.DownLoadftpPassword = SIV_DownLoadftpPassword;

                string SIV_UpLoadftpServerIP = ConfigurationManager.AppSettings["SIV_UpLoadftpServerIP"].ToString();
                BVRD.Global.SIV_Parameters.UpLoadftpServerIP = SIV_UpLoadftpServerIP;

                string SIV_UpLoadftpUserID = ConfigurationManager.AppSettings["SIV_UpLoadftpUserID"].ToString();
                BVRD.Global.SIV_Parameters.UpLoadftpUserID = SIV_UpLoadftpUserID;

                string SIV_UpLoadftpPassword = BVRD.Security.Utils.CryptorEngine.Decrypt(
                    ConfigurationManager.AppSettings["SIV_UpLoadftpPassword"].ToString().Trim(), true);

                BVRD.Global.SIV_Parameters.UpLoadftpPassword = SIV_UpLoadftpPassword;

                string SIV_UpLoadftpPatch = ConfigurationManager.AppSettings["SIV_UpLoadftpPatch"].ToString();
                BVRD.Global.SIV_Parameters.UpLoadftpPatch = SIV_UpLoadftpPatch;

                string SIV_SivDataPatch = ConfigurationManager.AppSettings["SIV_SivDataPatch"].ToString();
                BVRD.Global.SIV_Parameters.SIV_SivDataPatch = SIV_SivDataPatch;

                string SIV_OutputFileMask = ConfigurationManager.AppSettings["SIV_OutputFileMask"].ToString();
                BVRD.Global.SIV_Parameters.SIV_OutputFileMask = SIV_OutputFileMask;

                //GENERAL
                string AppDomain = ConfigurationManager.AppSettings["AppDomain"].ToString();
                BVRD.Global.Global_Parameters.AppDomain = AppDomain;

                int AttemptsCounts = Convert.ToInt32(ConfigurationManager.AppSettings["AttemptsCounts"].ToString());
                BVRD.Global.Global_Parameters.AttemptsCounts = AttemptsCounts;

                BVRD.Global.Global_Parameters.CurrentDate = DateTime.Now;
                BVRD.Global.Global_Parameters.Year = Convert.ToInt32(DateTime.Now.Year.ToString());

                return true;
            }
            catch(Exception ex) 
            {
                Msg = ex.Message.ToString();
                return false;
            }
        }

        /// <summary>
        /// Verifica la conexión que toma del app.config
        /// </summary>
        /// <returns></returns>
        private static bool TestParameters()
        {
  

            if (!string.IsNullOrEmpty(BVRD.Global.Gobix_Parameters.ConectionString))
            {
                try
                {
                    string conn = BVRD.Global.Gobix_Parameters.ConectionString;
                    SqlConnection cn = new SqlConnection(conn);

                    using (cn)
                    {
                        cn.Open();
                    }

                    Msg = "Conexión exitosa";
                    return true;
                }
                catch (SqlException sqlEx)
                {
                    Msg = "Error de conexión; " + sqlEx.InnerException.ToString();
                    return false;
                }

            }
            else
            {
                Msg = "Cadena de conexión no valida, Verifique!";
                return false;
            }

            //return true;
 
        }
    }
}

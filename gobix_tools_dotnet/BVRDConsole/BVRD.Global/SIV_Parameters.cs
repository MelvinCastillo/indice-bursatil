using System;
using System.Collections.Generic;
using System.Text;

namespace BVRD.Global
{
    public class SIV_Parameters
    {
        static string vConectionString;
        public static string ConectionString
        {
            get
            {
                return vConectionString;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vConectionString = value;
                }
            }
        }

        static string vDatePatter;
        public static string DatePatter
        {
            get
            {
                return vDatePatter;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vDatePatter = value;
                }
            }
        }

        static string vFilesExtensions;
        public static string FilesExtensions
        {
            get
            {
                return vFilesExtensions;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vFilesExtensions = value;
                }
            }
        }

        static string vFilesExtensionsBancos;
        public static string FilesExtensionsBancos
        {
            get
            {
                return vFilesExtensionsBancos;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vFilesExtensionsBancos = value;
                }
            }
        }


        static string vSearchPatter;
        public static string SearchPatter
        {
            get
            {
                return vSearchPatter;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vSearchPatter = value;
                }
            }
        }

        static string vSearchPatterBancos;
        public static string SearchPatterBancos
        {
            get
            {
                return vSearchPatterBancos;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vSearchPatterBancos = value;
                }
            }
        }

        static string vErrorFiles;
        public static string ErrorFiles
        {
            get
            {
                return vErrorFiles;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vErrorFiles = value;
                }
            }
        }

        static string vFilePatch;
        public static string FilePatch
        {
            get
            {
                return vFilePatch;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vFilePatch = value;
                }
            }
        }

        static string vFilePatchBancos;
        public static string FilePatchBancos
        {
            get
            {
                return vFilePatchBancos;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vFilePatchBancos = value;
                }
            }
        }


        static string vSuccessFiles;
        public static string SuccessFiles
        {
            get
            {
                return vSuccessFiles;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vSuccessFiles = value;
                }
            }
        }

        static string vDownLoadftpServerIP;
        public static string DownLoadftpServerIP
        {
            get
            {
                return vDownLoadftpServerIP;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vDownLoadftpServerIP = value;
                }
            }
        }

        static string vDownLoadftpUserID;
        public static string DownLoadftpUserID
        {
            get
            {
                return vDownLoadftpUserID;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vDownLoadftpUserID = value;
                }
            }
        }

        static string vDownLoadftpPassword;
        public static string DownLoadftpPassword
        {
            get
            {
                return vDownLoadftpPassword;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vDownLoadftpPassword = value;
                }
            }
        }

        static string vUpLoadftpServerIP;
        public static string UpLoadftpServerIP
        {
            get
            {
                return vUpLoadftpServerIP;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vUpLoadftpServerIP = value;
                }
            }
        }

        static string vUpLoadftpUserID;
        public static string UpLoadftpUserID
        {
            get
            {
                return vUpLoadftpUserID;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vUpLoadftpUserID = value;
                }
            }
        }

        static string vUpLoadftpPassword;
        public static string UpLoadftpPassword
        {
            get
            {
                return vUpLoadftpPassword;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vUpLoadftpPassword = value;
                }
            }
        }

        static string vUpLoadftpPatch;
        public static string UpLoadftpPatch
        {
            get
            {
                return vUpLoadftpPatch;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vUpLoadftpPatch = value;
                }
            }
        }

        static string vSIV_SivDataPatch;
        public static string SIV_SivDataPatch
        {
            get
            {
                return vSIV_SivDataPatch;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vSIV_SivDataPatch = value;
                }
            }
        }

        static string vSIV_OutputFileMask;
        public static string SIV_OutputFileMask
        {
            get
            {
                return vSIV_OutputFileMask;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vSIV_OutputFileMask = value;
                }
            }
        }

        public static string GetFileName()
        {
            string tmpFileName = string.Empty;

            tmpFileName = BVRD.Global.SIV_Parameters.SearchPatter;

            string filename = BVRD.Global.SIV_Parameters.FilesExtensions.Replace("*", tmpFileName.ToString());

            return filename;
             
        }

        public static string GetFileNameBancos()
        {
            string tmpFileName = string.Empty;

            tmpFileName = BVRD.Global.SIV_Parameters.SearchPatterBancos;

            string filename = BVRD.Global.SIV_Parameters.FilesExtensionsBancos.Replace("*", tmpFileName.ToString());

            return filename;

        }


    }
}

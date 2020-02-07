using System;
using System.Collections.Generic;
using System.Text;

namespace BVRD.Global
{
    public class Gobix_Parameters
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

        static string vDownLoadftpServerIPRdval;
        public static string DownLoadftpServerIPRdval
        {
            get
            {
                return vDownLoadftpServerIPRdval;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vDownLoadftpServerIPRdval = value;
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

        static string vDownLoadftpUserIDRdval;
        public static string DownLoadftpUserIDRdval
        {
            get
            {
                return vDownLoadftpUserIDRdval;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vDownLoadftpUserIDRdval = value;
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

        static string vDownLoadftpPasswordRdval;
        public static string DownLoadftpPasswordRdval
        {
            get
            {
                return vDownLoadftpPasswordRdval;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vDownLoadftpPasswordRdval = value;
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

        static string vGobixURL;
        public static string GobixURL
        {
            get
            {
                return vGobixURL;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vGobixURL = value;
                }
            }
        }

        static string vGobixDataPatch;
        public static string GobixDataPatch
        {
            get
            {
                return vGobixDataPatch;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vGobixDataPatch = value;
                }
            }
        }

        static string vGobixUpdateURL;
        public static string GobixUpdateURL
        {
            get
            {
                return vGobixUpdateURL;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vGobixUpdateURL = value;
                }
            }
        }

        public static string GetFileName(DateTime dateFile)
        {
            string tmpFileName = string.Empty;

            tmpFileName = BVRD.Global.Gobix_Parameters.SearchPatter
                + dateFile.Year.ToString("D4")
                + dateFile.Month.ToString("D2")
                + dateFile.Day.ToString("D2");

            string filename = BVRD.Global.Gobix_Parameters.FilesExtensions.Replace("*", tmpFileName.ToString());

            return filename;
        }

    }
}

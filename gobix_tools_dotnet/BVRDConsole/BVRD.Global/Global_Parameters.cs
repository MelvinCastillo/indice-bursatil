using System;
using System.Collections.Generic;
using System.Text;

namespace BVRD.Global
{
    public class Global_Parameters
    {
        static string vAppDomain;
        public static string AppDomain
        {
            get
            {
                return vAppDomain;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vAppDomain = value;
                }
            }
        }

        static string vUserName;
        public static string UserName
        {
            get
            {
                return vUserName;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vUserName = value;
                }
            }
        }

        static DateTime vCurrentDate;
        public static DateTime CurrentDate
        {
            get
            {
                return vCurrentDate;
            }
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    vCurrentDate = value;
                }
            }
        }

        static int vYear;
        public static int Year
        {
            get
            {
                return vYear;
            }
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    vYear = value;
                }
            }
        }

        static int vAttemptsCounts;
        public static int AttemptsCounts
        {
            get
            {
                return vAttemptsCounts;
            }
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    vAttemptsCounts = value;
                }
            }
        }
       
        static string[] vMonthNames;
        public static string[] MonthNames
        {
            get { return vMonthNames;  }
            set { vMonthNames = value;  }
        }

    }
}

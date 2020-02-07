using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Gobix.BusinessLayer
{

    public class GobixPipca
    {
        static string vcurrentFile;
        public string currentFile
        {
            get
            {
                return vcurrentFile;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vcurrentFile = value;
                }
            }
        }

        private DataLayer.GobixPipca Gobixpipca = new DataLayer.GobixPipca();

        public void exe_sp_PIPCA_VectorPreciosRD(string s)
        {
            Gobixpipca.exe_sp_PIPCA_VectorPreciosRD(s);
        }

        public string currentISIN
        {
            get
            {
                return Gobixpipca.currentISIN;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Gobixpipca.currentISIN = value;
                }
            }
        }

    }
}

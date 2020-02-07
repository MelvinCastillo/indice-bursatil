using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Gobix.DataLayer
{
    public class BussinessDays
    {
        public bool exe_sp_tbl_BussinesDays_set(int vYear, DateTime vDate, int vStatus)
        {
            try
            {
                string strString = BVRD.Global.Gobix_Parameters.ConectionString;

                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_tbl_BussinesDays_set", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@Year", SqlDbType.Int).Value = vYear;
                        cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = vDate;
                        cmd.Parameters.Add("@status", SqlDbType.Bit).Value = vStatus;

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool exe_sp_holidays_flaq(int vYear)
        {
            try
            {
                string strString = BVRD.Global.Gobix_Parameters.ConectionString;

                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_holidays_flaq", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@Year", SqlDbType.Int).Value = vYear;

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

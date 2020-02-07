using System;
using System.Data;
using System.Data.SqlClient;

namespace Gobix.DataLayer
{

    public class GobixData
    {

        public DataSet exe_SP_GET_Gobix_Data(int index)
        {
            DataSet ds = new DataSet();
            try
            {
                string strString = BVRD.Global.Gobix_Parameters.ConectionString;

                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GET_Gobix_Data", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ID_Master", SqlDbType.Int).Value = index;

                        con.Open();

                        SqlDataAdapter adp = new SqlDataAdapter(cmd);

                        adp.Fill(ds);
                    }
                }
                return ds;
            }
            catch
            {
                return ds;
            }
        }

        public DataSet exe_SP_GET_TBL_INDEX_MASTER()
        {
            DataSet ds = new DataSet();
            try
            {
                string strString = BVRD.Global.Gobix_Parameters.ConectionString;

                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GET_TBL_INDEX_MASTER", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        con.Open();

                        SqlDataAdapter adp = new SqlDataAdapter(cmd);

                        adp.Fill(ds);

                    }
                }
                return ds;
            }
            catch
            {
                return ds;
            }
        }

        public DataSet exe_SP_Validate_Before_Execute(DateTime date)
        {
            DataSet ds = new DataSet();

            try
            {
                string strString = BVRD.Global.Gobix_Parameters.ConectionString;

                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Validate_Before_Execute", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@STRDATE", SqlDbType.VarChar).Value = date.ToString("yyyy-MM-dd");

                        con.Open();

                        SqlDataAdapter adp = new SqlDataAdapter(cmd);

                        adp.Fill(ds);
                    }
                }

                return ds;
            }
            catch
            {
                return ds;
            }
        }

        public DataSet exe_SP_Sel_Index_Result(DateTime date)
        {
            DataSet ds = new DataSet();

            try
            {
                string strString = BVRD.Global.Gobix_Parameters.ConectionString;

                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Sel_Index_Result", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = date.ToString("yyyy-MM-dd");

                        con.Open();

                        SqlDataAdapter adp = new SqlDataAdapter(cmd);

                        adp.Fill(ds);
                    }
                }

                return ds;
            }
            catch
            {
                return ds;
            }
        }

        public DataSet exe_SP_CALC_Index_With_Result(DateTime date, int IdRebalancing)
        {
            DataSet ds = new DataSet();

            try
            {
                string strString = BVRD.Global.Gobix_Parameters.ConectionString;

                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_CALC_Index_With_Result", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = date.ToString("yyyy-MM-dd");
                        cmd.Parameters.Add("@IdRebalancing", SqlDbType.Int).Value = IdRebalancing;

                        con.Open();

                        SqlDataAdapter adp = new SqlDataAdapter(cmd);

                        adp.Fill(ds);
                    }
                }
                return ds;
            }
            catch
            {
                return ds;
            }
        }

        public DataSet exe_SP_Sel_Rebalancing_Master(int? id)
        {
            DataSet ds = new DataSet();
            try
            {
                string strString = BVRD.Global.Gobix_Parameters.ConectionString;

                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Sel_Rebalancing_Master", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        if (id != null)
                        {
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                        }
                        else
                        {
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = DBNull.Value;
                        }

                        con.Open();

                        SqlDataAdapter adp = new SqlDataAdapter(cmd);

                        adp.Fill(ds);
                    }
                }
                return ds;
            }
            catch
            {
                return ds;
            }
        }

        public DataSet exe_SP_Sel_Rebalancing(int? id)
        {
            DataSet ds = new DataSet();
            try
            {
                string strString = BVRD.Global.Gobix_Parameters.ConectionString;

                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Sel_Rebalancing", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        if (id != null)
                        {
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                        }
                        else
                        {
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = DBNull.Value;
                        }

                        con.Open();

                        SqlDataAdapter adp = new SqlDataAdapter(cmd);

                        adp.Fill(ds);
                    }
                }
                return ds;
            }
            catch
            {
                return ds;
            }
        }

        public DataSet exe_SP_Set_Activate_Rebalancing(int IdRebalancing)
        {
            DataSet ds = new DataSet();
            try
            {
                string strString = BVRD.Global.Gobix_Parameters.ConectionString;

                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Set_Activate_Rebalancing", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@IdRebalancing", SqlDbType.Int).Value = IdRebalancing;
                        con.Open();

                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds);
                    }
                }
                return ds;
            }
            catch
            { return ds; }
        }
                
        public bool exe_SP_Create_Rebalancing(DateTime RebalancingDate, double Tipp)
        {            
            try
            {
                string strString = BVRD.Global.Gobix_Parameters.ConectionString;
                using (SqlConnection con = new SqlConnection(strString))
                {                                    
                    using (SqlCommand cmd = new SqlCommand("Gob_Rebalancing_P", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = RebalancingDate;
                        cmd.Parameters.Add("@Tipp", SqlDbType.Float).Value = Tipp;
                        con.Open();                        
                        int result = cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            { return false; }
        }

        public DataSet exe_SP_Sel_Index_View(int ID, DateTime FechaIni, DateTime FechaFin)
        {
            DataSet ds = new DataSet();
            try
            {
                string strString = BVRD.Global.Gobix_Parameters.ConectionString;

                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Sel_Index_View", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                        cmd.Parameters.Add("@FechaIni", SqlDbType.DateTime).Value = FechaIni;
                        cmd.Parameters.Add("@FechaFin", SqlDbType.DateTime).Value = FechaFin;

                        con.Open();

                        SqlDataAdapter adp = new SqlDataAdapter(cmd);

                        adp.Fill(ds);
                    }
                }
                return ds;
            }
            catch
            {
                return ds;
            }
        }

        public DataSet exe_SP_Next_Rebalancing_Master()
        {

            DataSet ds = new DataSet();

            try
            {
                string strString = BVRD.Global.Gobix_Parameters.ConectionString;

                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Next_Rebalancing_Master", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        con.Open();
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds);

                    }
                }
                return ds;
            }
            catch
            {
                return ds;
            }
        }

        public DataSet exe_SP_LastDates_Rebalancing_Master()
        {
            DataSet ds = new DataSet();
            try
            {
                string strString = BVRD.Global.Gobix_Parameters.ConectionString;
                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_LastDates_Rebalancing_Master", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds);
                    }
                }
                return ds;
            }
            catch
            { return ds; }
        }

        public bool exe_SP_Insert_Rebalancing_Master(DateTime CurrentDate, DateTime LastData, DateTime BeforeLastDate, double tippp, bool Status)
        {
            try
            {
                string strString = BVRD.Global.Gobix_Parameters.ConectionString;
                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Insert_Rebalancing_Master", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@CurrentDate", SqlDbType.DateTime).Value = CurrentDate;
                        cmd.Parameters.Add("@LastData", SqlDbType.DateTime).Value = LastData;
                        cmd.Parameters.Add("@BeforeLastDate", SqlDbType.DateTime).Value = BeforeLastDate;
                        cmd.Parameters.Add("@TIPP", SqlDbType.Float).Value = tippp;
                        cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = Status;
                        con.Open();
                        int result = cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool exe_SP_Insert_Datos_Ponderacion_Total(int ID_Master,
                                                        float VALOR_MERCADO_TOTAL,
                                                        float PONDERACION_TOTAL_POR,
                                                        float PONDERACION_TOTAL_DEC)
        {

            try
            {
                string strString = BVRD.Global.Gobix_Parameters.ConectionString;

                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Insert_Datos_Ponderacion_Total", con))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ID_Master", SqlDbType.Int).Value = ID_Master;
                        cmd.Parameters.Add("@VALOR_MERCADO_TOTAL", SqlDbType.Float).Value = VALOR_MERCADO_TOTAL;
                        cmd.Parameters.Add("@PONDERACION_TOTAL_POR", SqlDbType.Float).Value = PONDERACION_TOTAL_POR;
                        cmd.Parameters.Add("@PONDERACION_TOTAL_DEC", SqlDbType.Float).Value = PONDERACION_TOTAL_DEC;


                        con.Open();

                        int result = cmd.ExecuteNonQuery();


                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool exe_SP_Insert_Rebalancing_Details(int ID_Master,
                                                       DateTime Date,
                                                       string ISIN,
                                                       double Tasa,
                                                       DateTime CuponDate,
                                                       bool Status)
        {

            try
            {
                string strString = BVRD.Global.Gobix_Parameters.ConectionString;

                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Insert_Rebalancing_Details", con))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ID_Master", SqlDbType.Int).Value = ID_Master;
                        cmd.Parameters.Add("@DATE", SqlDbType.DateTime).Value = Date;
                        cmd.Parameters.Add("@ISIN", SqlDbType.Char).Value = ISIN;
                        cmd.Parameters.Add("@Tasa", SqlDbType.Float).Value = Tasa;
                        if (CuponDate == Convert.ToDateTime("1970-01-01"))
                        {
                            cmd.Parameters.Add("@CuponDate", SqlDbType.DateTime).Value = DBNull.Value;
                        }
                        else
                        {
                            cmd.Parameters.Add("@CuponDate", SqlDbType.DateTime).Value = CuponDate;
                        }
                        cmd.Parameters.Add("@STATUS", SqlDbType.Bit).Value = Status;


                        con.Open();

                        int result = cmd.ExecuteNonQuery();


                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool exe_SP_Insert_Rebalancing_Excluded(int ID_Master,
                                                       DateTime Date,
                                                       string ISIN
                                                       )
        {

            try
            {
                string strString = BVRD.Global.Gobix_Parameters.ConectionString;

                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Insert_Rebalancing_Excluded", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ID_Master", SqlDbType.Int).Value = ID_Master;
                        cmd.Parameters.Add("@DATE", SqlDbType.DateTime).Value = Date;
                        cmd.Parameters.Add("@ISIN", SqlDbType.Char).Value = ISIN;

                        con.Open();

                        int result = cmd.ExecuteNonQuery();


                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool exe_SP_Insert_DATOS_PONDERACION(int ID_Master,
                                                    DateTime FECHA_DE_LOS_DATOS,
                                                    string ISIN,
                                                    float PRECIO_SUCIO,
                                                    float MONTO_EMITIDO,
                                                    float VALOR_MERCADO,
                                                    float PONDERACION,
                                                    float PONDERACION_POR)
        {

            try
            {
                string strString = BVRD.Global.Gobix_Parameters.ConectionString;

                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Insert_DATOS_PONDERACION", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ID_Master", SqlDbType.Int).Value = ID_Master;
                        cmd.Parameters.Add("@FECHA_DE_LOS_DATOS", SqlDbType.DateTime).Value = FECHA_DE_LOS_DATOS;
                        cmd.Parameters.Add("@ISIN", SqlDbType.Char).Value = ISIN;
                        cmd.Parameters.Add("@PRECIO_SUCIO", SqlDbType.Float).Value = PRECIO_SUCIO;
                        cmd.Parameters.Add("@MONTO_EMITIDO", SqlDbType.Float).Value = MONTO_EMITIDO;
                        cmd.Parameters.Add("@VALOR_MERCADO", SqlDbType.Float).Value = VALOR_MERCADO;
                        cmd.Parameters.Add("@PONDERACION", SqlDbType.Float).Value = PONDERACION;
                        cmd.Parameters.Add("@PONDERACION_POR", SqlDbType.Float).Value = PONDERACION_POR;

                        con.Open();

                        int result = cmd.ExecuteNonQuery();


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

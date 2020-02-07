using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace SIV.DataLayer
{
    public class SIVData
    {
        public int exe_sp_SIVVectoresEncabezado(string vUsuario, string vHostName, string vArchivoCargado)
        {
            DataSet ds = new DataSet();
            int result = 0;
            try
            {
                string strString = BVRD.Global.SIV_Parameters.ConectionString;
                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_SIVVectoresEncabezado", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 100).Value = vUsuario;
                        cmd.Parameters.Add("@HostName", SqlDbType.VarChar, 100).Value = vHostName;
                        cmd.Parameters.Add("@ArchivoCargado", SqlDbType.VarChar, 500).Value = vArchivoCargado;
                        con.Open();

                        result = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch
            { return -1; }
            return result;
        }

      
        public int exe_sp_SIVVectoresDetalle(int vID_Carga, string vRncPuestoDeBolsa,
            string vRncEmisor, string vEmisor, DateTime vFechaEnvio, DateTime vFechaValor, DateTime VFechaEmision,
            DateTime vFechaVecMutuo, string vCodEmision, string vCodigoIsin, string vSerie,
            string vMoneda, string vNumOperacion, string vTipoTransaccion, string vTipoContrato,
            string vTipoMercado, string vTipoNegociacion, double vTasaIntFacial, double vTasaRend,
           /* COMENTARIADO POR MELVIN CASTILLO 05-06-2017 double vUnidadValorNominal, double vValorNominal,*/ double vCantValorNominal,
            double vPrecioNegociado, double vValorNegociado,  string vTipoArchivo )
        {
            DataSet ds = new DataSet();

            int result = 0;
            try
            {
                string strString = BVRD.Global.SIV_Parameters.ConectionString;
                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_SIVVectoresDetalle", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@ID_Carga", SqlDbType.Int).Value = vID_Carga;
                        cmd.Parameters.Add("@RncPuestoDeBolsa", SqlDbType.NChar, 15).Value = vRncPuestoDeBolsa;
                        cmd.Parameters.Add("@RncEmisor", SqlDbType.VarChar, 15).Value = vRncEmisor;
                        cmd.Parameters.Add("@Emisor", SqlDbType.VarChar, 100).Value = vEmisor;
                        cmd.Parameters.Add("@FechaEnvio", SqlDbType.Date).Value = vFechaEnvio;
                        cmd.Parameters.Add("@FechaValor", SqlDbType.Date).Value = vFechaValor;
                        cmd.Parameters.Add("@FechaEmision", SqlDbType.Date).Value = VFechaEmision;
                        cmd.Parameters.Add("@FechaVecMutuo", SqlDbType.Date).Value = vFechaVecMutuo;
                        cmd.Parameters.Add("@CodEmision", SqlDbType.VarChar, 50).Value = vCodEmision;
                        cmd.Parameters.Add("@CodigoIsin", SqlDbType.VarChar, 50).Value = vCodigoIsin;
                        cmd.Parameters.Add("@Serie", SqlDbType.VarChar, 50).Value = vSerie;
                        cmd.Parameters.Add("@Moneda", SqlDbType.VarChar, 10).Value = vMoneda;
                        cmd.Parameters.Add("@NumOperacion", SqlDbType.VarChar, 30).Value = vNumOperacion;
                        cmd.Parameters.Add("@TipoTransaccion", SqlDbType.VarChar, 80).Value = vTipoTransaccion;
                        cmd.Parameters.Add("@TipoContrato", SqlDbType.VarChar, 80).Value = vTipoContrato;
                        cmd.Parameters.Add("@TipoMercado", SqlDbType.VarChar, 80).Value = vTipoMercado;
                        cmd.Parameters.Add("@TipoNegociacion", SqlDbType.VarChar, 80).Value = vTipoNegociacion;
                        cmd.Parameters.Add("@TasaIntFacial", SqlDbType.Decimal).Value = vTasaIntFacial;
                        cmd.Parameters.Add("@TasaRend", SqlDbType.Decimal).Value = vTasaRend;
                        /*  COMENTARIADO POR MELVIN CASTILLO 05-06-2017 */
                        //cmd.Parameters.Add("@UnidadValorNominal", SqlDbType.Decimal).Value = vUnidadValorNominal;
                       // cmd.Parameters.Add("@ValorNominal", SqlDbType.Decimal).Value = vValorNominal;
                        cmd.Parameters.Add("@CantValorNominal", SqlDbType.Decimal).Value = vCantValorNominal;
                        cmd.Parameters.Add("@PrecioNegociado", SqlDbType.Decimal).Value = vPrecioNegociado;
                        cmd.Parameters.Add("@ValorNegociado", SqlDbType.Decimal).Value = vValorNegociado;
                        cmd.Parameters.Add("@TipoArchivo", SqlDbType.VarChar, 80).Value = vTipoArchivo;
                        con.Open();

                        result = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                return -1; }

            return result;
        }

        public int exe_sp_SIVVectoresUpdateEmisor(int vID_Carga)
        {
            DataSet ds = new DataSet();

            int result = 0;
            try
            {
                string strString = BVRD.Global.SIV_Parameters.ConectionString;
                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_SIVVectoresUpdateEmisor", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@ID_Carga", SqlDbType.Int).Value = vID_Carga; 
                        con.Open();

                        result = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                return -1;
            }

            return result;
        }


        public int exe_sp_LogOTCSIV( DateTime vFechaCargaSIV, string varchivo)
        {
            DataSet ds = new DataSet();
            int result = 0;
            try
            {
                string strString = BVRD.Global.SIV_Parameters.ConectionString;
                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GenerarArchivosLOG_OTCSIV", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = vFechaCargaSIV;
                        cmd.Parameters.Add("@archivo", SqlDbType.DateTime).Value = varchivo; 
                        con.Open();

                        result = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                return -1;
            }

            return result;
        }

        
        public DataSet exe_SP_Get_SIVVectoresEncabezado()
        {
            DataSet ds = new DataSet();
            try
            {
                string strString = BVRD.Global.SIV_Parameters.ConectionString;
                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Get_SIVVectoresEncabezado", con))
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


        public DataSet exe_SP_Get_SIVVectoresEncabezadoOTC(DateTime date)
        {
            DataSet ds = new DataSet();
            try
            {
                string strString = BVRD.Global.SIV_Parameters.ConectionString;
                 
                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Get_SIVVectoresEncabezadoOTC", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = date;
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

        public DataSet exe_SP_Get_SIVVectoresEncabezadoBancos()
        {
            DataSet ds = new DataSet();
            try
            {
                string strString = BVRD.Global.SIV_Parameters.ConectionString;
                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Get_SIVVectoresEncabezadoBancos", con))
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


        public DataSet exe_SP_GEN_PIPCA_DATA_OTC_SIV_GRID(string date, int ID_Carga, int OpcionData)
        {
            DataSet ds = new DataSet();
            try
            {
                string strString = BVRD.Global.SIV_Parameters.ConectionString;
                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GEN_PIPCA_DATA_OTC_SIV_GRID", con))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@FechadeOperacionEnviaPorlaSIV", SqlDbType.VarChar, 12).Value = date;
                        cmd.Parameters.Add("@ID_Carga", SqlDbType.Int).Value = ID_Carga;
                        cmd.Parameters.Add("@OpcionData", SqlDbType.Int).Value = OpcionData;
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

        public bool exe_SP_GEN_PIPCA_DATA_OTC_SIV_XML(string date, int ID_Carga, int OpcionData)
        {
            XmlReader rdr;
            try
            {
                string strString = BVRD.Global.SIV_Parameters.ConectionString;
                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GEN_PIPCA_DATA_OTC_SIV_XML", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@FechadeOperacionEnviaPorlaSIV", SqlDbType.VarChar, 12).Value = date;
                        cmd.Parameters.Add("@ID_Carga", SqlDbType.Int).Value = ID_Carga;
                        cmd.Parameters.Add("@OpcionData", SqlDbType.Int).Value = OpcionData;
                        con.Open();

                        rdr = cmd.ExecuteXmlReader();
                        string patch = BVRD.Global.SIV_Parameters.SIV_SivDataPatch;
                        string filename = patch + @"\" + string.Format(BVRD.Global.SIV_Parameters.SIV_OutputFileMask, Convert.ToDateTime(date).ToString("yyyyMMdd"));

                        using (XmlWriter xmlWriter = XmlWriter.Create(filename))
                        { xmlWriter.WriteNode(rdr, false); }

                        return true;
                    }
                }
            }
            catch
            { return false; }
        }

        public DataSet exe_sp_SIVGetCargas(DateTime date)
        {
            DataSet ds = new DataSet();
            try
            {
                string strString = BVRD.Global.SIV_Parameters.ConectionString;
                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_SIVGetCargas", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@FechaEnvio", SqlDbType.DateTime).Value = date;
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
    }
}

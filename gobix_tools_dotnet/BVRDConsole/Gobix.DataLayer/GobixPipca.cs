using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;

namespace Gobix.DataLayer
{
    public class GobixPipca
    {
        static string vcurrentISIN;
        public string currentISIN
        {
            get
            {
                return vcurrentISIN;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vcurrentISIN = value;
                }
            }
        }

        public void exe_sp_PIPCA_VectorPreciosRD(string s)
        {
            try
            {
                CultureInfo provider = CultureInfo.InvariantCulture;

                string[] Fileds;
                Fileds = s.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);

                DateTime VFECHA_DE_LOS_DATOS = DateTime.ParseExact(Fileds[0].ToString(), BVRD.Global.Gobix_Parameters.DatePatter.ToString(), provider);
                string VISIN = Fileds[1].ToString();
                string VIDENTIFICADOR_PIPCA = Fileds[2].ToString();
                string VEMISOR = Fileds[3].ToString();
                DateTime VFECHA_DE_EMISIÓN = Convert.ToDateTime(Fileds[4].ToString() + " " + Fileds[5].ToString());
                DateTime VFECHA_DE_VENCIMIENTO = Convert.ToDateTime(Fileds[6].ToString() + " " + Fileds[7].ToString());
                string VFAMILIA = Fileds[8].ToString();
                string VCURVA_DE_DESCUENTO = Fileds[9].ToString();
                string VMONEDA = Fileds[10].ToString();
                double VPRECIO_LIMPIO = Convert.ToDouble(Fileds[11].ToString());
                double VPRECIO_SUCIO = Convert.ToDouble(Fileds[12].ToString());
                double VYIELD_TO_MATURITY = Convert.ToDouble(Fileds[13].ToString());
                double VCUPON_DEVENGADO = Convert.ToDouble(Fileds[14].ToString());
                double VDIAS_A_VENCIMIENTO = Convert.ToDouble(Fileds[15].ToString());
                double VSOBRETASA = Convert.ToDouble(Fileds[16].ToString());
                string VTIPO_DE_PRECIO = Fileds[17].ToString();
                string VBURSATILIDAD = "-";

                if (Fileds[18] != null)
                {
                    if (Fileds[18] != "\0")
                    {
                        VBURSATILIDAD = Fileds[18].ToString();
                    }
                }

                currentISIN = VISIN;

                string strString = BVRD.Global.Gobix_Parameters.ConectionString;

                using (SqlConnection con = new SqlConnection(strString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_PIPCA_VectorPreciosRD", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@FECHA_DE_LOS_DATOS", SqlDbType.DateTime).Value = VFECHA_DE_LOS_DATOS;
                        cmd.Parameters.Add("@ISIN", SqlDbType.VarChar).Value = VISIN;
                        cmd.Parameters.Add("@IDENTIFICADOR_PIPCA", SqlDbType.VarChar).Value = VIDENTIFICADOR_PIPCA;
                        cmd.Parameters.Add("@EMISOR", SqlDbType.VarChar).Value = VEMISOR;
                        cmd.Parameters.Add("@FECHA_DE_EMISIÓN", SqlDbType.DateTime).Value = VFECHA_DE_EMISIÓN;
                        cmd.Parameters.Add("@FECHA_DE_VENCIMIENTO", SqlDbType.DateTime).Value = VFECHA_DE_VENCIMIENTO;
                        cmd.Parameters.Add("@FAMILIA", SqlDbType.VarChar).Value = VFAMILIA;
                        cmd.Parameters.Add("@CURVA_DE_DESCUENTO", SqlDbType.VarChar).Value = VCURVA_DE_DESCUENTO;
                        cmd.Parameters.Add("@MONEDA", SqlDbType.VarChar).Value = VMONEDA;
                        cmd.Parameters.Add("@PRECIO_LIMPIO", SqlDbType.Decimal).Value = VPRECIO_LIMPIO;
                        cmd.Parameters.Add("@PRECIO_SUCIO", SqlDbType.Decimal).Value = VPRECIO_SUCIO;
                        cmd.Parameters.Add("@YIELD_TO_MATURITY", SqlDbType.Decimal).Value = VYIELD_TO_MATURITY;
                        cmd.Parameters.Add("@CUPON_DEVENGADO", SqlDbType.Decimal).Value = VCUPON_DEVENGADO;
                        cmd.Parameters.Add("@DIAS_A_VENCIMIENTO", SqlDbType.Decimal).Value = VDIAS_A_VENCIMIENTO;
                        cmd.Parameters.Add("@SOBRETASA", SqlDbType.Decimal).Value = VSOBRETASA;
                        cmd.Parameters.Add("@TIPO_DE_PRECIO", SqlDbType.VarChar).Value = VTIPO_DE_PRECIO;
                        cmd.Parameters.Add("@BURSATILIDAD", SqlDbType.VarChar).Value = VBURSATILIDAD;

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}

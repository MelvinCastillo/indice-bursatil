using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml;

namespace SIV.BusinessLayer
{
    public class SIVData
    {
        SIV.DataLayer.SIVData _SIVData = new DataLayer.SIVData();

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

        public int exe_sp_SIVVectoresEncabezado(string vUsuario, string vHostName, string vArchivoCargado)
        {
            return _SIVData.exe_sp_SIVVectoresEncabezado(vUsuario, vHostName, vArchivoCargado);
        }

         
        public int exe_sp_SIVVectoresDetalle(int idCarga, XmlNode node)
        {
            int result = 0;
            try
            {
                string pattern = BVRD.Global.SIV_Parameters.DatePatter;

                string RncPuestoDeBolsa = node.ChildNodes[0].InnerXml.ToString().Trim();
                string RncEmisor = node.ChildNodes[1].InnerXml.ToString().Trim();
                string Emisor = node.ChildNodes[2].InnerXml.ToString().Trim();

                DateTime fechaEnvio;
                DateTime fechaValor;
                DateTime fechaVecMutuo;
                DateTime fechaEmision;

                DateTime.TryParseExact(node.ChildNodes[3].InnerXml.ToString().Trim(), pattern, null, DateTimeStyles.None, out fechaEnvio);
                /* NUEVO AGREGADO POR MELVIN CASTILLO 06-06-2017 */
                // DateTime.TryParseExact(node.ChildNodes[4].InnerXml.ToString().Trim(), pattern, null, DateTimeStyles.None, out fechaValor);
                DateTime.TryParseExact(node.ChildNodes[3].InnerXml.ToString().Trim(), pattern, null, DateTimeStyles.None, out fechaValor);
                /* NUEVO AGREGADO POR MELVIN CASTILLO 05-06-2017 */
                DateTime.TryParseExact(node.ChildNodes[5].InnerXml.ToString().Trim(), pattern, null, DateTimeStyles.None, out fechaEmision);
                DateTime.TryParseExact(node.ChildNodes[6].InnerXml.ToString().Trim(), pattern, null, DateTimeStyles.None, out fechaVecMutuo);

                string codEmision = node.ChildNodes[7].InnerXml.ToString().Trim();
                string codigoIsin = node.ChildNodes[8].InnerXml.ToString().Trim();
                string serie = node.ChildNodes[9].InnerXml.ToString().Trim();
                string moneda = node.ChildNodes[10].InnerXml.ToString().Trim();
                string numOperacion = node.ChildNodes[11].InnerXml.ToString().Trim();
                string tipoTransaccion = node.ChildNodes[12].InnerXml.ToString().Trim();
                string tipoContrato = node.ChildNodes[13].InnerXml.ToString().Trim();
                string tipoMercado = node.ChildNodes[14].InnerXml.ToString().Trim();
                string tipoNegociacion = node.ChildNodes[15].InnerXml.ToString().Trim();

                double tasaIntFacial = Convert.ToDouble(node.ChildNodes[16].InnerXml.ToString().Trim());
                double tasaRend = Convert.ToDouble(node.ChildNodes[17].InnerXml.ToString().Trim());
                /*COMENTARIADO POR MELVIN CASTILLO 05-06-2017*/ 
                //double unidadValorNominal = Convert.ToDouble(node.ChildNodes[17].InnerXml.ToString().Trim());
                //double ValorNominal = Convert.ToDouble(node.ChildNodes[18].InnerXml.ToString().Trim());
                double cantValorNominal = Convert.ToDouble(node.ChildNodes[18].InnerXml.ToString().Trim());
                double precioNegociado = Convert.ToDouble(node.ChildNodes[19].InnerXml.ToString().Trim());
                double valorNegociado = Convert.ToDouble(node.ChildNodes[20].InnerXml.ToString().Trim());
                string TipoArchivo = "OTC";

                result = _SIVData.exe_sp_SIVVectoresDetalle(idCarga,
                    RncPuestoDeBolsa, RncEmisor, Emisor,
                    fechaEnvio, fechaValor, fechaEmision, fechaVecMutuo,
                    codEmision, codigoIsin, serie, moneda, numOperacion, tipoTransaccion, tipoContrato, tipoMercado, tipoNegociacion,
                    tasaIntFacial, tasaRend, /*  COMENTARIADO POR MELVIN CASTILLO 05-06-2017  unidadValorNominal, ValorNominal,*/ cantValorNominal, precioNegociado, valorNegociado, TipoArchivo);
            }
            catch 
            {
                result = -1;
            }
             

            return result; 
        }

        public int exe_sp_SIVVectoresUpdateEmisor(int idCarga)
        {
            int result = 0;
            try
            {
            
                 result = _SIVData.exe_sp_SIVVectoresUpdateEmisor(idCarga);
            }
            catch
            {
                result = -1;
            }


            return result;
        }

        public int exe_sp_SIVVectoresDetalleBancos(int idCarga, DataTable dt)
        { 
            int result = 0;
            try
            {
                string pattern = BVRD.Global.SIV_Parameters.DatePatter;

                string RncPuestoDeBolsa = "";  
                string RncEmisor = dt.Rows[0]["RNC EMISOR"].ToString();   
                string Emisor = ""; 
                DateTime fechaEnvio;
                DateTime fechaValor;
                DateTime fechaVecMutuo;
                DateTime fechaEmision;
                DateTime.TryParseExact(dt.Rows[0]["FECHA ENVIO"].ToString().Trim(), pattern, null, DateTimeStyles.None, out fechaEnvio);
                DateTime.TryParseExact(dt.Rows[0]["FECHA VALOR"].ToString().Trim(), pattern, null, DateTimeStyles.None, out fechaValor);
                DateTime.TryParseExact(dt.Rows[0]["FECHA EMISION"].ToString().Trim(), pattern, null, DateTimeStyles.None, out fechaEmision);
                DateTime.TryParseExact(dt.Rows[0]["FECHA VENCIMIENTO"].ToString().Trim(), pattern, null, DateTimeStyles.None, out fechaVecMutuo);
                
                string codEmision = dt.Rows[0]["CODIGO SIVEM"].ToString().Trim();
                string codigoIsin = dt.Rows[0]["ISIN"].ToString().Trim();
                string serie = dt.Rows[0]["SERIE"].ToString().Trim();
                string moneda = dt.Rows[0]["MONEDA"].ToString().Trim();
                string numOperacion = dt.Rows[0]["NUM. OPERACION"].ToString().Trim();
                string tipoTransaccion = dt.Rows[0]["TIPO TRANSACCION"].ToString().Trim();
                if (tipoTransaccion.Trim() == "V") tipoTransaccion = "Venta";
                if (tipoTransaccion.Trim() == "C") tipoTransaccion = "Compra";

                string tipoContrato = dt.Rows[0]["TIPO CONTRATO"].ToString().Trim();
                if (tipoContrato.Trim() == "SP") tipoContrato = "Spot"; 

                string tipoMercado = dt.Rows[0]["TIPO MERCADO"].ToString().Trim();
                if (tipoMercado.Trim() == "S") tipoMercado = "SEC";

                string tipoNegociacion = dt.Rows[0]["NEGOCIACION"].ToString().Trim();
                if (tipoNegociacion.Trim() == "OTC") tipoNegociacion = "XBUR";

                double tasaIntFacial = Convert.ToDouble(dt.Rows[0]["TASA"].ToString().Trim());
                double tasaRend = Convert.ToDouble(dt.Rows[0]["TASA RENDIMIENTO"].ToString().Trim());
                double cantValorNominal = Convert.ToDouble(dt.Rows[0]["CANTIDAD VALOR NOMINAL"].ToString().Trim());
                double precioNegociado = Convert.ToDouble(dt.Rows[0]["PRECIO NEGOCIADO"].ToString().Trim());
                double valorNegociado = Convert.ToDouble(dt.Rows[0]["VALOR NEGOCIADO"].ToString().Trim());
                string TipoArchivo = dt.Rows[0]["TipoArchivo"].ToString().Trim();

                result = _SIVData.exe_sp_SIVVectoresDetalle(idCarga,
                    RncPuestoDeBolsa, RncEmisor, Emisor,
                    fechaEnvio, fechaValor, fechaEmision, fechaVecMutuo,
                    codEmision, codigoIsin, serie, moneda, numOperacion, tipoTransaccion, tipoContrato, tipoMercado, tipoNegociacion,
                    tasaIntFacial, tasaRend, 
                    cantValorNominal, precioNegociado, valorNegociado, TipoArchivo);
            }
            catch
            {
                result = -1;
            }

            return result;
        }
        public DataSet exe_SP_Get_SIVVectoresEncabezado()
        {
            return _SIVData.exe_SP_Get_SIVVectoresEncabezado();
        }

        public DataSet exe_SP_Get_SIVVectoresEncabezadoOTC(DateTime date)
        {
            return _SIVData.exe_SP_Get_SIVVectoresEncabezadoOTC(date);
        }

        public DataSet exe_SP_Get_SIVVectoresEncabezadoBancos()
        {
            return _SIVData.exe_SP_Get_SIVVectoresEncabezadoBancos();
        }

        public DataSet exe_SP_GEN_PIPCA_DATA_OTC_SIV_GRID(DateTime date, int ID_Carga, int OpcionData)
        {
            return _SIVData.exe_SP_GEN_PIPCA_DATA_OTC_SIV_GRID(date.ToString("yyyy-MM-dd"), ID_Carga, OpcionData);
        }

        public bool exe_SP_GEN_PIPCA_DATA_OTC_SIV_XML(DateTime date, int ID_Carga, int OpcionData)
        {
            return _SIVData.exe_SP_GEN_PIPCA_DATA_OTC_SIV_XML(date.ToString("yyyy-MM-dd"), ID_Carga, OpcionData);
        }

        public DataSet exe_sp_SIVGetCargas(DateTime date)
        {
            return _SIVData.exe_sp_SIVGetCargas(date);
        }

        public int exe_sp_LogOTCSIV(DateTime date,string archivo)
             
        {
            return _SIVData.exe_sp_LogOTCSIV(date, archivo);
        }

    }
}

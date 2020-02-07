using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Xml;
using Microsoft.VisualBasic.FileIO;
using System.Threading;
using System.Data;

namespace BVRDConsole.Front.Files
{
    public partial class FrmSIVProcessFilesBancos : BVRD.Windows.Controls.Base.FrmBaseDialog
    {
        SIV.BusinessLayer.SIVData _SIVData = new SIV.BusinessLayer.SIVData();
        public FrmSIVProcessFilesBancos()
        {
            InitializeComponent();
            this.usFileBrowser._FilePatch = BVRD.Global.SIV_Parameters.FilePatchBancos;
            this.usFileBrowser._FilesExtensions = BVRD.Global.SIV_Parameters.FilesExtensionsBancos;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                base.ShowMsg("");
                btnOK.Enabled = false;
                bool errors = false;
                string FilesPatchBancos = BVRD.Global.SIV_Parameters.FilePatchBancos;
                string SuccessPatch = BVRD.Global.SIV_Parameters.SuccessFiles;
                string FileExtensionBancos = BVRD.Global.SIV_Parameters.FilesExtensionsBancos;
                string SearchPatterBancos = BVRD.Global.SIV_Parameters.SearchPatterBancos;

                DirectoryInfo directory = new DirectoryInfo(@FilesPatchBancos);
                FileInfo[] files = directory.GetFiles(FileExtensionBancos);
                DirectoryInfo[] directories = directory.GetDirectories();

                //for (int i = 0; i < files.Length; i++)
                //{                   
                string FileName = ((FileInfo)files[0]).FullName;
                _SIVData.currentFile = ((FileInfo)files[0]).Name;

                if (_SIVData.currentFile.Contains(SearchPatterBancos))
                {
                    // ClearFile(FileName);
                    // doc.Load(FileName);
                    //int IDCarga = _SIVData.exe_SP_Get_SIVVectoresEncabezadoOTC(dateTimePicker.Value);
                    DataSet dsVectoresEncabezado = _SIVData.exe_SP_Get_SIVVectoresEncabezadoOTC(dateTimePicker.Value);
                    DataTable dtVectoresEncabezado = dsVectoresEncabezado.Tables[0];
                    int IDCarga = 0;
                    string fecha = "";

                    if (dtVectoresEncabezado.Rows.Count > 0)
                    {
                        IDCarga = Convert.ToInt16(dtVectoresEncabezado.Rows[0]["ID_Carga"].ToString());
                        fecha = dtVectoresEncabezado.Rows[0]["Fecha"].ToString();
                    }
                    
                    

                    if (IDCarga == 0)
                    {
                        MessageBox.Show("El archivo de OTC Transacciones_BVRD.xml aun no ha sido cargado, verifique");
                        return;
                    }

                    //Create a DataTable dt.  
                    DataTable dt = new DataTable();

                    dt.Columns.AddRange(new DataColumn[22] { new DataColumn("RNC EMISOR", typeof(string)),
                                        new DataColumn("CODIGO SIVEM", typeof(string)),
                                        new DataColumn("ISIN", typeof(string)),
                                        new DataColumn("SERIE", typeof(string)),
                                        new DataColumn("FECHA EMISION",typeof(string)),
                                        new DataColumn("FECHA VENCIMIENTO",typeof(string)),
                                        new DataColumn("MONEDA",typeof(string)),
                                        new DataColumn("TIPO TRANSACCION",typeof(string)),
                                        new DataColumn("TIPO CONTRATO",typeof(string)),
                                        new DataColumn("NEGOCIACION",typeof(string)),
                                        new DataColumn("TIPO MERCADO",typeof(string)),
                                        new DataColumn("TASA",typeof(string)),
                                        new DataColumn("TASA RENDIMIENTO",typeof(string)),
                                        new DataColumn("FECHA VALOR",typeof(string)),
                                        new DataColumn("CANTIDAD TITULOS",typeof(string)),
                                        new DataColumn("CANTIDAD VALOR NOMINAL",typeof(string)),
                                        new DataColumn("VALOR NOMINAL",typeof(string)),
                                        new DataColumn("PRECIO NEGOCIADO",typeof(string)),
                                        new DataColumn("VALOR NEGOCIADO",typeof(string)),
                                        new DataColumn("FECHA ENVIO",typeof(string)) ,
                                        new DataColumn("NUM. OPERACION",typeof(int)),
                                        new DataColumn("TIPOARCHIVO",typeof(string))});
                    dt.Columns["NUM. OPERACION"].AutoIncrement = true;
                    dt.Columns["NUM. OPERACION"].AutoIncrementSeed = 0;
                    dt.Columns["NUM. OPERACION"].AutoIncrementStep = 1;
                    dt.Columns["TIPOARCHIVO"].DefaultValue = "BANCOS";

                    DataTable dt1 = dt;

                    //Read the contents of CSV file.  
                    string csvData = File.ReadAllText(FileName);


                    //LEO LA PRIMERA LINEA DEL ARCHIVO PARA COMPRAR CON LA FECHA DEL 
                    // HEADER DE LA CABECERA DEL ARCHIVO DE OTC
                    foreach (string row in csvData.Split('\n'))
                    {
                        for (int y = 0; y < 2; y++)
                        {
                            if (!string.IsNullOrEmpty(row))
                            {
                                dt.Rows.Add();
                                int i = 0;

                                //Execute a loop over the columns.  
                                foreach (string cell in row.Split(','))
                                {
                                    dt.Rows[dt.Rows.Count - 1][i] = cell;
                                    i++;
                                }
                                if (y == 1)
                                    if (dt.Rows[0]["FECHA ENVIO"].ToString().Substring(0, 11) != "FECHA ENVIO")
                                    {
                                        if (dt.Rows[0]["FECHA ENVIO"].ToString().Substring(0, 10) != fecha.ToString())
                                        {
                                            MessageBox.Show("El archivo de BANCO OTC del dia (" + dt.Rows[0]["FECHA ENVIO"].ToString().Substring(0, 10) + ") que esta tratando de cargar no se corresponde con la fecha indicada");
                                            return;
                                        }
                                    }
                                dt.Rows.Clear();
                            }
                        }
                    }

                    //LEO EL ARCHIVO PARA SUBIRLO AL DETALLE
                    dt.Rows.Clear();
                    foreach (string row in csvData.Split('\n'))
                    {
                        if (!string.IsNullOrEmpty(row))
                        {
                            dt.Rows.Add();
                            int i = 0;

                            //Execute a loop over the columns.  
                            foreach (string cell in row.Split(','))
                            {
                                dt.Rows[dt.Rows.Count - 1][i] = cell;
                                i++;
                            }
                            // dt.Columns["NUM. OPERACION"].DefaultValue = i;
                            //if (i==1)
                            // MessageBox.Show(dt.Rows[0]["RNC EMISOR"].ToString());
                            if (dt.Rows[0]["RNC EMISOR"].ToString() == "RNC EMISOR")
                            {
                                dt.Rows[0].Delete();
                            }
                            _SIVData.exe_sp_SIVVectoresDetalleBancos(IDCarga, dt);
                            //MessageBox.Show(dt.Rows[i]["ISIN"].ToString());
                        }
                        dt.Rows.Clear();
                        // MessageBox.Show(dt.Rows[0]["RNC EMISOR"].ToString());
                    }

                    //LEO EL ARCHIVO PARA MOSTRARLO EN EL GRID
                    foreach (string row in csvData.Split('\n'))
                    {
                        if (!string.IsNullOrEmpty(row))
                        {
                            dt1.Rows.Add();
                            int i = 0;

                            //Execute a loop over the columns.  
                            foreach (string cell in row.Split(','))
                            {
                                dt1.Rows[dt1.Rows.Count - 1][i] = cell;
                                i++;
                            }
                            // dt.Columns["NUM. OPERACION"].DefaultValue = i;
                            //if (i==1)
                            // MessageBox.Show(dt.Rows[0]["RNC EMISOR"].ToString());
                            if (dt1.Rows[0]["RNC EMISOR"].ToString() == "RNC EMISOR")
                            {
                                dt1.Rows[0].Delete();
                            }

                        }

                        // MessageBox.Show(dt.Rows[0]["RNC EMISOR"].ToString());
                    }

                    //Le pongo el nombre a la columna emisor en el tabla de detalle 
                    _SIVData.exe_sp_SIVVectoresUpdateEmisor(IDCarga);

                    dataGridView1.DataSource = dt1;
                }

                string dayDirectory = SuccessPatch + @"\" + DateTime.Now.ToString("yyyyMMdd");
                //if (Directory.Exists(dayDirectory))
                //    Directory.Delete(dayDirectory, true);

                Directory.CreateDirectory(dayDirectory);

                string SuccessfilePatch = dayDirectory + @"\" + ((FileInfo)files[0]).Name;
                //if (File.Exists(SuccessfilePatch))
                //    File.Delete(SuccessfilePatch);

                File.Move(FileName, SuccessfilePatch);
                base.ShowMsg("Archivos procesados correctamente.");
            }

            catch (Exception ex)
            {
                base.ShowMsg(ex.Message);
                return;
            }
            finally
            {
                _SIVData.currentFile = string.Empty;
                btnOK.Enabled = true;
                usFileBrowser._Refresh();
            }
        }

        private void ClearFile(string file)
        {
            string tmpFile = string.Empty;
            FileInfo fi = new FileInfo(file);
            tmpFile = Path.GetTempPath() + @"\" + fi.Name.ToString();

            if (File.Exists(tmpFile))
            {
                File.Delete(tmpFile);
            }

            File.Move(file, tmpFile);
            StreamWriter sw = new StreamWriter(file);
            string path = tmpFile;
            string line = File.ReadAllText(path, Encoding.GetEncoding("ISO-8859-1"));
            string asAscii = string.Empty;

            asAscii = line.Replace("Ñ", "N");
            asAscii = line.Replace("Á", "A");
            asAscii = line.Replace("É", "E");
            asAscii = line.Replace("Í", "I");
            asAscii = line.Replace("Ó", "O");
            asAscii = line.Replace("Ú", "U");
            sw.WriteLine(asAscii);
            sw.Flush();
            sw.Dispose();

            if (File.Exists(tmpFile))
            {
                File.Delete(tmpFile);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}

using BVRD.Windows.Controls.Base;
using System;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using System.Data;
//using System.Data.SqlClient;

namespace BVRDConsole.Front.GOBIX.Rebalancing
{
    public partial class FrmRebalancing_Ponderation : FrmBaseDialog
    {
        private Gobix.BusinessLayer.GobixData _GobixData = new Gobix.BusinessLayer.GobixData();
        private int nArchivoExcelSeleccionar = 1;


        // Rebalanceo
        DataTable dtRB = new DataTable();
        DataSet dsRB = new DataSet("tabla");

        // Excluidos
        DataTable dtEX = new DataTable();
        DataSet dsEX = new DataSet("tabla");

        // Ponderaciones

        DataTable dtPO = new DataTable();
        DataSet dsPO = new DataSet("tabla");

        public FrmRebalancing_Ponderation()
        {
            InitializeComponent();
        }

        string selectedFile = "";

        #region Validaciones        
        private void txtTIPPP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtValorMercado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                   (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


        }

        private void txtPonderacionTotalPOR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                   (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPonderacionTotalDEC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private bool ValidarCamposyDatosDeLaPantalla()
        {
            bool lValorRetorna = true;

            if (string.IsNullOrEmpty(txtTIPPP.Text) || txtTIPPP.Text.Trim() == "0")
            {
                MessageBox.Show("Debe ingresar un valor para TIPP");
                txtTIPPP.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtValorMercado.Text) || txtValorMercado.Text.Trim() == "0")
            {
                MessageBox.Show("Debe ingresar un valor para Valor Total Mercado ");
                txtValorMercado.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtPonderacionTotalDEC.Text) || txtPonderacionTotalDEC.Text.Trim() == "0")
            {
                MessageBox.Show("Debe ingresar un valor para Ponderación Total (POR)");
                txtPonderacionTotalDEC.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtPonderacionTotalPOR.Text) || txtPonderacionTotalPOR.Text.Trim() == "0")
            {
                MessageBox.Show("Debe ingresar un valor para Ponderación Total (DEC)");
                txtPonderacionTotalPOR.Focus();
                return false;
            }

            if (!txtArchivoExcel.Text.Contains("rebalancing_file.xlsx"))
            {
                MessageBox.Show("Debe seleccionar el archivo de rebalance correcto rebalancing_file.xlsx");
                txtArchivoExcel.Focus();
                return false;
            }

            if (!txtArchivoExcelPonderaciones.Text.Contains("ponderation_file.xlsx"))
            {
                MessageBox.Show("Debe seleccionar el archivo de ponderaciones correcto ponderation_file.xlsx");
                txtArchivoExcelPonderaciones.Focus();
                return false;
            }

            if (dtRB.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos de Rebalanceo para cargar");
                return false;

            }

            if (dtPO.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos de Ponderaciones para cargar");
                return false;

            }

            return lValorRetorna;

        }


        #endregion

        #region Operaciones con Excel

        private void btnLoadExcelRebalanceo_Click(object sender, EventArgs e)
        {
            nArchivoExcelSeleccionar = 1;
            SeleccionarArchivoExcel();

        }

        private void btnLoadExcelPonderaciones_Click(object sender, EventArgs e)
        {
            nArchivoExcelSeleccionar = 2;
            SeleccionarArchivoExcel();
        }

        private void SeleccionarArchivoExcel()
        {
            OpenFileDialog openKeywordsFileDialog = new OpenFileDialog();
            //  openKeywordsFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openKeywordsFileDialog.Multiselect = false;
            openKeywordsFileDialog.ValidateNames = true;
            openKeywordsFileDialog.DereferenceLinks = false; // Will return .lnk in shortcuts.
            openKeywordsFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openKeywordsFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(OpenKeywordsFileDialog_FileOk);
            var dialogResult = openKeywordsFileDialog.ShowDialog();

        }

        void OpenKeywordsFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            OpenFileDialog fileDialog = sender as OpenFileDialog;
            selectedFile = fileDialog.FileName;
            if (string.IsNullOrEmpty(selectedFile) || selectedFile.Contains(".lnk"))
            {
                MessageBox.Show("Por Favor seleccione un archivo válido");
                e.Cancel = true;
            }
            else
            {
                if (nArchivoExcelSeleccionar == 1) { txtArchivoExcel.Text = selectedFile.Trim(); }
                if (nArchivoExcelSeleccionar == 2) { txtArchivoExcelPonderaciones.Text = selectedFile.Trim(); }

            }
            return;
        }


        // Procesar Archivo Excel 

        /// <summary>
        /// Leer datos de un archivo de Excel
        /// </summary>
        /// <param name="fileName">Nombre del Archivo y Ruta</param>
        /// <param name="startRow">Fila donde iniciar a leer</param>
        /// <param name="nWs">Hoja a trabajar</param>
        /// <param name="nColumns">Cantidad de columnas a procesar</param>
        /// <returns></returns>
        public static DataTable LeerDataExcelSistema(string fileName, int startRow, int nWs, int nColumns)
        {
            // Crear una Tabla
            DataTable tbl = new DataTable();

            try
            {

                string filePath = fileName;

                var existingFile = new FileInfo(filePath);
                // Abrir y leer el archivo.
                using (var package = new ExcelPackage(existingFile))
                {
                    // Buscar los libros dentro de la hoja
                    ExcelWorkbook workBook = package.Workbook;
                    if (workBook != null)
                    {
                        if (workBook.Worksheets.Count > 0)
                        {
                            // Seleccionar la primera Hoja
                            ExcelWorksheet currentWorksheet = workBook.Worksheets[nWs];

                            // Leer cabecera

                            bool hasHeader = true;
                            foreach (var firstRowCell in currentWorksheet.Cells[1, 1, 1, currentWorksheet.Dimension.End.Column])
                            {
                                tbl.Columns.Add(hasHeader ? firstRowCell.Text : string.Format("Column {0}", firstRowCell.Start.Column));
                            }

                            var nstartRow = hasHeader ? 2 : 1;


                            for (int rowNumber = nstartRow; rowNumber <= currentWorksheet.Dimension.End.Row; rowNumber++)
                            {

                                var wsRow = currentWorksheet.Cells[rowNumber, 1, rowNumber, currentWorksheet.Dimension.End.Column];
                                var row = tbl.NewRow();

                                for (int i = 0; i < nColumns; i++)
                                {

                                    row[i] = Convert.ToString(currentWorksheet.Cells[rowNumber, i + 1].Text).Replace(" 00:00:00", "");

                                }
                                tbl.Rows.Add(row);


                            }

                        }
                    }
                }


            }
            catch (IOException ioEx)
            {
                if (!String.IsNullOrEmpty(ioEx.Message))
                {
                    if (ioEx.Message.Contains("porque está siendo utilizado por otro proceso."))
                    {
                        Console.WriteLine("No se pudo leer los datos. Por favor, asegúrese de que no está abierto en Excel.");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return tbl;
        }

        // Cargar datos de Rebalanceo
        private void btnCargardatos_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtArchivoExcel.Text))
            {
                // Rebalanceo
                dtRB = LeerDataExcelSistema(txtArchivoExcel.Text.Trim(), 2, 1, 5);

                dsRB.Tables.Add(dtRB);

                udvRebalancing._Dataset = dsRB;
                udvRebalancing._TableIndex = 0;

                // Excluidos

                dtEX = LeerDataExcelSistema(txtArchivoExcel.Text.Trim(), 2, 2, 2);

                dsEX.Tables.Add(dtEX);

                udvRebalancingExcluded._Dataset = dsEX;
                udvRebalancingExcluded._TableIndex = 0;
            }
            else
            {

                MessageBox.Show("Debe seleccionar el archivo Excel con datos de Rebalanceo");
            }
        }

        // Cargar datos de Ponderaciones

        private void btnCargardatosPonderaciones_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtArchivoExcelPonderaciones.Text))
            {
                // Ponderaciones


                dtPO = LeerDataExcelSistema(txtArchivoExcelPonderaciones.Text.Trim(), 2, 1, 7);

                dsPO.Tables.Add(dtPO);

                udvWeights._Dataset = dsPO;
                udvWeights._TableIndex = 0;

            }
            else
            {

                MessageBox.Show("Debe seleccionar el archivo Excel con datos de Ponderaciones");
            }

        }


        #endregion

        #region Botones Barra de Formulario

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposyDatosDeLaPantalla()) { return; }

            DialogResult result = MessageBox.Show("Desea guardar la información de la pantalla?", "Confirmación", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                // 1.0 Buscar el ID Header Siguiente...
                DataSet dsRM = _GobixData.exe_exe_SP_Next_Rebalancing_Master();
                int ID_Master = int.Parse(dsRM.Tables[0].Rows[0][0].ToString());

                // 1.1 Buscar Fechas Para Encabezado
                DataSet dsFE = _GobixData.exe_SP_LastDates_Rebalancing_Master();
                DateTime dCurrentDate = DateTime.Parse(dsFE.Tables[0].Rows[0][1].ToString());
                DateTime dLastData = DateTime.Parse(dsFE.Tables[0].Rows[0][2].ToString());

                // 2.0 Crear Cabecera
                try
                {
                    _GobixData.exe_SP_Insert_Rebalancing_Master(txtCurrentDate.Value,
                                                                                dCurrentDate,
                                                                                dLastData,
                                                                               Convert.ToDouble(txtTIPPP.Text),
                                                                                true);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }

                // 3.0 Insertar detalles (Tbl_Rebalancing_Details)
                DateTime CuponDate;
                foreach (DataRow dr in dtRB.Rows)
                {
                    // Valores Nulos en la Fecha cupon
                    if (dr[3].ToString() == "NULL")
                    { CuponDate = Convert.ToDateTime("1970-01-01"); }
                    else
                    { CuponDate = Convert.ToDateTime(dr[3].ToString()); }

                    _GobixData.exe_SP_Insert_Rebalancing_Details(ID_Master,
                                             Convert.ToDateTime(dr[0].ToString()),
                                             dr[1].ToString(),
                                             Convert.ToDouble(dr[2].ToString()),
                                             CuponDate,
                                             true);
                }

                // 4.0 Insertar detalles Excluir (Tbl_Rebalancing_Excluded)
                foreach (DataRow drx in dtEX.Rows)
                {
                    _GobixData.exe_SP_Insert_Rebalancing_Excluded(ID_Master,
                                                             Convert.ToDateTime(drx[0].ToString()),
                                                             drx[1].ToString()
                                                             );
                }

                // 5.0 Insertar datos Ponderaciones 
                // 5.1 Cabecera
                try
                {
                    if (string.IsNullOrEmpty(txtValorMercado.Text)) { txtValorMercado.Text = "0"; }
                    if (string.IsNullOrEmpty(txtPonderacionTotalPOR.Text)) { txtPonderacionTotalPOR.Text = "0"; }
                    if (string.IsNullOrEmpty(txtPonderacionTotalDEC.Text)) { txtPonderacionTotalDEC.Text = "0"; }
                    _GobixData.exe_SP_Insert_Datos_Ponderacion_Total(ID_Master,
                                                                  float.Parse(txtValorMercado.Text),
                                                                  float.Parse(txtPonderacionTotalPOR.Text),
                                                                  float.Parse(txtPonderacionTotalDEC.Text));
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }

                // 5.2 Detalles
                foreach (DataRow drp in dtPO.Rows)
                {
                    _GobixData.exe_SP_Insert_DATOS_PONDERACION(
                                                                 ID_Master,
                                                                 Convert.ToDateTime(drp[0].ToString()),
                                                                 drp[1].ToString(),
                                                                 float.Parse(drp[2].ToString().Replace(",", "")),
                                                                 float.Parse(drp[3].ToString().Replace(",", "")),
                                                                 float.Parse(drp[4].ToString().Replace(",", "")),
                                                                 float.Parse(drp[5].ToString().Replace(",", "")),
                                                                 float.Parse(drp[6].ToString().Replace(",", ""))
                                                             );
                }

                MessageBox.Show("Información se ha guardado correctamente...");
                txtTIPPP.Clear();
                txtValorMercado.Clear();
                txtPonderacionTotalDEC.Clear();
                txtPonderacionTotalPOR.Clear();
                txtArchivoExcel.Clear();
                txtArchivoExcelPonderaciones.Clear();
                udvRebalancing._Clear();
                udvRebalancingExcluded._Clear();
                udvWeights._Clear();
            }
            else if (result == DialogResult.No)
            { }
        }

        #endregion

    }
}
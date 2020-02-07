using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace BVRD.Windows.Controls.Controls
{
    public partial class usDataView : UserControl
    {
        BindingSource bindingSource = new BindingSource();
        DataSet ds = new DataSet();

        public usDataView()
        {
            InitializeComponent();
        }

        private int TableIndex;

        public int _RecordCount { get; set; }

        public int _TableIndex
        {
            get
            {
                return TableIndex;
            }
            set
            {
                if (value != null)
                {
                    TableIndex = value;
                }
            }
        }
        
        public DataSet _Dataset
        {
            get
            {
                return ds;
            }
            set
            {
                if (value != null)
                {                    
                    ds = value;

                    bindingSource.DataSource = ds.Tables[_TableIndex];

                    this.gvData.DataSource = bindingSource;

                    this.bNavigator.BindingSource = bindingSource;

                    this.gvData.AllowUserToAddRows = false;
                    this.gvData.AllowUserToDeleteRows = false;
                    this.gvData.ReadOnly = true;

                    _RecordCount = bindingSource.List.Count;

                    if (bindingSource.List.Count > 0)
                    {
                        tsbExportCSV.Enabled = true;
                        tsbClipBoard.Enabled = true;
                    }
                    else
                    {
                        tsbExportCSV.Enabled = false;
                        tsbClipBoard.Enabled = false;
                    }
                }
            }
        }

        private void tsbExportCSV_Click(object sender, EventArgs e)
        {           
            if (ds != null)
            {
                gvData.ClearSelection();
                exporta_a_excel(gvData);
            }
        }

        private void tsbClipBoard_Click(object sender, EventArgs e)
        {
            if (ds != null)
            {
                gvData.ClearSelection();
                gvData.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

                gvData.SelectAll();
                DataObject dataObj = gvData.GetClipboardContent();
                Clipboard.SetDataObject(dataObj, true);
            }
        }

        public void exporta_a_excel(DataGridView dgv)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);            
            int ColumnIndex = 0;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                ColumnIndex++;
                excel.Cells[1, ColumnIndex] = col.Name;
            }

            int rowIndex = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                rowIndex++;
                ColumnIndex = 0;

                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    ColumnIndex++;
                    excel.Cells[rowIndex + 1, ColumnIndex] = row.Cells[col.Name].Value;
                }
            }

            excel.Visible = true;
            Worksheet worksheet = (Worksheet)excel.ActiveSheet;
            worksheet.Activate();
        }

        public void _Clear()
        {
            try
            {
                gvData.ClearSelection();                
                gvData.Columns.Clear();

                gvData.DataSource = null;

                ds = new DataSet();
                bindingSource = new BindingSource();

                this.bNavigator.BindingSource = null;

                _RecordCount = 0;

                tsbExportCSV.Enabled = false;
                tsbClipBoard.Enabled = false;
            }
            catch { }
        }
   }
}

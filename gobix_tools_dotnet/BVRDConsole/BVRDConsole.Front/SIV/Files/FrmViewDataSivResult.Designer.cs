namespace BVRDConsole.Front.Files
{
    partial class FrmViewDataSivResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pHeader = new System.Windows.Forms.Panel();
            this.pFilter = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lDate = new System.Windows.Forms.Label();
            this.lCarga = new System.Windows.Forms.Label();
            this.lFilter = new System.Windows.Forms.Label();
            this.cmbCargas = new System.Windows.Forms.ComboBox();
            this.cmbFiltros = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.pDiv = new System.Windows.Forms.Panel();
            this.pHeader.SuspendLayout();
            this.pFilter.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // usDataView
            // 
            this.usDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usDataView.Location = new System.Drawing.Point(0, 120);
            this.usDataView.Padding = new System.Windows.Forms.Padding(3);
            this.usDataView.Size = new System.Drawing.Size(1271, 414);
            this.usDataView.Load += new System.EventHandler(this.usDataView_Load);
            // 
            // pHeader
            // 
            this.pHeader.Controls.Add(this.pFilter);
            this.pHeader.Controls.Add(this.btnSendFile);
            this.pHeader.Controls.Add(this.pDiv);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 28);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1271, 92);
            this.pHeader.TabIndex = 3;
            // 
            // pFilter
            // 
            this.pFilter.Controls.Add(this.tableLayoutPanel);
            this.pFilter.Controls.Add(this.btnSearch);
            this.pFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.pFilter.Location = new System.Drawing.Point(0, 0);
            this.pFilter.Name = "pFilter";
            this.pFilter.Padding = new System.Windows.Forms.Padding(3);
            this.pFilter.Size = new System.Drawing.Size(379, 92);
            this.pFilter.TabIndex = 4;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.97102F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.02898F));
            this.tableLayoutPanel.Controls.Add(this.dateTimePicker, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lDate, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lCarga, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lFilter, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.cmbCargas, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.cmbFiltros, 1, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(330, 86);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(113, 5);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(212, 20);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDate.Location = new System.Drawing.Point(5, 2);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(100, 26);
            this.lDate.TabIndex = 1;
            this.lDate.Text = "Fecha:";
            this.lDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lCarga
            // 
            this.lCarga.AutoSize = true;
            this.lCarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lCarga.Location = new System.Drawing.Point(5, 30);
            this.lCarga.Name = "lCarga";
            this.lCarga.Size = new System.Drawing.Size(100, 26);
            this.lCarga.TabIndex = 2;
            this.lCarga.Text = "Carga:";
            this.lCarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lFilter
            // 
            this.lFilter.AutoSize = true;
            this.lFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lFilter.Location = new System.Drawing.Point(5, 58);
            this.lFilter.Name = "lFilter";
            this.lFilter.Size = new System.Drawing.Size(100, 26);
            this.lFilter.TabIndex = 3;
            this.lFilter.Text = "Aplicar Filtros:";
            this.lFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCargas
            // 
            this.cmbCargas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCargas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargas.FormattingEnabled = true;
            this.cmbCargas.Location = new System.Drawing.Point(113, 33);
            this.cmbCargas.Name = "cmbCargas";
            this.cmbCargas.Size = new System.Drawing.Size(212, 21);
            this.cmbCargas.TabIndex = 5;
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltros.FormattingEnabled = true;
            this.cmbFiltros.Items.AddRange(new object[] {
            "Ver Operaciones Con Filtros BVRD.",
            "Ver Operaciones Excluidas.",
            "Ver Operaciones OTC.",
            "Ver Operaciones Con Filtros PIPCA 1%",
            "Ver Operaciones Con Filtros PIPCA 2%",
            "Ver Operaciones Con Filtros PIPCA 3%",
            "Ver Operaciones Con Filtros PIPCA TODAS",
            "Ver Operaciones Títulos Guber y Corporativos"});
            this.cmbFiltros.Location = new System.Drawing.Point(113, 61);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.Size = new System.Drawing.Size(212, 21);
            this.cmbFiltros.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Enabled = false;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Image = global::BVRDConsole.Front.Properties.Resources.Market_Analysis_icon_24;
            this.btnSearch.Location = new System.Drawing.Point(333, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(3);
            this.btnSearch.Size = new System.Drawing.Size(43, 86);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Enabled = false;
            this.btnSendFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendFile.Image = global::BVRDConsole.Front.Properties.Resources.Upload_Information_icon;
            this.btnSendFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendFile.Location = new System.Drawing.Point(395, 22);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(114, 37);
            this.btnSendFile.TabIndex = 3;
            this.btnSendFile.Text = "Cargar Archivo";
            this.btnSendFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // pDiv
            // 
            this.pDiv.BackColor = System.Drawing.Color.Black;
            this.pDiv.Location = new System.Drawing.Point(385, 0);
            this.pDiv.Name = "pDiv";
            this.pDiv.Size = new System.Drawing.Size(4, 95);
            this.pDiv.TabIndex = 2;
            // 
            // FrmViewDataSivResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 549);
            this.Controls.Add(this.pHeader);
            this.Name = "FrmViewDataSivResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ver Datos SIV Resultados.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.pHeader, 0);
            this.Controls.SetChildIndex(this.usDataView, 0);
            this.pHeader.ResumeLayout(false);
            this.pFilter.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Panel pDiv;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Panel pFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lCarga;
        private System.Windows.Forms.Label lFilter;
        private System.Windows.Forms.ComboBox cmbCargas;
        private System.Windows.Forms.ComboBox cmbFiltros;
    }
}
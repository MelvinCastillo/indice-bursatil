namespace BVRDConsole.Front.Index
{
    partial class FrmViewIndex
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
            this.btnValidate = new Qios.DevSuite.Components.QButton();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dtpDateini = new System.Windows.Forms.DateTimePicker();
            this.lIndex = new System.Windows.Forms.Label();
            this.lEndDate = new System.Windows.Forms.Label();
            this.dtpDatefin = new System.Windows.Forms.DateTimePicker();
            this.lStartDate = new System.Windows.Forms.Label();
            this.cmbIndexList = new System.Windows.Forms.ComboBox();
            this.pHeader.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // usDataView
            // 
            this.usDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usDataView.Location = new System.Drawing.Point(0, 114);
            this.usDataView.Padding = new System.Windows.Forms.Padding(5);
            this.usDataView.Size = new System.Drawing.Size(594, 305);
            // 
            // pHeader
            // 
            this.pHeader.Controls.Add(this.btnValidate);
            this.pHeader.Controls.Add(this.tableLayoutPanel);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 28);
            this.pHeader.Name = "pHeader";
            this.pHeader.Padding = new System.Windows.Forms.Padding(2);
            this.pHeader.Size = new System.Drawing.Size(594, 86);
            this.pHeader.TabIndex = 3;
            // 
            // btnValidate
            // 
            this.btnValidate.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnValidate.Image = global::BVRDConsole.Front.Properties.Resources.Market_Analysis_icon_24;
            this.btnValidate.Location = new System.Drawing.Point(452, 59);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(24, 24);
            this.btnValidate.TabIndex = 12;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.1267F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.87331F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.dtpDateini, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lIndex, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lEndDate, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.dtpDatefin, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lStartDate, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.cmbIndexList, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(444, 82);
            this.tableLayoutPanel.TabIndex = 6;
            // 
            // dtpDateini
            // 
            this.dtpDateini.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDateini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateini.Location = new System.Drawing.Point(147, 31);
            this.dtpDateini.Name = "dtpDateini";
            this.dtpDateini.Size = new System.Drawing.Size(292, 20);
            this.dtpDateini.TabIndex = 4;
            // 
            // lIndex
            // 
            this.lIndex.AutoSize = true;
            this.lIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lIndex.Location = new System.Drawing.Point(5, 2);
            this.lIndex.Name = "lIndex";
            this.lIndex.Size = new System.Drawing.Size(134, 24);
            this.lIndex.TabIndex = 1;
            this.lIndex.Text = "Indice:";
            this.lIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lEndDate
            // 
            this.lEndDate.AutoSize = true;
            this.lEndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lEndDate.Location = new System.Drawing.Point(5, 54);
            this.lEndDate.Name = "lEndDate";
            this.lEndDate.Size = new System.Drawing.Size(134, 26);
            this.lEndDate.TabIndex = 3;
            this.lEndDate.Text = "Fecha Fin:";
            this.lEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDatefin
            // 
            this.dtpDatefin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDatefin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatefin.Location = new System.Drawing.Point(147, 57);
            this.dtpDatefin.Name = "dtpDatefin";
            this.dtpDatefin.Size = new System.Drawing.Size(292, 20);
            this.dtpDatefin.TabIndex = 5;
            // 
            // lStartDate
            // 
            this.lStartDate.AutoSize = true;
            this.lStartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lStartDate.Location = new System.Drawing.Point(5, 28);
            this.lStartDate.Name = "lStartDate";
            this.lStartDate.Size = new System.Drawing.Size(134, 24);
            this.lStartDate.TabIndex = 2;
            this.lStartDate.Text = "Fecha Inicio:";
            this.lStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbIndexList
            // 
            this.cmbIndexList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbIndexList.FormattingEnabled = true;
            this.cmbIndexList.Location = new System.Drawing.Point(147, 5);
            this.cmbIndexList.Name = "cmbIndexList";
            this.cmbIndexList.Size = new System.Drawing.Size(292, 21);
            this.cmbIndexList.TabIndex = 0;
            // 
            // FrmViewIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 434);
            this.Controls.Add(this.pHeader);
            this.MinimumSize = new System.Drawing.Size(600, 440);
            this.Name = "FrmViewIndex";
            this.Text = "Ver Indices.";
            this.Controls.SetChildIndex(this.pHeader, 0);
            this.Controls.SetChildIndex(this.usDataView, 0);
            this.pHeader.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.DateTimePicker dtpDateini;
        private System.Windows.Forms.Label lIndex;
        private System.Windows.Forms.Label lEndDate;
        private System.Windows.Forms.DateTimePicker dtpDatefin;
        private System.Windows.Forms.Label lStartDate;
        private System.Windows.Forms.ComboBox cmbIndexList;
        private Qios.DevSuite.Components.QButton btnValidate;

    }
}
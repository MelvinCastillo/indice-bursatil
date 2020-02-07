namespace BVRDConsole.Front.Controls
{
    partial class usFileBrowser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvFiles = new System.Windows.Forms.ListView();
            this.chFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtFilePath = new Qios.DevSuite.Components.QInputBox();
            this.lbHeader = new Qios.DevSuite.Components.QMarkupLabel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnExplorer = new Qios.DevSuite.Components.QButton();
            this.panel = new System.Windows.Forms.Panel();
            this.btnRefresh = new Qios.DevSuite.Components.QButton();
            this.tableLayoutPanel.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvFiles
            // 
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileName,
            this.chSize});
            this.lvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFiles.Location = new System.Drawing.Point(0, 32);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(513, 273);
            this.lvFiles.TabIndex = 4;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            this.lvFiles.SelectedIndexChanged += new System.EventHandler(this.lvFiles_SelectedIndexChanged);
            // 
            // chFileName
            // 
            this.chFileName.Text = "Nombre de archivo";
            this.chFileName.Width = 240;
            // 
            // chSize
            // 
            this.chSize.Text = "Tamaño";
            this.chSize.Width = 100;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilePath.Location = new System.Drawing.Point(0, 0);
            this.txtFilePath.MaxLength = 256;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(361, 19);
            this.txtFilePath.TabIndex = 7;
            // 
            // lbHeader
            // 
            this.lbHeader.Configuration.AdjustHeightToTextSize = false;
            this.lbHeader.Configuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHeader.Location = new System.Drawing.Point(3, 3);
            this.lbHeader.MarkupText = "Ruta Origen:";
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(74, 26);
            this.lbHeader.TabIndex = 5;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel.Controls.Add(this.btnExplorer);
            this.tableLayoutPanel.Controls.Add(this.lbHeader, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panel, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(513, 32);
            this.tableLayoutPanel.TabIndex = 9;
            // 
            // btnExplorer
            // 
            this.btnExplorer.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnExplorer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExplorer.Image = global::BVRD.Windows.Controls.Properties.Resources.folder_fill_16x16;
            this.btnExplorer.Location = new System.Drawing.Point(481, 3);
            this.btnExplorer.Name = "btnExplorer";
            this.btnExplorer.Size = new System.Drawing.Size(29, 26);
            this.btnExplorer.TabIndex = 7;
            this.btnExplorer.Click += new System.EventHandler(this.btnExplorer_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.txtFilePath);
            this.panel.Controls.Add(this.btnRefresh);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(83, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(392, 26);
            this.panel.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.Image = global::BVRD.Windows.Controls.Properties.Resources.aperture_16x16;
            this.btnRefresh.Location = new System.Drawing.Point(361, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(31, 26);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // usFileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "usFileBrowser";
            this.Size = new System.Drawing.Size(513, 305);
            this.Load += new System.EventHandler(this.usFileBrowser_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader chFileName;
        private System.Windows.Forms.ColumnHeader chSize;
        private Qios.DevSuite.Components.QInputBox txtFilePath;
        private Qios.DevSuite.Components.QMarkupLabel lbHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panel;
        private Qios.DevSuite.Components.QButton btnExplorer;
        private Qios.DevSuite.Components.QButton btnRefresh;
    }
}

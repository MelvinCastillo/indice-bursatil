namespace BVRD.Windows.Controls.Controls
{
    partial class usFileManual
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
            this.usFileBrowser = new BVRDConsole.Front.Controls.usFileBrowser();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pToolBar = new System.Windows.Forms.Panel();
            this.btnRemoveFile = new Qios.DevSuite.Components.QButton();
            this.btnAddFile = new Qios.DevSuite.Components.QButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel.SuspendLayout();
            this.pToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // usFileBrowser
            // 
            this.usFileBrowser._FilePatch = "";
            this.usFileBrowser._FilesExtensions = "";
            this.usFileBrowser.BackColor = System.Drawing.Color.Transparent;
            this.usFileBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usFileBrowser.Location = new System.Drawing.Point(3, 3);
            this.usFileBrowser.Name = "usFileBrowser";
            this.usFileBrowser.Size = new System.Drawing.Size(344, 326);
            this.usFileBrowser.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.7193F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.2807F));
            this.tableLayoutPanel.Controls.Add(this.usFileBrowser, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.pToolBar, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(399, 332);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // pToolBar
            // 
            this.pToolBar.Controls.Add(this.btnRemoveFile);
            this.pToolBar.Controls.Add(this.btnAddFile);
            this.pToolBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pToolBar.Location = new System.Drawing.Point(353, 3);
            this.pToolBar.Name = "pToolBar";
            this.pToolBar.Size = new System.Drawing.Size(43, 326);
            this.pToolBar.TabIndex = 1;
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Configuration.ImageConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.True;
            this.btnRemoveFile.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnRemoveFile.Image = global::BVRD.Windows.Controls.Properties.Resources.minus_32x8;
            this.btnRemoveFile.Location = new System.Drawing.Point(0, 171);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(42, 42);
            this.btnRemoveFile.TabIndex = 1;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnAddFile.Image = global::BVRD.Windows.Controls.Properties.Resources.plus_32x32;
            this.btnAddFile.Location = new System.Drawing.Point(0, 114);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(42, 42);
            this.btnAddFile.TabIndex = 0;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // usFileManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "usFileManual";
            this.Size = new System.Drawing.Size(399, 332);
            this.tableLayoutPanel.ResumeLayout(false);
            this.pToolBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BVRDConsole.Front.Controls.usFileBrowser usFileBrowser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel pToolBar;
        private Qios.DevSuite.Components.QButton btnRemoveFile;
        private Qios.DevSuite.Components.QButton btnAddFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

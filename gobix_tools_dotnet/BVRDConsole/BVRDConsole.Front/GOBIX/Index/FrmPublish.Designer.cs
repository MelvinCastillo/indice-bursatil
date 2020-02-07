namespace BVRDConsole.Front.Index
{
    partial class FrmPublish
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
            this.usFileBrowser = new BVRDConsole.Front.Controls.usFileBrowser();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.usFileBrowser);
            this.groupBox.Location = new System.Drawing.Point(7, 31);
            this.groupBox.Size = new System.Drawing.Size(512, 300);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Gradient;
            this.btnCancel.Configuration.ImageConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.True;
            this.btnCancel.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnCancel.Location = new System.Drawing.Point(487, 336);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Gradient;
            this.btnOK.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnOK.Location = new System.Drawing.Point(10, 337);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // usFileBrowser
            // 
            this.usFileBrowser._CurrentFile = "";
            this.usFileBrowser._FilePatch = "";
            this.usFileBrowser._FilesExtensions = "";
            this.usFileBrowser.BackColor = System.Drawing.Color.Transparent;
            this.usFileBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usFileBrowser.Location = new System.Drawing.Point(3, 16);
            this.usFileBrowser.Name = "usFileBrowser";
            this.usFileBrowser.Size = new System.Drawing.Size(506, 281);
            this.usFileBrowser.TabIndex = 0;
            this.usFileBrowser.Load += new System.EventHandler(this.usFileBrowser_Load);
            // 
            // FrmPublish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 400);
            this.Name = "FrmPublish";
            this.Text = "Publicar Indices.";
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.usFileBrowser usFileBrowser;
    }
}
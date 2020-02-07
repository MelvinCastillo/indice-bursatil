namespace BVRDConsole.Front.Files
{
    partial class FrmSIVPublish
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
            this.groupBox.Location = new System.Drawing.Point(12, 34);
            this.groupBox.Size = new System.Drawing.Size(355, 332);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Gradient;
            this.btnCancel.Configuration.ImageConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.True;
            this.btnCancel.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnCancel.Location = new System.Drawing.Point(335, 372);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Gradient;
            this.btnOK.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnOK.Location = new System.Drawing.Point(12, 372);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // usFileBrowser
            // 
            this.usFileBrowser._FilePatch = "";
            this.usFileBrowser._FilesExtensions = "";
            this.usFileBrowser.BackColor = System.Drawing.Color.Transparent;
            this.usFileBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usFileBrowser.Location = new System.Drawing.Point(3, 16);
            this.usFileBrowser.Name = "usFileBrowser";
            this.usFileBrowser.Size = new System.Drawing.Size(349, 313);
            this.usFileBrowser.TabIndex = 1;
            // 
            // FrmSIVPublish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 431);
            this.Name = "FrmSIVPublish";
            this.Text = "Publicar Archivo.";
            this.Load += new System.EventHandler(this.FrmSIVPublish_Load);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.usFileBrowser usFileBrowser;
    }
}
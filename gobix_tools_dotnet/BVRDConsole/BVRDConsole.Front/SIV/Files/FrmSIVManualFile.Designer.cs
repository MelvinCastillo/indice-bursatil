namespace BVRDConsole.Front.Files
{
    partial class FrmSIVManualFile
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
            this.usFileManual = new BVRD.Windows.Controls.Controls.usFileManual();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.usFileManual);
            this.groupBox.Location = new System.Drawing.Point(9, 43);
            this.groupBox.Size = new System.Drawing.Size(411, 300);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Gradient;
            this.btnCancel.Configuration.ImageConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.True;
            this.btnCancel.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnCancel.Location = new System.Drawing.Point(388, 362);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Gradient;
            this.btnOK.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnOK.Location = new System.Drawing.Point(9, 362);
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // usFileManual
            // 
            this.usFileManual._FilePatch = "";
            this.usFileManual._FilesExtensions = "";
            this.usFileManual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usFileManual.Location = new System.Drawing.Point(3, 16);
            this.usFileManual.Name = "usFileManual";
            this.usFileManual.Size = new System.Drawing.Size(405, 281);
            this.usFileManual.TabIndex = 0;
            // 
            // FrmSIVManualFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 439);
            this.Name = "FrmSIVManualFile";
            this.Text = "SIV-Carga Manual De Archivos.";
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BVRD.Windows.Controls.Controls.usFileManual usFileManual;
    }
}
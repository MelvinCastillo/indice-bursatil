namespace BVRD.Windows.Controls.Base
{
    partial class FrmBaseDialog
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnOK = new Qios.DevSuite.Components.QButton();
            this.btnCancel = new Qios.DevSuite.Components.QButton();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Location = new System.Drawing.Point(12, 43);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(355, 300);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Gradient;
            this.btnOK.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnOK.Image = global::BVRD.Windows.Controls.Properties.Resources.check_32x26;
            this.btnOK.Location = new System.Drawing.Point(12, 362);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(32, 32);
            this.btnOK.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Gradient;
            this.btnCancel.Configuration.ImageConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.True;
            this.btnCancel.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnCancel.Image = global::BVRD.Windows.Controls.Properties.Resources.x_28x28;
            this.btnCancel.Location = new System.Drawing.Point(335, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(32, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmBaseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(385, 431);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBaseDialog";
            this.Controls.SetChildIndex(this.groupBox, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox;
        public Qios.DevSuite.Components.QButton btnCancel;
        public Qios.DevSuite.Components.QButton btnOK;
    }
}

namespace BVRDConsole.Front.Rebalancing
{
    partial class FrmDoRebalancing
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
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lblTipp = new System.Windows.Forms.Label();
            this.txtTipp = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.txtTipp);
            this.groupBox.Controls.Add(this.lblTipp);
            this.groupBox.Controls.Add(this.monthCalendar);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(12, 33);
            this.groupBox.Size = new System.Drawing.Size(354, 228);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Gradient;
            this.btnCancel.Configuration.ImageConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.True;
            this.btnCancel.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnCancel.Location = new System.Drawing.Point(334, 278);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Gradient;
            this.btnOK.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnOK.Location = new System.Drawing.Point(278, 278);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fecha:";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(120, 19);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 15;
            // 
            // lblTipp
            // 
            this.lblTipp.AutoSize = true;
            this.lblTipp.Location = new System.Drawing.Point(120, 194);
            this.lblTipp.Name = "lblTipp";
            this.lblTipp.Size = new System.Drawing.Size(31, 13);
            this.lblTipp.TabIndex = 16;
            this.lblTipp.Text = "Tipp:";
            // 
            // txtTipp
            // 
            this.txtTipp.Location = new System.Drawing.Point(158, 186);
            this.txtTipp.Name = "txtTipp";
            this.txtTipp.Size = new System.Drawing.Size(189, 20);
            this.txtTipp.TabIndex = 17;
            // 
            // FrmDoRebalancing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 336);
            this.Name = "FrmDoRebalancing";
            this.Text = "Nuevo Rebalanceo";
            this.Load += new System.EventHandler(this.FrmDoRebalancing_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.TextBox txtTipp;
        private System.Windows.Forms.Label lblTipp;
    }
}
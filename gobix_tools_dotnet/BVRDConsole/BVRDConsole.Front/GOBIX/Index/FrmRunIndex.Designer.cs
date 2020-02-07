namespace BVRDConsole.Front.Index
{
    partial class FrmRunIndex
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
            this.label2 = new System.Windows.Forms.Label();
            this.dateFile = new System.Windows.Forms.DateTimePicker();
            this.usGobixResult = new BVRD.Windows.Controls.Controls.usDataView();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.txtRegCount = new System.Windows.Forms.TextBox();
            this.btnValidate = new Qios.DevSuite.Components.QButton();
            this.txtFileDate = new System.Windows.Forms.TextBox();
            this.LRegCount = new System.Windows.Forms.Label();
            this.lFileDate = new System.Windows.Forms.Label();
            this.usViewRebalancing1 = new BVRDConsole.Front.Controls.usViewRebalancing();
            this.groupBox.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.usViewRebalancing1);
            this.groupBox.Controls.Add(this.gbDetails);
            this.groupBox.Controls.Add(this.usGobixResult);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Location = new System.Drawing.Point(3, 27);
            this.groupBox.Size = new System.Drawing.Size(664, 369);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Gradient;
            this.btnCancel.Configuration.ImageConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.True;
            this.btnCancel.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnCancel.Location = new System.Drawing.Point(627, 403);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Gradient;
            this.btnOK.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnOK.Location = new System.Drawing.Point(15, 403);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // dateFile
            // 
            this.dateFile.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFile.Location = new System.Drawing.Point(125, 27);
            this.dateFile.Name = "dateFile";
            this.dateFile.Size = new System.Drawing.Size(145, 20);
            this.dateFile.TabIndex = 4;
            // 
            // usGobixResult
            // 
            this.usGobixResult._Dataset = null;
            this.usGobixResult._TableIndex = 0;
            this.usGobixResult.Location = new System.Drawing.Point(12, 171);
            this.usGobixResult.Name = "usGobixResult";
            this.usGobixResult.Size = new System.Drawing.Size(644, 190);
            this.usGobixResult.TabIndex = 8;
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtRegCount);
            this.gbDetails.Controls.Add(this.btnValidate);
            this.gbDetails.Controls.Add(this.txtFileDate);
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Controls.Add(this.LRegCount);
            this.gbDetails.Controls.Add(this.lFileDate);
            this.gbDetails.Controls.Add(this.dateFile);
            this.gbDetails.Location = new System.Drawing.Point(338, 8);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(318, 154);
            this.gbDetails.TabIndex = 9;
            this.gbDetails.TabStop = false;
            // 
            // txtRegCount
            // 
            this.txtRegCount.Enabled = false;
            this.txtRegCount.Location = new System.Drawing.Point(125, 97);
            this.txtRegCount.Name = "txtRegCount";
            this.txtRegCount.Size = new System.Drawing.Size(182, 20);
            this.txtRegCount.TabIndex = 11;
            // 
            // btnValidate
            // 
            this.btnValidate.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnValidate.Image = global::BVRDConsole.Front.Properties.Resources.Market_Analysis_icon_24;
            this.btnValidate.Location = new System.Drawing.Point(276, 24);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(31, 27);
            this.btnValidate.TabIndex = 11;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtFileDate
            // 
            this.txtFileDate.Enabled = false;
            this.txtFileDate.Location = new System.Drawing.Point(125, 62);
            this.txtFileDate.Name = "txtFileDate";
            this.txtFileDate.Size = new System.Drawing.Size(182, 20);
            this.txtFileDate.TabIndex = 10;
            // 
            // LRegCount
            // 
            this.LRegCount.AutoSize = true;
            this.LRegCount.Location = new System.Drawing.Point(8, 101);
            this.LRegCount.Name = "LRegCount";
            this.LRegCount.Size = new System.Drawing.Size(109, 13);
            this.LRegCount.TabIndex = 9;
            this.LRegCount.Text = "Cantidad de registros:";
            // 
            // lFileDate
            // 
            this.lFileDate.AutoSize = true;
            this.lFileDate.Location = new System.Drawing.Point(8, 66);
            this.lFileDate.Name = "lFileDate";
            this.lFileDate.Size = new System.Drawing.Size(93, 13);
            this.lFileDate.TabIndex = 8;
            this.lFileDate.Text = "Fecha de archivo:";
            // 
            // usViewRebalancing1
            // 
            this.usViewRebalancing1._BeforeLastDate = new System.DateTime(((long)(0)));
            this.usViewRebalancing1._Date = new System.DateTime(((long)(0)));
            this.usViewRebalancing1._LastDate = new System.DateTime(((long)(0)));
            this.usViewRebalancing1._TIPPP = 0D;
            this.usViewRebalancing1.Location = new System.Drawing.Point(12, 16);
            this.usViewRebalancing1.MinimumSize = new System.Drawing.Size(320, 140);
            this.usViewRebalancing1.Name = "usViewRebalancing1";
            this.usViewRebalancing1.Size = new System.Drawing.Size(320, 146);
            this.usViewRebalancing1.TabIndex = 12;
            // 
            // FrmRunIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 462);
            this.Name = "FrmRunIndex";
            this.Text = "Ejecutar Indices";
            this.Load += new System.EventHandler(this.FrmRunIndex_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFile;
        private BVRD.Windows.Controls.Controls.usDataView usGobixResult;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label LRegCount;
        private System.Windows.Forms.Label lFileDate;
        private System.Windows.Forms.TextBox txtRegCount;
        private System.Windows.Forms.TextBox txtFileDate;
        private Qios.DevSuite.Components.QButton btnValidate;
        private Controls.usViewRebalancing usViewRebalancing1;
    }
}
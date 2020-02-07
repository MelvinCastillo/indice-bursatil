namespace BVRD.Windows.Controls.Base
{
    partial class FrmBaseDataView
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
            this.usDataView = new BVRD.Windows.Controls.Controls.usDataView();
            this.SuspendLayout();
            // 
            // usDataView
            // 
            this.usDataView._Dataset = null;
            this.usDataView._TableIndex = 0;
            this.usDataView.Location = new System.Drawing.Point(12, 71);
            this.usDataView.Name = "usDataView";
            this.usDataView.Size = new System.Drawing.Size(571, 332);
            this.usDataView.TabIndex = 1;
            // 
            // FrmBaseDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 432);
            this.Controls.Add(this.usDataView);
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "FrmBaseDataView";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.usDataView, 0);
            this.ResumeLayout(false);

        }

        #endregion

        public Controls.usDataView usDataView;

    }
}
namespace BVRDConsole.Front.Rebalancing
{
    partial class FrmSelectRebalancing
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
            this.btnManual = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManual
            // 
            this.btnManual.Image = global::BVRDConsole.Front.Properties.Resources.Target_Audience_Icon;
            this.btnManual.Location = new System.Drawing.Point(219, 39);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(145, 160);
            this.btnManual.TabIndex = 4;
            this.btnManual.Text = "Manual";
            this.btnManual.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Image = global::BVRDConsole.Front.Properties.Resources.Competitive_Keyword_Icon;
            this.btnAuto.Location = new System.Drawing.Point(57, 39);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(145, 160);
            this.btnAuto.TabIndex = 3;
            this.btnAuto.Text = "Automatico";
            this.btnAuto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // FrmSelectRebalancing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 228);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnAuto);
            this.Name = "FrmSelectRebalancing";
            this.Text = "Eliga el metodo para el rebalanceo...";
            this.Controls.SetChildIndex(this.btnAuto, 0);
            this.Controls.SetChildIndex(this.btnManual, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnManual;
    }
}
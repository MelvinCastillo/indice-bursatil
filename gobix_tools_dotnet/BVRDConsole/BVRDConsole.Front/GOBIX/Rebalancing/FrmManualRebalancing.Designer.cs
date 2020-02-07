namespace BVRDConsole.Front.Rebalancing
{
    partial class FrmManualRebalancing
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
            this.Wizard = new CristiPotlog.Controls.Wizard();
            this.wpRebalancigDate = new CristiPotlog.Controls.WizardPage();
            this.lDate = new System.Windows.Forms.Label();
            this.dtDateRebalancing = new System.Windows.Forms.DateTimePicker();
            this.wpWelcome = new CristiPotlog.Controls.WizardPage();
            this.Wizard.SuspendLayout();
            this.wpRebalancigDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wizard
            // 
            this.Wizard.Controls.Add(this.wpRebalancigDate);
            this.Wizard.Controls.Add(this.wpWelcome);
            this.Wizard.HeaderImage = global::BVRDConsole.Front.Properties.Resources.Header;
            this.Wizard.Location = new System.Drawing.Point(0, 28);
            this.Wizard.Name = "Wizard";
            this.Wizard.Pages.AddRange(new CristiPotlog.Controls.WizardPage[] {
            this.wpWelcome,
            this.wpRebalancigDate});
            this.Wizard.Size = new System.Drawing.Size(642, 362);
            this.Wizard.TabIndex = 0;
            this.Wizard.WelcomeImage = global::BVRDConsole.Front.Properties.Resources.outlook3;
            // 
            // wpRebalancigDate
            // 
            this.wpRebalancigDate.Controls.Add(this.lDate);
            this.wpRebalancigDate.Controls.Add(this.dtDateRebalancing);
            this.wpRebalancigDate.Description = "Elegir Fecha De Rebalanceo.";
            this.wpRebalancigDate.Location = new System.Drawing.Point(0, 0);
            this.wpRebalancigDate.Name = "wpRebalancigDate";
            this.wpRebalancigDate.Size = new System.Drawing.Size(642, 314);
            this.wpRebalancigDate.TabIndex = 11;
            this.wpRebalancigDate.Title = "Proceso de rebalanceo.";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(191, 185);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(40, 13);
            this.lDate.TabIndex = 1;
            this.lDate.Text = "Fecha:";
            // 
            // dtDateRebalancing
            // 
            this.dtDateRebalancing.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateRebalancing.Location = new System.Drawing.Point(257, 179);
            this.dtDateRebalancing.Name = "dtDateRebalancing";
            this.dtDateRebalancing.Size = new System.Drawing.Size(138, 20);
            this.dtDateRebalancing.TabIndex = 0;
            // 
            // wpWelcome
            // 
            this.wpWelcome.Description = "Bienvenidos al asistente de Rebalanceo manual.";
            this.wpWelcome.Location = new System.Drawing.Point(0, 0);
            this.wpWelcome.Name = "wpWelcome";
            this.wpWelcome.Size = new System.Drawing.Size(642, 314);
            this.wpWelcome.Style = CristiPotlog.Controls.WizardPageStyle.Welcome;
            this.wpWelcome.TabIndex = 10;
            this.wpWelcome.Title = "Proceso de rebalanceo.";
            // 
            // FrmManualRebalancing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 405);
            this.Controls.Add(this.Wizard);
            this.Name = "FrmManualRebalancing";
            this.Text = "Manual Rebalancing";
            this.Controls.SetChildIndex(this.Wizard, 0);
            this.Wizard.ResumeLayout(false);
            this.wpRebalancigDate.ResumeLayout(false);
            this.wpRebalancigDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CristiPotlog.Controls.Wizard Wizard;
        private CristiPotlog.Controls.WizardPage wpWelcome;
        private CristiPotlog.Controls.WizardPage wpRebalancigDate;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.DateTimePicker dtDateRebalancing;


    }
}
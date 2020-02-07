namespace BVRDConsole.Front
{
    partial class FrmDashBoard
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
            this.qStatusBar = new Qios.DevSuite.Components.QStatusBar();
            this.qPanBrowser = new Qios.DevSuite.Components.QPanel();
            this.qRibbonCaption1 = new Qios.DevSuite.Components.Ribbon.QRibbonCaption();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).BeginInit();
            this.SuspendLayout();
            // 
            // qStatusBar
            // 
            this.qStatusBar.Location = new System.Drawing.Point(0, 346);
            this.qStatusBar.Name = "qStatusBar";
            this.qStatusBar.ShowPanels = false;
            this.qStatusBar.Size = new System.Drawing.Size(657, 15);
            this.qStatusBar.SizingGrip = false;
            this.qStatusBar.TabIndex = 1;
            this.qStatusBar.TextVerticalMargin = 0;
            // 
            // qPanBrowser
            // 
            this.qPanBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qPanBrowser.Location = new System.Drawing.Point(0, 28);
            this.qPanBrowser.Name = "qPanBrowser";
            this.qPanBrowser.Size = new System.Drawing.Size(657, 318);
            this.qPanBrowser.TabIndex = 2;
            // 
            // qRibbonCaption1
            // 
            this.qRibbonCaption1.Configuration.IconConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.qRibbonCaption1.Location = new System.Drawing.Point(0, 0);
            this.qRibbonCaption1.Name = "qRibbonCaption1";
            this.qRibbonCaption1.Size = new System.Drawing.Size(657, 28);
            this.qRibbonCaption1.TabIndex = 0;
            this.qRibbonCaption1.Text = null;
            // 
            // FrmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 361);
            this.Controls.Add(this.qPanBrowser);
            this.Controls.Add(this.qRibbonCaption1);
            this.Controls.Add(this.qStatusBar);
            this.Name = "FrmDashBoard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Qios.DevSuite.Components.QStatusBar qStatusBar;
        private Qios.DevSuite.Components.QPanel qPanBrowser;
        private Qios.DevSuite.Components.Ribbon.QRibbonCaption qRibbonCaption1;





    }
}
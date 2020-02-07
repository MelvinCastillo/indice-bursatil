namespace BVRD.Windows.Controls.Base
{
    partial class FrmBase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.tsStatus = new Qios.DevSuite.Components.QStatusBar();
            this.qRibbonCaption = new Qios.DevSuite.Components.Ribbon.QRibbonCaption();
            this.qGlobalColorSchemeManager = new Qios.DevSuite.Components.QGlobalColorSchemeManager(this.components);
            this.qPersistenceManager = new Qios.DevSuite.Components.QPersistenceManager(this.components);
            this.qTranslucentWindowComponent = new Qios.DevSuite.Components.QTranslucentWindowComponent(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption)).BeginInit();
            this.SuspendLayout();
            // 
            // tsStatus
            // 
            this.tsStatus.Location = new System.Drawing.Point(0, 301);
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.ShowPanels = false;
            this.tsStatus.Size = new System.Drawing.Size(319, 15);
            this.tsStatus.SizingGrip = false;
            this.tsStatus.TabIndex = 1;
            this.tsStatus.TextVerticalMargin = 0;
            // 
            // qRibbonCaption
            // 
            this.qRibbonCaption.Configuration.IconConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.qRibbonCaption.Location = new System.Drawing.Point(0, 0);
            this.qRibbonCaption.Name = "qRibbonCaption";
            this.qRibbonCaption.Size = new System.Drawing.Size(319, 28);
            this.qRibbonCaption.TabIndex = 2;
            this.qRibbonCaption.Text = "-";
            // 
            // qGlobalColorSchemeManager
            // 
            this.qGlobalColorSchemeManager.Global.CurrentTheme = "LunaBlue";
            this.qGlobalColorSchemeManager.Global.InheritCurrentThemeFromWindows = false;
            this.qGlobalColorSchemeManager.Global.Scope = Qios.DevSuite.Components.QColorSchemeScope.ControlAndRelated;
            // 
            // qPersistenceManager
            // 
            this.qPersistenceManager.PersistGuid = new System.Guid("8ce34a94-9338-470e-ae4d-da265257557f");
            // 
            // qTranslucentWindowComponent
            // 
            this.qTranslucentWindowComponent.ColorScheme.Scope = Qios.DevSuite.Components.QColorSchemeScope.ControlAndRelated;
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 316);
            this.Controls.Add(this.qRibbonCaption);
            this.Controls.Add(this.tsStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Qios.DevSuite.Components.QStatusBar tsStatus;
        private Qios.DevSuite.Components.Ribbon.QRibbonCaption qRibbonCaption;
        private Qios.DevSuite.Components.QGlobalColorSchemeManager qGlobalColorSchemeManager;
        private Qios.DevSuite.Components.QPersistenceManager qPersistenceManager;
        private Qios.DevSuite.Components.QTranslucentWindowComponent qTranslucentWindowComponent;

    }
}
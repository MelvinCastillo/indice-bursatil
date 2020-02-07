namespace BVRDConsole.Front
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtUserName = new Qios.DevSuite.Components.QInputBox();
            this.txtPassword = new Qios.DevSuite.Components.QInputBox();
            this.txtDomain = new Qios.DevSuite.Components.QInputBox();
            this.lbUserName = new Qios.DevSuite.Components.QMarkupLabel();
            this.lbPassword = new Qios.DevSuite.Components.QMarkupLabel();
            this.lbDomain = new Qios.DevSuite.Components.QMarkupLabel();
            this.qStatusBar = new Qios.DevSuite.Components.QStatusBar();
            this.qRibbonCaption1 = new Qios.DevSuite.Components.Ribbon.QRibbonCaption();
            this.qTranslucentWindowComponent = new Qios.DevSuite.Components.QTranslucentWindowComponent(this.components);
            this.qGlobalColorSchemeManager = new Qios.DevSuite.Components.QGlobalColorSchemeManager(this.components);
            this.qPersistenceManager = new Qios.DevSuite.Components.QPersistenceManager(this.components);
            this.btnCancel = new Qios.DevSuite.Components.QButton();
            this.btnLogin = new Qios.DevSuite.Components.QButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(264, 33);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(185, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(264, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(185, 20);
            this.txtPassword.TabIndex = 0;
            // 
            // txtDomain
            // 
            this.txtDomain.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDomain.ColorScheme.TextColor.SetColor("LunaBlue", System.Drawing.Color.SteelBlue, false);
            this.txtDomain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomain.Location = new System.Drawing.Point(264, 121);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.ReadOnly = true;
            this.txtDomain.Size = new System.Drawing.Size(185, 20);
            this.txtDomain.TabIndex = 2;
            // 
            // lbUserName
            // 
            this.lbUserName.Location = new System.Drawing.Point(146, 37);
            this.lbUserName.MarkupText = "Nombre de usuario:";
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(114, 15);
            this.lbUserName.TabIndex = 4;
            // 
            // lbPassword
            // 
            this.lbPassword.Location = new System.Drawing.Point(146, 77);
            this.lbPassword.MarkupText = "Contraseña:";
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(72, 15);
            this.lbPassword.TabIndex = 5;
            // 
            // lbDomain
            // 
            this.lbDomain.Location = new System.Drawing.Point(146, 125);
            this.lbDomain.MarkupText = "Dominio:";
            this.lbDomain.Name = "lbDomain";
            this.lbDomain.Size = new System.Drawing.Size(54, 15);
            this.lbDomain.TabIndex = 6;
            // 
            // qStatusBar
            // 
            this.qStatusBar.Location = new System.Drawing.Point(0, 239);
            this.qStatusBar.Name = "qStatusBar";
            this.qStatusBar.ShowPanels = false;
            this.qStatusBar.Size = new System.Drawing.Size(463, 20);
            this.qStatusBar.SizingGrip = false;
            this.qStatusBar.TabIndex = 10;
            this.qStatusBar.Text = "Favor ingrese su nombre de usuario y contraseña valida.";
            this.qStatusBar.TextVerticalMargin = 0;
            // 
            // qRibbonCaption1
            // 
            this.qRibbonCaption1.Configuration.IconConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.qRibbonCaption1.Location = new System.Drawing.Point(0, 0);
            this.qRibbonCaption1.Name = "qRibbonCaption1";
            this.qRibbonCaption1.Size = new System.Drawing.Size(463, 28);
            this.qRibbonCaption1.TabIndex = 11;
            this.qRibbonCaption1.Text = "Consola RDVAL - V:{0}.";
            // 
            // qTranslucentWindowComponent
            // 
            this.qTranslucentWindowComponent.ColorScheme.Scope = Qios.DevSuite.Components.QColorSchemeScope.ControlAndRelated;
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
            // btnCancel
            // 
            this.btnCancel.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Gradient;
            this.btnCancel.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnCancel.Image = global::BVRDConsole.Front.Properties.Resources.x_28x28;
            this.btnCancel.Location = new System.Drawing.Point(404, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(32, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Gradient;
            this.btnLogin.Configuration.ImageConfiguration.Margin = new Qios.DevSuite.Components.QMargin(4, 4, 4, 4);
            this.btnLogin.Configuration.ImageConfiguration.Padding = new Qios.DevSuite.Components.QPadding(4, 4, 4, 4);
            this.btnLogin.Configuration.Padding = new Qios.DevSuite.Components.QPadding(3, 3, 3, 3);
            this.btnLogin.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnLogin.Image = global::BVRDConsole.Front.Properties.Resources.check_32x26;
            this.btnLogin.Location = new System.Drawing.Point(359, 168);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(32, 32);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.lbDomain);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.lbPassword);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Controls.Add(this.txtDomain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 211);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::BVRDConsole.Front.Properties.Resources.rdval1;
            this.pictureBox.Location = new System.Drawing.Point(3, 15);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(137, 162);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // FrmLogin
            // 
            this.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Solid;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 259);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.qRibbonCaption1);
            this.Controls.Add(this.qStatusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consola RDVAL - V:{0}.";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Qios.DevSuite.Components.QInputBox txtUserName;
        private Qios.DevSuite.Components.QInputBox txtPassword;
        private Qios.DevSuite.Components.QInputBox txtDomain;
        private Qios.DevSuite.Components.QMarkupLabel lbUserName;
        private Qios.DevSuite.Components.QMarkupLabel lbPassword;
        private Qios.DevSuite.Components.QMarkupLabel lbDomain;
        private Qios.DevSuite.Components.QButton btnLogin;
        private Qios.DevSuite.Components.QStatusBar qStatusBar;
        private Qios.DevSuite.Components.Ribbon.QRibbonCaption qRibbonCaption1;
        private Qios.DevSuite.Components.QTranslucentWindowComponent qTranslucentWindowComponent;
        private Qios.DevSuite.Components.QGlobalColorSchemeManager qGlobalColorSchemeManager;
        private Qios.DevSuite.Components.QPersistenceManager qPersistenceManager;
        private Qios.DevSuite.Components.QButton btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
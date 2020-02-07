using Qios.DevSuite.Components.Ribbon;
using System;
using System.Windows.Forms;

namespace BVRDConsole.Front
{
    public partial class FrmLogin : QRibbonForm
    {
        int AttemptsCounts = BVRD.Global.Global_Parameters.AttemptsCounts;
        int CurrentAttemptsCounts = 0;

        public string AppDomain { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                BVRD.Security.Utils.LDapAuthenticate aAuthent = new BVRD.Security.Utils.LDapAuthenticate();

                if (!aAuthent.SetDomain(this.txtDomain.Text))
                {
                    MessageBox.Show("Nombre de dominio no valido.");
                    return;
                }

                if (!aAuthent.SetUser(this.txtUserName.Text))
                {
                    MessageBox.Show("Debe proporcionar un nombre de usuario valido, verifique!");
                    return;
                }

                if (!aAuthent.SetPass(this.txtPassword.Text))
                {
                    string msg = string.Empty;
                    msg = string.Format("Contraseña no valida para el usuario {0}, verifique!", txtUserName.Text.ToUpper());

                    MessageBox.Show(msg);
                    return;
                }

                aAuthent.SetAuthenticationType(false);

                if (aAuthent.Login())
                {
                    BVRD.Global.Global_Parameters.UserName = this.txtUserName.Text.ToString();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    CurrentAttemptsCounts++;

                    if (CurrentAttemptsCounts < AttemptsCounts)
                    {
                        MessageBox.Show(aAuthent.MSG);
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
            }
            catch { }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Text = string.Format(this.Text, Application.ProductVersion);

            this.txtUserName.Text = Environment.UserName;

            if (string.IsNullOrEmpty(this.AppDomain))
            {
                txtDomain.Enabled = false;
            }
            else
            {
                txtDomain.Text = this.AppDomain;
                txtDomain.Enabled = true;
            }
            Application.DoEvents();

            this.txtPassword.Focus();
        }
    }
}

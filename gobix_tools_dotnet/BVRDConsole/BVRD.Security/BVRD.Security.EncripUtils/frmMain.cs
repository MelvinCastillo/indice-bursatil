using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BVRD.Security.EncripUtils
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (txtClearText.Text == "")
            {
                error.SetError(txtClearText, "Enter the text you want to encrypt");
            }
            else
            {
                error.Clear();
                string clearText = txtClearText.Text.Trim();
                string cipherText = BVRD.Security.Utils.CryptorEngine.Encrypt(clearText, true);                
                txtCipherText.Text = cipherText;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string cipherText = txtClearText.Text.Trim();
            string decryptedText = BVRD.Security.Utils.CryptorEngine.Decrypt(cipherText, true);
            txtDecryptedText.Text = decryptedText;         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtClearText.Text = string.Empty;
            txtCipherText.Text = string.Empty;
            txtDecryptedText.Text = string.Empty;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            //BVRD.Security.Utils.LDapAuthenticate ldap = new BVRD.Security.Utils.LDapAuthenticate()

            // List<> ll ldap.GetADUsers();
        }
    }
}
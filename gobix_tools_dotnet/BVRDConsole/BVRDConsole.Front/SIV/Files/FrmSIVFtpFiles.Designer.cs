namespace BVRDConsole.Front.Files
{
    partial class FrmSIVFtpFiles
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDefaultFileName = new System.Windows.Forms.Label();
            this.lbvServer = new System.Windows.Forms.TextBox();
            this.lbvUser = new System.Windows.Forms.TextBox();
            this.lbvPassword = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lblPassword);
            this.groupBox.Controls.Add(this.lbvPassword);
            this.groupBox.Controls.Add(this.lblUser);
            this.groupBox.Controls.Add(this.lbvUser);
            this.groupBox.Controls.Add(this.lblServer);
            this.groupBox.Controls.Add(this.lbvServer);
            this.groupBox.Location = new System.Drawing.Point(8, 32);
            this.groupBox.Size = new System.Drawing.Size(355, 230);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Gradient;
            this.btnCancel.Configuration.ImageConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.True;
            this.btnCancel.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnCancel.Location = new System.Drawing.Point(331, 281);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Gradient;
            this.btnOK.Configuration.TextConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.btnOK.Location = new System.Drawing.Point(8, 281);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(37, 104);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 13);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Contraseña:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(37, 70);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "Usuario:";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(37, 36);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(49, 13);
            this.lblServer.TabIndex = 9;
            this.lblServer.Text = "Servidor:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbDefaultFileName);
            this.panel1.Location = new System.Drawing.Point(17, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 67);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre de archivo:";
            // 
            // lbDefaultFileName
            // 
            this.lbDefaultFileName.AutoSize = true;
            this.lbDefaultFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDefaultFileName.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbDefaultFileName.Location = new System.Drawing.Point(8, 32);
            this.lbDefaultFileName.Name = "lbDefaultFileName";
            this.lbDefaultFileName.Size = new System.Drawing.Size(17, 24);
            this.lbDefaultFileName.TabIndex = 6;
            this.lbDefaultFileName.Text = "-";
            // 
            // lbvServer
            // 
            this.lbvServer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lbvServer.Location = new System.Drawing.Point(120, 32);
            this.lbvServer.Name = "lbvServer";
            this.lbvServer.ReadOnly = true;
            this.lbvServer.Size = new System.Drawing.Size(198, 20);
            this.lbvServer.TabIndex = 0;
            this.lbvServer.Text = "-";
            // 
            // lbvUser
            // 
            this.lbvUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lbvUser.Location = new System.Drawing.Point(120, 66);
            this.lbvUser.Name = "lbvUser";
            this.lbvUser.ReadOnly = true;
            this.lbvUser.Size = new System.Drawing.Size(198, 20);
            this.lbvUser.TabIndex = 1;
            this.lbvUser.Text = "-";
            // 
            // lbvPassword
            // 
            this.lbvPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lbvPassword.Location = new System.Drawing.Point(120, 100);
            this.lbvPassword.Name = "lbvPassword";
            this.lbvPassword.ReadOnly = true;
            this.lbvPassword.Size = new System.Drawing.Size(198, 20);
            this.lbvPassword.TabIndex = 2;
            this.lbvPassword.Text = "-";
            // 
            // FrmSIVFtpFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 347);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSIVFtpFiles";
            this.Text = "Archivos FTP.";
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.groupBox, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDefaultFileName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox lbvPassword;
        private System.Windows.Forms.TextBox lbvUser;
        private System.Windows.Forms.TextBox lbvServer;
    }
}
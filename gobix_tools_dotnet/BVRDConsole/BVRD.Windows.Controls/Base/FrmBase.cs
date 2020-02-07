using ComponentFactory.Krypton.Toolkit;
using Qios.DevSuite.Components.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BVRD.Windows.Controls.Base
{
    public partial class FrmBase : QRibbonForm
    {
        public FrmBase()
        {
            InitializeComponent();
            
        }

        public void ShowMsg(string text)
        {
            try
            { 
                this.tsStatus.Text = text;
            }
            catch { }

        }
    }
}

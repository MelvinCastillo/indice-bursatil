using Qios.DevSuite.Components.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BVRDConsole.Front
{
    public partial class FrmDashBoard : QRibbonForm
    {
        string url = string.Empty;

        public FrmDashBoard()
        {
            InitializeComponent();

            Application.DoEvents();

            this.WindowState = FormWindowState.Maximized;

            Application.DoEvents();

            url = BVRD.Global.Gobix_Parameters.GobixURL;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BVRDConsole.Front.Controls
{
    public partial class usViewRebalancing : UserControl
    {
        private DateTime _date = DateTime.Now;
        public usViewRebalancing()
        {
            InitializeComponent();

            _ID = 0;
            _Date = DateTime.MinValue;
            _LastDate = DateTime.MinValue;
            _BeforeLastDate = DateTime.MinValue;
            _TIPPP = 0;
            _Status = false;
        }

        [DefaultValue(0)]
        public int _ID
        {           
            get
            {
                return Convert.ToInt32(qtxtID.Text.Trim());
            }
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    qtxtID.Text = value.ToString().Trim();
                }
            }
        }

        public  DateTime _Date
        {
            get
            {
                return Convert.ToDateTime(qtxtDate.Text);
            }
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    qtxtDate.Text = value.ToShortDateString();
                }
            }
        }

        public DateTime _LastDate
        {
            get
            {
                return Convert.ToDateTime(qtxtLastDate.Text);
            }
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    qtxtLastDate.Text = value.ToShortDateString();
                }
            }
        }

        public DateTime _BeforeLastDate
        {
            get
            {
                return Convert.ToDateTime(qtxtBeforeLastDate.Text);
            }
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    qtxtBeforeLastDate.Text = value.ToShortDateString();
                }
            }
        }

        [DefaultValue(0)]
        public double _TIPPP
        {
            get
            {
                return Convert.ToDouble(qtxtTIPPP.Text);
            }
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    qtxtTIPPP.Text = value.ToString();
                }
            }
        }

        bool vStatus;
        [DefaultValue(false)]
        public bool _Status
        {
            get
            {
                return vStatus;
            }
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    Point loc = new Point(1, 1);
                    vStatus = value;

                    picTrue.Visible = false;
                    picFalse.Visible = false;

                    picTrue.Visible = value;
                    picFalse.Visible = ! value;

                    picTrue.Location = loc;
                    picFalse.Location = loc;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BVRD.Windows.Controls.Controls
{
    public partial class usFileManual : UserControl
    {        
        public usFileManual()
        {
            InitializeComponent();
        }

        public string _FilePatch
        {
            get
            {
                return this.usFileBrowser._FilePatch;
            }
            set
            {
                if (value != null)
                {
                    this.usFileBrowser._FilePatch = value;
                }
            }
        }

        public string _FilesExtensions
        {
            get
            {
                return this.usFileBrowser._FilesExtensions;
            }
            set
            {
                if (value != null)
                {
                    this.usFileBrowser._FilesExtensions = value;
                }
            }
        }
         
        public void _Refresh()
        {
            this.usFileBrowser._Refresh();
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            string filer = "Documentoss|{0}";
            filer = string.Format(filer, _FilesExtensions);
            openFileDialog.Filter = filer;

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK) 
            {
                string file = openFileDialog.FileName;
                try
                {
                    System.IO.FileInfo fi = new System.IO.FileInfo(file);

                    string destFile = _FilePatch + @"\" + fi.Name.ToString();

                    if (System.IO.File.Exists(destFile))
                    {
                        System.IO.File.Delete(destFile);
                    }

                    System.IO.File.Copy(file, destFile, true);

                    _Refresh();
                }
                catch 
                {
                }
            }
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            try 
            {
                string ext = _FilesExtensions.Replace("*", "");
                string selectFile = this.usFileBrowser._CurrentFile;

                if (!string.IsNullOrEmpty(selectFile))
                {
                    string file = _FilePatch + @"\" + selectFile + ext.ToString();

                    System.IO.File.Delete(file);
                     _Refresh();
                }

            }
            catch 
            { }
        }

    }
}

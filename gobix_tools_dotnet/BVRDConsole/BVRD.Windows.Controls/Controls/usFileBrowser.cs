using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BVRDConsole.Front.Controls
{
    public partial class usFileBrowser : UserControl
    {
        string FilePatch = string.Empty;
        public string _FilePatch
        {
            get
            {
                return FilePatch;
            }
            set
            {
                if (value != null)
                {
                    FilePatch = value;
                }
            }
        }

        string CurrentFile = string.Empty;
        public string _CurrentFile
        {
            get
            {
                return CurrentFile;
            }
            set
            {
                if (value != null)
                {
                    CurrentFile = value;
                }
            }
        }


        string FilesExtensions = string.Empty;
        public string _FilesExtensions
        {
            get
            {
                return FilesExtensions;
            }
            set
            {
                if (value != null)
                {
                    FilesExtensions = value;
                }
            }
        }


        public usFileBrowser()
        {
            InitializeComponent();

            lvFiles.View = View.Details;
            lvFiles.LabelEdit = true;
            lvFiles.AllowColumnReorder = true;
            lvFiles.FullRowSelect = true;
            lvFiles.GridLines = true;
            lvFiles.Sorting = SortOrder.Ascending;

            Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtFilePath.Text) || Directory.Exists(txtFilePath.Text))
                {

                    lvFiles.Items.Clear();

                    string[] files = Directory.GetFiles(txtFilePath.Text, FilesExtensions);
                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(file);
                        ListViewItem item = new ListViewItem(fileName, 0);
                        item.Tag = file;

                        FileInfo fi = new FileInfo(file);

                        string filesize = "{0} KB";
                        float kbSize = fi.Length / 1024;

                        filesize = string.Format(filesize, kbSize);
                        item.SubItems.Add(filesize);

                        lvFiles.Items.Add(item);
                    }
                }
            }
            catch { }
        }

        private void usFileBrowser_Load(object sender, EventArgs e)
        {
            txtFilePath.Text = FilePatch;

            btnRefresh_Click(sender, e);
        }


        public void _Refresh()
        {
            btnRefresh_Click(null, null);
        }

        private void btnExplorer_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", txtFilePath.Text);
            }
            catch { }
        }

        private void lvFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem ls = lvFiles.SelectedItems[0];

                _CurrentFile = ls.Text.ToString();
            }
            catch 
            { }
        }
    }
}

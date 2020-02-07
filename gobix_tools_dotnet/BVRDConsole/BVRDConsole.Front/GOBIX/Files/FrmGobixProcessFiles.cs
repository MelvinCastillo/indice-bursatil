using System;
using System.IO;

namespace BVRDConsole.Front.Files
{
    public partial class FrmGobixProcessFiles : BVRD.Windows.Controls.Base.FrmBaseDialog
    {
        Gobix.BusinessLayer.GobixPipca _GobixPipca = new Gobix.BusinessLayer.GobixPipca();
        public FrmGobixProcessFiles()
        {
            InitializeComponent();
            this.usFileBrowser._FilePatch = BVRD.Global.Gobix_Parameters.FilePatch;
            this.usFileBrowser._FilesExtensions = BVRD.Global.Gobix_Parameters.FilesExtensions;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool errors = false;

            try
            {
                base.ShowMsg("");
                btnOK.Enabled = false;
                string FilesPatch = BVRD.Global.Gobix_Parameters.FilePatch;
                string SuccessPatch = BVRD.Global.Gobix_Parameters.SuccessFiles;
                string FileExtension = BVRD.Global.Gobix_Parameters.FilesExtensions;
                string SearchPatter = BVRD.Global.Gobix_Parameters.SearchPatter;

                DirectoryInfo directory = new DirectoryInfo(@FilesPatch);
                FileInfo[] files = directory.GetFiles(FileExtension);
                DirectoryInfo[] directories = directory.GetDirectories();
                 
                for (int i = 0; i < files.Length; i++)
                {
                   
                    string FileName = ((FileInfo)files[i]).FullName;
                    _GobixPipca.currentFile = ((FileInfo)files[i]).Name;

                    StreamReader sr;
                    if (_GobixPipca.currentFile.Contains(SearchPatter))
                    {
                        using (sr = File.OpenText(FileName))
                        {
                            string s = String.Empty;
                            while ((s = sr.ReadLine()) != null)
                            {
                                _GobixPipca.exe_sp_PIPCA_VectorPreciosRD(s);
                                errors = false;
                            }
                        }

                        Console.WriteLine(FileName);
                        sr.Close();
                        if (File.Exists(SuccessPatch + @"\" + ((FileInfo)files[i]).Name))
                            File.Delete(SuccessPatch + @"\" + ((FileInfo)files[i]).Name);

                        File.Move(FileName, SuccessPatch + @"\" + ((FileInfo)files[i]).Name);
                    }
                }
            }
            catch (Exception ex)
            { base.ShowMsg(ex.Message); }
            finally
            {
                _GobixPipca.currentFile = string.Empty;
                _GobixPipca.currentISIN = string.Empty;
                btnOK.Enabled = true;
                base.ShowMsg("Archivos procesados correctamente.");
                usFileBrowser._Refresh();
            }
        }
    }
}

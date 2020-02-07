using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Xml;

namespace BVRDConsole.Front.Files
{
    public partial class FrmSIVProcessFiles : BVRD.Windows.Controls.Base.FrmBaseDialog
    {
        SIV.BusinessLayer.SIVData _SIVData = new SIV.BusinessLayer.SIVData();
        public FrmSIVProcessFiles()
        {
            InitializeComponent();
            this.usFileBrowser._FilePatch = BVRD.Global.SIV_Parameters.FilePatch;
            this.usFileBrowser._FilesExtensions = BVRD.Global.SIV_Parameters.FilesExtensions;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                base.ShowMsg("");
                btnOK.Enabled = false;
                bool errors = false;
                string FilesPatch = BVRD.Global.SIV_Parameters.FilePatch;
                string SuccessPatch = BVRD.Global.SIV_Parameters.SuccessFiles;
                string FileExtension = BVRD.Global.SIV_Parameters.FilesExtensions;
                string SearchPatter = BVRD.Global.SIV_Parameters.SearchPatter;

                DirectoryInfo directory = new DirectoryInfo(@FilesPatch);
                FileInfo[] files = directory.GetFiles(FileExtension);
                DirectoryInfo[] directories = directory.GetDirectories();

                for (int i = 0; i < files.Length; i++)
                {
                   
                    string FileName = ((FileInfo)files[i]).FullName;
                    _SIVData.currentFile = ((FileInfo)files[i]).Name;

                    if (_SIVData.currentFile.Contains(SearchPatter))
                    {
                        ClearFile(FileName);
                        XmlDocument doc = new XmlDocument();
                        doc.Load(FileName);

                        int IDCarga = _SIVData.exe_sp_SIVVectoresEncabezado(BVRD.Global.Global_Parameters.UserName, Environment.MachineName.ToString(), FileName.ToString());

                        foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                        {
                            _SIVData.exe_sp_SIVVectoresDetalle(IDCarga, node);
                        }

                        string dayDirectory = SuccessPatch + @"\" + DateTime.Now.ToString("yyyyMMdd");
                        if (Directory.Exists(dayDirectory))
                            Directory.Delete(dayDirectory, true);

                        Directory.CreateDirectory(dayDirectory);

                        string SuccessfilePatch = dayDirectory + @"\" + ((FileInfo)files[i]).Name;
                        if (File.Exists(SuccessfilePatch))
                            File.Delete(SuccessfilePatch);

                        File.Move(FileName, SuccessfilePatch);
                        base.ShowMsg("Archivos procesados correctamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                base.ShowMsg(ex.Message);
                return;
            }
            finally
            {
                _SIVData.currentFile = string.Empty;
                btnOK.Enabled = true;
                usFileBrowser._Refresh();
            }
        }

        private void ClearFile(string file)
        {
            string tmpFile = string.Empty;
            FileInfo fi = new FileInfo(file);
            tmpFile = Path.GetTempPath() + @"\" + fi.Name.ToString();

            if (File.Exists(tmpFile))
            {
                File.Delete(tmpFile);
            }

            File.Move(file, tmpFile);
            StreamWriter sw = new StreamWriter(file);
            string path = tmpFile;
            string line = File.ReadAllText(path, Encoding.GetEncoding("ISO-8859-1"));
            string asAscii = string.Empty;

            asAscii = line.Replace("Ñ", "N");
            asAscii = line.Replace("Á", "A");
            asAscii = line.Replace("É", "E");
            asAscii = line.Replace("Í", "I");
            asAscii = line.Replace("Ó", "O");
            asAscii = line.Replace("Ú", "U");
            sw.WriteLine(asAscii);
            sw.Flush();
            sw.Dispose();

            if (File.Exists(tmpFile))
            {
                File.Delete(tmpFile);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace copy2
{
    public partial class frmConfigurApp : Form
    {
        public frmConfigurApp()
        {
            InitializeComponent();
        }

        private void cmdExportarDB_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Win32.SaveFileDialog save = new Microsoft.Win32.SaveFileDialog();
                save.FileName = "copy";
                save.DefaultExt = ".sqlite";
                save.Filter = "Database files(.sqlite)|*.db";

                bool? result = save.ShowDialog();

                if (result==true)
                {
                    save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    WebClient web = new WebClient();
                    web.DownloadFile(@"copy.sqlite", save.FileName);
                    string filename = save.FileName;
                }
            }
            catch(Exception err)
            {
                System.Windows.MessageBox.Show(err.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void cmdImportarDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = ".sqlite";
            open.Filter = "Database files(.sqlite)|*.db";
            if(open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if (File.Exists(@"copy.sqlite"))
                    {
                        File.Delete(@"copy.sqlite");
                    }
                    File.Copy(open.FileName, Path.GetFileName(open.FileName));
                }
                catch(Exception err)
                {
                    System.Windows.MessageBox.Show(err.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }
    }
}

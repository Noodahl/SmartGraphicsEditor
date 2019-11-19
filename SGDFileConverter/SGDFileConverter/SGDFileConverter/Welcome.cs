using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParseSGD;

namespace SGDFileConverter
{
    public partial class Welcome : Form
    {
        FileOperations sgdReader;
        SmartGraphicEditor sgdEditor = new SmartGraphicEditor();

        public Welcome()
        {
            #region Setup Browser
            browseForSGD.InitialDirectory = @"C:\";
            browseForSGD.DefaultExt = "sgd";
            browseForSGD.Filter = "SGD File (*.sgd)|*.sgd";
            browseForSGD.CheckFileExists = true;
            browseForSGD.CheckPathExists = true;            
            browseForSGD.FileOk += BrowseForSGD_FileOk;
            #endregion

            
            InitializeComponent();
            #region Setup Text Box
            FileLocation_TextBox.TextChanged += FileLocation_TextBox_TextChanged;
            #endregion

        }

        private void FileLocation_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (FileLocation_TextBox.Text.Length > 0)
            {
                EditSGD_Btn.Enabled = true;
            }
            else
            {
                EditSGD_Btn.Enabled = false;
            }
        }

        OpenFileDialog browseForSGD = new OpenFileDialog();

        private void Browse_Btn_Click(object sender, EventArgs e)
        {
            browseForSGD.ShowDialog();
        }

        private void BrowseForSGD_FileOk(object sender, CancelEventArgs e)
        {
            FileLocation_TextBox.Text = browseForSGD.FileName;
        }

        private void EditSGD_Btn_Click(object sender, EventArgs e)
        {
            sgdReader = new FileOperations(FileLocation_TextBox.Text);

            if (sgdReader.ReadFile())
            {
                //Read SGD File

                //Flip to Smart Graphic Editor 
                this.Hide();
                
                sgdEditor.dataToParse = sgdReader.fileContents;
                sgdEditor.StartParsing();
                sgdEditor.Show();
            }
        }
    }
}

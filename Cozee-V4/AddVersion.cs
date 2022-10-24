using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Cozee_V4.UC_HOME;

namespace Cozee_V4
{
    public partial class AddVersion : Form
    {
        public AddVersion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox2.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        string VerPath = AppDomain.CurrentDomain.BaseDirectory + "/Versions/";

        private void button2_Click(object sender, EventArgs e)
        {
            string verFolder = @"Versions";
            // If directory does not exist, create it
            if (!Directory.Exists(verFolder))
            {
                Directory.CreateDirectory(verFolder);
            }

            string verName = textBox1.Text;
            string gamePath = textBox2.Text;

            try
            {
                StreamWriter sw = new StreamWriter("Versions\\" + "versaver.txt", true);
                sw.WriteLine(verName + "," + gamePath);
                sw.Close();
            }
            catch (Exception ee)
            {
                Console.WriteLine("Exception: " + ee.Message);
            }

            this.Close();
            Application.Restart();
        }
    }
}

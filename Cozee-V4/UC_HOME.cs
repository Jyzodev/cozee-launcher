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
using ComboBox = System.Windows.Forms.ComboBox;
using static Cozee_V4.Launch;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace Cozee_V4
{
    public partial class UC_HOME : UserControl
    {
        public static string fnPath = "";
        string userName = "";
        public static string paths;
        public UC_HOME()
        {
            InitializeComponent();

            if (GameSettings.Default.Name != string.Empty)
                this.usernameext.Text = GameSettings.Default.Name;

            if (GameSettings.Default.Name != string.Empty) // Import the saved Username from localappdata
                userName = GameSettings.Default.Name;

            panel1.BackColor = Color.FromArgb(199, 20, 48, 30);

            reloadSelection(verSel);
        }
        private static void reloadSelection(ComboBox cbBox)
        {
            string verFolder = @"Versions";
            if (Directory.Exists(verFolder))
            {
                if (File.Exists("Versions\\versaver.txt"))
                {
                    cbBox.Items.Clear();
                    string[] lineOfContents = File.ReadAllLines(@"Versions\\versaver.txt");
                    foreach (var line in lineOfContents)
                    {
                        int numberOfver = 0;
                        string[] tokens;
                        tokens = line.Split(',');
                        cbBox.Items.Add(tokens[numberOfver]);
                    }
                }
            }
        }

        private void test_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            GameSettings.Default.Name = usernameext.Text;
            GameSettings.Default.Save();

            if(usernameext.Text == String.Empty)
            {
                MessageBox.Show("Please put a valid Username (no spaces)");
            } else
            {
                var line = System.IO.File.ReadLines(@"Versions\\versaver.txt")
                         .FirstOrDefault(x => x.StartsWith(verSel.Text));
                if (line == null)
                    MessageBox.Show("idfk what happened");
                string[] gamepath = line.Split(',');
                if (verSel.TabIndex % 2 == 0)
                {
                    LaunchGame(GameSettings.Default.Name, gamepath[1], verSel.Text);
                }
                else
                { 
                    LaunchGame(GameSettings.Default.Name, gamepath[1], verSel.Text);
                }
            }
            
        }

        private void UC_HOME_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddVersion newVer = new AddVersion();
            newVer.Show();
        }
    }
}

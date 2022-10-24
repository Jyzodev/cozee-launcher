using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cozee_V4
{
    public partial class MainForm : Form
    {

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        Timer t1 = new Timer();
        public MainForm()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(0, 0, 0);

            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        private void add_UControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            add_UControls(new UC_HOME());
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            add_UControls(new UC_SETTINGS());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            add_UControls(new UC_HOME());

            string dir = AppDomain.CurrentDomain.BaseDirectory + @"\Versions";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string discord = "https://discord.gg/G5XQXU6DR2"; // Lien Discord
            Process.Start(new ProcessStartInfo(discord) { UseShellExecute = true }); // Redirection Discord
        }
    }
}

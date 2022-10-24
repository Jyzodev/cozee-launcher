using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cozee_V4
{
    public partial class UC_SETTINGS : UserControl
    {
        public UC_SETTINGS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddVersion verMenu = new AddVersion();
            verMenu.ShowDialog();
        }
    }
}

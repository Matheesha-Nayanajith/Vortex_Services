using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Vortex_Services
{
    public partial class splash_screen : Form
    {
        public splash_screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            guna2ProgressBar1.Increment(2);

            if (guna2ProgressBar1.Value==100)
            {
                timer1.Enabled = false;
                MainForm home = new MainForm();
                home.Show();
                this.Hide();
            }
        }
    }
}

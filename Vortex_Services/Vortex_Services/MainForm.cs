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
    public partial class MainForm : KryptonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //variable used to make form movable
        bool mouseDown;
        private Point offSet;

        private void MouseDown(object sender, MouseEventArgs e)
        {
            offSet.X = e.X;
            offSet.Y = e.Y;
            mouseDown = true;
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offSet.X, currentScreenPos.Y - offSet.Y);
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        private void home_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;

            if (!mainpanel.Controls.Contains(Home.Instance))
            {
                mainpanel.Controls.Add(Home.Instance);
                Home.Instance.Dock = DockStyle.Fill;
                Home.Instance.BringToFront();
            }
            else
                Home.Instance.BringToFront();
        }

        private void checkin_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;

            if (!mainpanel.Controls.Contains(Check_in.Instance))
            {
                mainpanel.Controls.Add(Check_in.Instance);
                Check_in.Instance.Dock = DockStyle.Fill;
                Check_in.Instance.BringToFront();
            }
            else
                Check_in.Instance.BringToFront();
        }

        private void search_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;

            if (!mainpanel.Controls.Contains(Ongoing.Instance))
            {
                mainpanel.Controls.Add(Ongoing.Instance);
                Ongoing.Instance.Dock = DockStyle.Fill;
                Ongoing.Instance.BringToFront();
            }
            else
                Ongoing.Instance.BringToFront();
        }

        private void update_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;

            if (!mainpanel.Controls.Contains(UpdateV.Instance))
            {
                mainpanel.Controls.Add(UpdateV.Instance);
                UpdateV.Instance.Dock = DockStyle.Fill;
                UpdateV.Instance.BringToFront();
            }
            else
                UpdateV.Instance.BringToFront();
        }

        private void vehicle_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;

            if (!mainpanel.Controls.Contains(SearchV.Instance))
            {
                mainpanel.Controls.Add(SearchV.Instance);
                SearchV.Instance.Dock = DockStyle.Fill;
                SearchV.Instance.BringToFront();
            }
            else
                SearchV.Instance.BringToFront();
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;

            if (!mainpanel.Controls.Contains(Check_out.Instance))
            {
                mainpanel.Controls.Add(Check_out.Instance);
                Check_out.Instance.Dock = DockStyle.Fill;
                Check_out.Instance.BringToFront();
            }
            else
                Check_out.Instance.BringToFront();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            if (!mainpanel.Controls.Contains(Home.Instance))
            {
                mainpanel.Controls.Add(Home.Instance);
                Home.Instance.Dock = DockStyle.Fill;
                Home.Instance.BringToFront();
            }
            else
                Home.Instance.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vortex_Services.Models;

namespace Vortex_Services
{
    public partial class SearchV : UserControl
    {
        private static SearchV search;

        public static SearchV Instance
        {
            get
            {
                if (search == null)
                {
                    search = new SearchV();
                }

                return search;
            }

        }

        public SearchV()
        {
            InitializeComponent();
        }
        Methods met = new Methods();
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Git\Vortex_Services\Vortex_Services\Vortex_Services\Vortex.mdf;Integrated Security=True";

        private void reset_Click(object sender, EventArgs e)
        {
            vehicleno.Clear();
            searchview.DataSource = null;
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            met.setVehicleNo(vehicleno.Text);

            met.CheckOut();

            if (met.state == true)
            {
                MessageBox.Show("Successfully Checked Out");
            }
            else
            {
                MessageBox.Show("Check Out Failed");
            }

            met.Delete();
        }
    }
}

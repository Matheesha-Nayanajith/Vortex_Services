using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vortex_Services
{
    public partial class Check_out : UserControl
    {
        private static Check_out check_Out;

        public static Check_out Instance
        {
            get
            {
                if (check_Out == null)
                {
                    check_Out = new Check_out();
                }

                return check_Out;
            }

        }

        public Check_out()
        {
            InitializeComponent();
        }
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Git\Vortex_Services\Vortex_Services\Vortex_Services\Vortex.mdf;Integrated Security=True";

        private void refresh_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string qUpdate = "SELECT * FROM CheckOut";
            SqlCommand cmd = new SqlCommand(qUpdate, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            checkoutview.DataSource = dataTable;


            checkoutview.Refresh();
            checkoutview.Update();
        }

        private void Check_out_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string qUpdate = "SELECT * FROM CheckOut";
            SqlCommand cmd = new SqlCommand(qUpdate, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            checkoutview.DataSource = dataTable;
        }
    }
}

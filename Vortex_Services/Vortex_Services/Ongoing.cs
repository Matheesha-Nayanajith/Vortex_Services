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
    public partial class Ongoing : UserControl
    {
        private static Ongoing ongoing;

        public static Ongoing Instance
        {
            get
            {
                if (ongoing == null)
                {
                    ongoing = new Ongoing();
                }

                return ongoing;
            }

        }

        public Ongoing()
        {
            InitializeComponent();
        }
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Git\Vortex_Services\Vortex_Services\Vortex_Services\Vortex.mdf;Integrated Security=True";
        private void Ongoing_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string qUpdate = "SELECT * FROM CheckIn";
            SqlCommand cmd = new SqlCommand(qUpdate, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            ongoingservices.DataSource = dataTable;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string qUpdate = "SELECT * FROM CheckIn";
            SqlCommand cmd = new SqlCommand(qUpdate, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            ongoingservices.DataSource = dataTable;


            ongoingservices.Update();
            ongoingservices.Refresh();
        }
    }
}

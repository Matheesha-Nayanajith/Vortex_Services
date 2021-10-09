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
    public partial class UpdateV : UserControl
    {
        private static UpdateV update;

        public static UpdateV Instance
        {
            get
            {
                if (update == null)
                {
                    update = new UpdateV();
                }

                return update;
            }

        }

        public UpdateV()
        {
            InitializeComponent();
        }
        Methods met = new Methods();
        private void updatebtn_Click(object sender, EventArgs e)
        {
            met.setVehicleNo(vehicleno.Text);
            met.setName(name.Text);
            met.setPhone(int.Parse(phone.Text));
            met.setAddress(address.Text);
            met.setCheckIn(checkin.Text);
            met.setCheckOut(checkout.Text);
            met.setODO(int.Parse(odono.Text));
            met.setDescription(description.Text);

            met.UpdateVehicle();

            if (met.state == true)
            {
                MessageBox.Show("Successfully Updated");
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }
    }
}

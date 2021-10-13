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
            if (vehicleno == null)
            {
                MessageBox.Show("Input Fields cannot be empty!");
            }
            else
            {
                met.setVehicleNo(vehicleno.Text);
            }

            if (name == null)
            {
                MessageBox.Show("Input Fields cannot be empty!");
            }
            else
            {
                met.setName(name.Text);
            }

            if (phone == null)
            {
                MessageBox.Show("Input Fields cannot be empty!");
            }
            else
            {
                met.setPhone(int.Parse(phone.Text));
            }

            if (address == null)
            {
                MessageBox.Show("Input Fields cannot be empty!");
            }
            else
            {
                met.setAddress(address.Text);
            }

            if (checkin == null)
            {
                MessageBox.Show("Input Fields cannot be empty!");
            }
            else
            {
                met.setCheckIn(checkin.Text);
            }

            if (checkout == null)
            {
                MessageBox.Show("Input Fields cannot be empty!");
            }
            else
            {
                met.setCheckOut(checkout.Text);
            }

            if (odono == null)
            {
                MessageBox.Show("Input Fields cannot be empty!");
            }
            else
            {
                met.setODO(int.Parse(odono.Text));
            }

            if (description == null)
            {
                MessageBox.Show("Input Fields cannot be empty!");
            }
            else
            {
                met.setDescription(description.Text);
            }

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

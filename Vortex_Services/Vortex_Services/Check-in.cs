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
    public partial class Check_in : UserControl
    {
        private static Check_in check_In;

        public static Check_in Instance
        {
            get
            {
                if (check_In == null)
                {
                    check_In = new Check_in();
                }

                return check_In;
            }

        }

        public Check_in()
        {
            InitializeComponent();
        }

        Methods met = new Methods();

        private void add_Click(object sender, EventArgs e)
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

            met.CheckIn();

            if (met.state == true)
            {
                MessageBox.Show("Insertion Success");
            }
            else
            {
                MessageBox.Show("Insertion Failed");
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            vehicleno.Clear();
            name.Clear();
            phone.Clear();
            address.Clear();
            odono.Clear();
            description.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}

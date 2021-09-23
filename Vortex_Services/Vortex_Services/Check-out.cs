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
    }
}

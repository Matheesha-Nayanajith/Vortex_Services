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
    }
}

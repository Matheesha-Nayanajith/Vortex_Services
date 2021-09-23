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
    }
}

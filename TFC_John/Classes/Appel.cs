using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFC_John.Classes
{
    class Appel
    {
        public void APPEL_PANEL(UserControl s, Panel pan)
        {

            s.Dock = DockStyle.Fill;
            pan.Controls.Clear();
            pan.Controls.Add(s);
            pan.Show();

        }
    }
}

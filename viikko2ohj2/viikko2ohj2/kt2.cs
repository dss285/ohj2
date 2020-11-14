using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viikko2ohj2
{
    public partial class kt2 : Form
    {
        public kt2()
        {
            //tbX
            //tbY
            InitializeComponent();
        }
        private void btnVaihda_Click(object sender, EventArgs e)
        {
            int x, y;
            int.TryParse(tbX.Text, out x);
            int.TryParse(tbY.Text, out y);
            if (x < 0)
            {
                x = 0;
            }
            if (y < 0)
            {
                y = 0;
            }
            Point piste = new Point(x, y);
            btnVaihda.Location = piste;
        }
    }
}

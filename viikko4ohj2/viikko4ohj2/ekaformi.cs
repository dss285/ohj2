using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viikko4ohj2
{
    public partial class ekaformi : Form
    {
        public ekaformi()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tokaformi toka = new tokaformi("moi");
            toka.ShowDialog();
        }
    }
}

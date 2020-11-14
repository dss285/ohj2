using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viikko3ohj2
{
    public partial class DataGridHarkka : Form
    {
        public List<Poissaolo> lista = new List<Poissaolo>();
        public DataGridHarkka()
        {
            InitializeComponent();
            string[] syyt = { "sairas", "loma", "koulutus", "työmatka", "muu" };
            cbSyy.DataSource = syyt;
            btnMuokkaa.Enabled = false;
            btnPoista.Enabled = false;
        }

        private void BtnLisaa_Click(object sender, EventArgs e)
        {

        }

        private void BtnMuokkaa_Click(object sender, EventArgs e)
        {
            Poissaolo s = (Poissaolo)dgv.SelectedRows[0].DataBoundItem;
            int index = lista.IndexOf(s);
            s.syy = cbSyy.Text;
            s.alkaa = calKalenteri.SelectionStart;
            s.paattyy = calKalenteri.SelectionEnd;
            lista[index] = s;
            dgv.DataSource = null;
            dgv.DataSource = lista;
        }

        private void BtnPoista_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_Click(object sender, EventArgs e)
        {

        }
    }
}

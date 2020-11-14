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
    public partial class kt4 : Form
    {
        public List<Komponentti> lista = new List<Komponentti>();
        public struct Komponentti
        {
            public string nimi, arvo, sijainti;
            public Boolean toiminnassa;
            public string Nimi
            {
                get
                {
                    return nimi;
                }
            }
            public string Arvo
            {
                get
                {
                    return arvo;
                }
            }
            public string Sijainti
            {
                get
                {
                    return sijainti;
                }
            }
            public string Toiminnassa
            {
                get
                {
                    if(toiminnassa)
                    {
                        return "Toiminnassa";
                    } else
                    {
                        return "Ei Toiminnassa";
                    }
                }
            }
        }
        public kt4()
        {
            InitializeComponent();
            cbSijainti.Items.Add("Ulkona");
            cbSijainti.Items.Add("Sisällä");
            // lämpötila, kosteus, PH, tuulen nopeus
            cbArvo.Items.Add("Lämpötila");
            cbArvo.Items.Add("Kosteus");
            cbArvo.Items.Add("PH");
            cbArvo.Items.Add("Tuulen nopeus");
        }

        private void BtnVie_Click(object sender, EventArgs e)
        {
            Komponentti komp;
            komp.nimi = tbNimi.Text;
            komp.sijainti = cbSijainti.GetItemText(cbSijainti.SelectedItem);
            komp.arvo = cbArvo.GetItemText(cbArvo.SelectedItem);
            komp.toiminnassa = checkToiminnassa.Checked;
            lista.Add(komp);
            dgvKomponentit.DataSource = null;
            dgvKomponentit.DataSource = lista;
        }
    }
}

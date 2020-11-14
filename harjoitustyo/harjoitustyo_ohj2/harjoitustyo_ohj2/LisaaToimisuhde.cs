using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harjoitustyo_ohj2
{
    public partial class LisaaToimisuhde : Form
    {
        public Paaikkuna paaikkuna;
        public int id;
        public LisaaToimisuhde(Paaikkuna paaikkuna, int id)
        {
            /*
             * 
             * Lisätään toimisuhde henkilöön 'id', joka on indeksi henkilölistaan.
             * 
             */
            InitializeComponent();
            this.paaikkuna = paaikkuna;
            this.id = id;
            datetimePaattyy.Value = DateTime.Today.AddDays(+1);
        }

        private void checkToistaiseksi_CheckedChanged(object sender, EventArgs e)
        {
            /*
             * tarkistetaan onko checkbox checkattu, ja enabletaan päättymispäivä
             * (eli toistaiseksi voimassa oleva vai ei)
             */
            if(checkToistaiseksi.Checked)
            {
                datetimePaattyy.Enabled = false;
            } else
            {
                datetimePaattyy.Enabled = true;
            }
        }

        private void btnLisaaToimisuhde_Click(object sender, EventArgs e)
        {
            /*
             * 
             * Lisätään toimisuhde ja lokirivi lokilistaan
             * 
             */
            Toimisuhde t;
            t.yksikko = tbYksikko.Text;
            t.nimike = tbNimike.Text;
            t.alkamispaiva = datetimeAlkaa.Value.ToString("dd/MM/yyyy");
            if(!checkToistaiseksi.Checked)
            {
                t.paattymispaiva = datetimePaattyy.Value.ToString("dd/MM/yyyy");
            } else
            {
                t.paattymispaiva = "Toistaiseksi voimassa";
            }

            LokiRivi lokirivi;
            lokirivi.kuka = Environment.UserName;
            lokirivi.tietotyyppi = "Toimisuhteen lisäys";
            lokirivi.tieto = t.yksikko + ": "+t.nimike;
            lokirivi.milloin = DateTime.Now;

            this.paaikkuna.henkilot[id].toimisuhteet.Add(t);
            this.paaikkuna.paivita();
            this.paaikkuna.loki.Add(lokirivi);
            this.Close();
        }
    }
}

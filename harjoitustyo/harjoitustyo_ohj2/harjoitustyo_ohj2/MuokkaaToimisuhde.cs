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
    public partial class MuokkaaToimisuhde : Form
    {
        public Paaikkuna paaikkuna;
        public int idh, idt;
        public MuokkaaToimisuhde(Paaikkuna paaikkuna, int idh, int idt)
        {
            /*
             * 
             *  Otetaan pääikkuna, ja kaksi idtä, jotka kertovat henkilön ja toimisuhteen jota muokataan.
             * 
             */
            InitializeComponent();
            this.paaikkuna = paaikkuna;
            Toimisuhde t = this.paaikkuna.henkilot[idh].toimisuhteet[idt];
            this.idh = idh;
            this.idt = idt;
            tbYksikko.Text = t.yksikko;
            tbNimike.Text = t.nimike;
            datetimeAlkaa.Value = DateTime.Parse(t.alkamispaiva);
            if(t.paattymispaiva.Equals("Toistaiseksi voimassa"))
            {
                checkToistaiseksi.Checked = true;
            } else
            {
                datetimePaattyy.Value = DateTime.Parse(t.paattymispaiva);
            }
        }
        private void checkToistaiseksi_CheckedChanged(object sender, EventArgs e)
        {
            /*
             * Mikäli on checkboxi checkattu, niin 
             */
            if (checkToistaiseksi.Checked)
            {
                datetimePaattyy.Enabled = false;
            }
            else
            {
                datetimePaattyy.Enabled = true;
            }
        }

        private void btnMuokkaaToimisuhde_Click(object sender, EventArgs e)
        {
            /*
             * 
             *  Muokataan toimisuhdetta, laitetaan kaikki arvot toimisuhteeseen.
             *  Kirjoitetaan lokiin tieto tästä.
             * 
             */
            Toimisuhde t;
            t.yksikko = tbYksikko.Text;
            t.nimike = tbNimike.Text;
            t.alkamispaiva = datetimeAlkaa.Value.ToString("dd/MM/yyyy");
            if (!checkToistaiseksi.Checked)
            {
                t.paattymispaiva = datetimePaattyy.Value.ToString("dd/MM/yyyy");
            }
            else
            {
                t.paattymispaiva = "Toistaiseksi voimassa";
            }
            LokiRivi lokirivi;
            lokirivi.kuka = Environment.UserName;
            lokirivi.tietotyyppi = "Toimisuhteen muokkaus";
            lokirivi.tieto = "Henkilö: "+ this.paaikkuna.henkilot[idh].kutsumanimi+" " + this.paaikkuna.henkilot[idh].sukunimi + "    Yksikkö: "+t.yksikko + "    Nimike: " + t.nimike;
            lokirivi.milloin = DateTime.Now;

            this.paaikkuna.henkilot[idh].toimisuhteet[idt] = t;
            this.paaikkuna.paivita();
            this.paaikkuna.loki.Add(lokirivi);
            this.Close();
        }
    }
}

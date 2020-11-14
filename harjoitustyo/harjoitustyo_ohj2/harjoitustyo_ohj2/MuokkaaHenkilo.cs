using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harjoitustyo_ohj2
{
    public partial class MuokkaaHenkilo : Form
    {
        public Paaikkuna paaikkuna;
        public int id;
        public MuokkaaHenkilo(Paaikkuna paaikkuna, int id)
        {
            /*
             * Muokataan henkilöä 'id'
             * id on henkilöt listan indeksi
             * 
             * 
             */
            InitializeComponent();
            this.id = id;
            this.paaikkuna = paaikkuna;
            Henkilo h = this.paaikkuna.henkilot[id];
            tbPostinumero.KeyPress += this.paaikkuna.Postinumero_KeyPress;

            tbEtunimet.Text = String.Join(" ", h.etunimet);

            cbKutsumanimi.DataSource = h.etunimet;
            cbKutsumanimi.SelectedItem = h.kutsumanimi;

            tbSukunimi.Text = h.sukunimi;

            tbHetu.Text = h.henkilotunnus;
            
            tbPostinumero.Text = h.postinumero;
            tbPostitoimipaikka.Text = h.postitoimipaikka;

            tbKatuosoite.Text = h.katuosoite;
        }
        private void tbHetu_Validating(object sender, CancelEventArgs e)
        {
            /*
             *  tarkistetaan henkilötunnus
             */
            if (tbHetu.Text.Length == 11)
            {
                /*
                 * tarkistetaan että on oikeat tiedot regexin avulla
                 * Patterni menee näin:
                 * Matchaa ensimmäiset 6 numeroa, sitten jonkin kolmesta välimerkistä, ja sitten kolme numeroa. Viimeiseksi tarkistusmerkki
                 * tämä tarkastetaan tarkistaHETU funktiossa
                 */
                bool error = true;
                Regex rx = new Regex(@"\d{6}(\-|\+|A)\d{3}\w");
                Match match = rx.Match(tbHetu.Text);
                if (match.Success)
                {
                    bool isvalid = this.paaikkuna.tarkistaHETU(tbHetu.Text);
                    if (isvalid)
                    {
                        error = false;
                    }
                }
                if (error)
                {
                    e.Cancel = true;
                    tbHetu.SelectAll();
                    errorprovider.SetError(tbHetu, "Vääränlainen henkilötunnus!");
                }
            }
            else
            {
                e.Cancel = true;
                tbHetu.SelectAll();
                errorprovider.SetError(tbHetu, "Vääränlainen henkilötunnus!");
            }
        }
        private void tbHetu_Validated(object sender, EventArgs e)
        {
            errorprovider.SetError(tbHetu, "");
        }
        private void btnLisaaHenkilo_Click(object sender, EventArgs e)
        {
            /*
             * Lisätään henkilö listaan
             * Lisätään lokirivi lokit listaan
             */
            Henkilo henkilo = this.paaikkuna.henkilot[this.id];
            henkilo.kutsumanimi = cbKutsumanimi.Text;
            henkilo.sukunimi = tbSukunimi.Text;
            henkilo.postinumero = tbPostinumero.Text;
            henkilo.postitoimipaikka = tbPostitoimipaikka.Text;
            henkilo.katuosoite = tbKatuosoite.Text;

            paaikkuna.henkilot[id] = henkilo;
            if (!this.paaikkuna.ehdotukset.ContainsKey(tbPostinumero.Text.Substring(0,2))) {
                this.paaikkuna.ehdotukset.Add(tbPostinumero.Text.Substring(0, 2), tbPostitoimipaikka.Text);
            }

            LokiRivi lokirivi;
            lokirivi.kuka = Environment.UserName;
            lokirivi.tietotyyppi = "Henkilön muokkaus";
            lokirivi.tieto = henkilo.henkilotunnus;
            lokirivi.milloin = DateTime.Now;
            paaikkuna.loki.Add(lokirivi);
            paaikkuna.paivita();
            this.Close();
        }

        private void tbPostinumero_TextChanged(object sender, EventArgs e)
        {
            /*
             * tarkistaa ensimmäisen kahden merkin perusteella ja laittaa tekstiksi ehdotuksen, mikäli tekstikenttä on tyhkä
             * 
             * olisi voinut tehdä autocompletella jollakin tavalla varmaankin, en lähtenyt vielä siihen, mahdollisesti jos jatkan tätä projektia
             * yksikseni joskus niin sitten
             */
            if(tbPostinumero.TextLength>=2)
            {
                if(this.paaikkuna.ehdotukset.ContainsKey(tbPostinumero.Text.Substring(0,2)))
                {
                    if (tbPostitoimipaikka.TextLength == 0)
                    {
                        tbPostitoimipaikka.Text = this.paaikkuna.ehdotukset[tbPostinumero.Text.Substring(0, 2)];
                    }
                }
            }
        }
    }
}

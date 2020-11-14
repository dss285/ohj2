using System;
using System.Text.RegularExpressions;
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
    public partial class LisaaHenkilo : Form
    {
        public Paaikkuna paaikkuna;
        public LisaaHenkilo(Paaikkuna paaikkuna)
        {
            InitializeComponent();
            this.paaikkuna = paaikkuna;
            tbPostinumero.KeyPress += this.paaikkuna.Postinumero_KeyPress;
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
                if(match.Success)
                {
                    bool isvalid = this.paaikkuna.tarkistaHETU(tbHetu.Text);
                    if(isvalid)
                    {
                        error = false;
                    }
                } 
                if(error)
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
             * 
             * Lisää henkilön henkilöt listaan, joka on pääikkunassa
             * Lisää lokirivin lokiin.
             */
            Henkilo henkilo;
            henkilo.etunimet = tbEtunimet.Text.Split(new char[0]);
            henkilo.kutsumanimi = cbKutsumanimi.Text;
            henkilo.sukunimi = tbSukunimi.Text;
            henkilo.henkilotunnus = tbHetu.Text;
            henkilo.katuosoite = tbKatuosoite.Text;
            henkilo.postinumero = tbPostinumero.Text;
            henkilo.postitoimipaikka = tbPostitoimipaikka.Text;
            henkilo.toimisuhteet = new List<Toimisuhde>();

            LokiRivi lokirivi;
            lokirivi.kuka = Environment.UserName;
            lokirivi.tietotyyppi = "Henkilön lisäys";
            lokirivi.tieto = henkilo.henkilotunnus;
            lokirivi.milloin = DateTime.Now;
            if (!this.paaikkuna.ehdotukset.ContainsKey(tbPostinumero.Text.Substring(0, 2)))
            {
                this.paaikkuna.ehdotukset.Add(tbPostinumero.Text.Substring(0, 2), tbPostitoimipaikka.Text);
            }
            this.paaikkuna.loki.Add(lokirivi);
            this.paaikkuna.henkilot.Add(henkilo);
            this.paaikkuna.paivita();
            this.Close();
        }

        private void tbEtunimet_Leave(object sender, EventArgs e)
        {
            /*
             *  lisätään kaikki etunimet comboboxiin
             */
            string[] etunimet = tbEtunimet.Text.Split(new char[0]);
            cbKutsumanimi.DataSource = etunimet;
        }
        private void tbPostinumero_TextChanged(object sender, EventArgs e)
        {
            /*
             * tarkistaa ensimmäisen kahden merkin perusteella ja laittaa tekstiksi ehdotuksen, mikäli tekstikenttä on tyhkä
             * 
             * olisi voinut tehdä autocompletella jollakin tavalla varmaankin, taikka muulla samanlaisella
             * , en lähtenyt vielä siihen, koska halusin tehdä tämän ns. nopeasti alta niin pääsee joulun viettoon
             */
            if (tbPostinumero.TextLength >= 2)
            {
                if (this.paaikkuna.ehdotukset.ContainsKey(tbPostinumero.Text.Substring(0, 2)))
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

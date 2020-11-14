using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
/* Tommi Puurunen
 * Harjoitustyö Ohjelmointi 2
 * ETB19SP
 * 
 * 
 * 
 * 
 * 
 * Tajusin sen jälkeen kun olin jo tehnyt suurimman osan, että oisin voinut käyttää pari konstruktoria enemmän, 
 * niin ei olisi tarvinnut tehdä kuin 1 tiedosto muokkaamiselle ja lisäämiselle per toimisuhde jne.
 * 
 * */
namespace harjoitustyo_ohj2
{
    public partial class Paaikkuna : Form
    {
        public List<Henkilo> henkilot = new List<Henkilo>();
        public List<LokiRivi> loki = new List<LokiRivi>();
        public Dictionary<int, char> tarkistusmerkit = new Dictionary<int, char>();
        public Dictionary<string, string> ehdotukset = new Dictionary<string, string>();
        public Paaikkuna()
        {
            /*
            * 
            * Alustetaan ikkuna ja katsotaan onko loki.txt tiedosto jo olemassa, 
            * niin voidaan ottaa siitä loki suoraan ohjelmaan
            * (Tämä on käyttäjän Documents kansiossa)
            * Mahdollisesti tallennukseen jotain muutakin kun vain tallenna nappi (?)
            */
            InitializeComponent();
            lisaaTarkistusmerkit(tarkistusmerkit);
            lblHenkilo.Text = "";
            dgvHenkilot.DataSource = null;

            string foldertoopen = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string fullpath = foldertoopen + "/loki.txt";
            if(File.Exists(fullpath))
            {
                string[] lines = File.ReadAllLines(fullpath);
                foreach(string line in lines)
                {
                    LokiRivi lr = new LokiRivi();
                    if (line.Contains('\t')&&line.Contains(':')) {
                        lr.stringToStruct(line);
                        loki.Add(lr);
                    }
                }
            }

        }


        private void btnAvaaloki_Click(object sender, EventArgs e)
        {
            /*
             * avataan Loki ikkuna
             */
            Loki ikkuna = new Loki(loki);
            ikkuna.ShowDialog();
        }
        private void btnTallennaLoki_Click(object sender, EventArgs e)
        {
            /*
             * 
             * Tallentaa lokin käyttäjän Documents kansioon
             * 
             */
            string foldertosave = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string fullpath = foldertosave + "/loki.txt";
            using (StreamWriter sw = new StreamWriter(fullpath))
            {
                foreach (LokiRivi lr in loki)
                {
                    sw.WriteLine(lr.ToString());
                }
            }
            MessageBox.Show("Loki tallennettu\n" + fullpath, "Lokin tallennus", MessageBoxButtons.OK);
        }

        private void btnLisaaHenkilo_Click(object sender, EventArgs e)
        {
            /*
             *  Avataan henkilön lisäys ikkuna
             * 
             */
            LisaaHenkilo ikkuna = new LisaaHenkilo(this);
            ikkuna.ShowDialog();
        }

        private void btnMuokkaaHenkilo_Click(object sender, EventArgs e)
        {
            /*
             * avaa muokkaahenkilö ikkunan
             */
            if (dgvHenkilot.SelectedRows.Count > 0)
            {
                Henkilo item = (Henkilo)dgvHenkilot.SelectedRows[0].DataBoundItem;
                int row = henkilot.FindIndex(x => x.henkilotunnus == item.henkilotunnus);

                MuokkaaHenkilo ikkuna = new MuokkaaHenkilo(this, row);
                ikkuna.ShowDialog();
            }
            else
            {
                paivita();
            }
        }

        private void btnPoistaHenkilo_Click(object sender, EventArgs e)
        {
            /*
             *  
             * Poistetaan henki
             * 
             */
            DialogResult dr = MessageBox.Show("Haluatko poistaa tämän henkilön ?", "Henkilön poisto", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (dgvHenkilot.SelectedRows.Count > 0)
                {
                    Henkilo item = (Henkilo)dgvHenkilot.SelectedRows[0].DataBoundItem;
                    int row = henkilot.FindIndex(x => x.henkilotunnus == item.henkilotunnus);
                    henkilot.RemoveAt(row);
                    paivita();
                }
            }
        }

        private void btnLisaaToimisuhde_Click(object sender, EventArgs e)
        {
            /*
             * 
             *  avaa lisää toimisuhde ikkunan
             */
            Henkilo item = (Henkilo)dgvHenkilot.SelectedRows[0].DataBoundItem;
            int row = henkilot.FindIndex(x => x.henkilotunnus == item.henkilotunnus);

            LisaaToimisuhde ikkuna = new LisaaToimisuhde(this, row);
            ikkuna.ShowDialog();
        }

        private void btnMuokkaaToimisuhde_Click(object sender, EventArgs e)
        {
            /*
             * avaa muokkaa toimisuhde ikkunan
             */
            Henkilo item = (Henkilo)dgvHenkilot.SelectedRows[0].DataBoundItem;
            int row = henkilot.FindIndex(x => x.henkilotunnus == item.henkilotunnus);
            Toimisuhde item_2 = (Toimisuhde)dgvToimisuhteet.SelectedRows[0].DataBoundItem;
            int row_2 = item.toimisuhteet.FindIndex(x => x.nimike == item_2.nimike);
            if (dgvToimisuhteet.SelectedRows.Count > 0 && dgvHenkilot.SelectedRows.Count > 0)
            {
                MuokkaaToimisuhde ikkuna = new MuokkaaToimisuhde(this, row, row_2);
                ikkuna.ShowDialog();
            }
        }

        private void btnPoistaToimisuhde_Click(object sender, EventArgs e)
        {
            /*
             * Poistetaan toimisuhde ja kysytään käyttäjältä varmistus 
             * 
             */
            DialogResult dr = MessageBox.Show("Haluatko poistaa tämän toimisuhteen ?", "Toimisuhteen poisto", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (dgvHenkilot.SelectedRows.Count > 0)
                {
                    if (dgvToimisuhteet.SelectedRows.Count > 0)
                    {
                        Henkilo item = (Henkilo)dgvHenkilot.SelectedRows[0].DataBoundItem;
                        int row = henkilot.FindIndex(x => x.henkilotunnus == item.henkilotunnus);
                        Toimisuhde item_2 = (Toimisuhde)dgvToimisuhteet.SelectedRows[0].DataBoundItem;
                        int row_2 = item.toimisuhteet.FindIndex(x => x.nimike == item_2.nimike);
                        henkilot[row].toimisuhteet.RemoveAt(row_2);
                        paivita();
                    }
                }
            }
        }
        public void Postinumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
             *  sallitaan vain numerot ja backspacejne
             */
            if((char.IsControl(e.KeyChar))|(char.IsNumber(e.KeyChar)))
            {
                e.Handled = false;
            } else
            {
                e.Handled = true;
            }
        }




        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = openfile.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    if (File.Exists(openfile.FileName))
                    {
                        if (new FileInfo(openfile.FileName).Length > 0) {
                            string ext = Path.GetExtension(openfile.FileName);
                            if (ext.ToLower().Equals(".dat"))
                            {
                                using (var file = File.OpenRead(openfile.FileName))
                                {
                                    var reader = new BinaryFormatter();
                                    henkilot = (List<Henkilo>)reader.Deserialize(file);
                                }
                            }
                            else if (ext.ToLower().Equals(".json"))
                            {
                                using (StreamReader r = new StreamReader(openfile.FileName))
                                {
                                    string json = r.ReadToEnd();
                                    henkilot = JsonConvert.DeserializeObject<List<Henkilo>>(json);
                                }
                            }
                            else if (ext.ToLower().Equals(".xml"))
                            {
                                using (StreamReader r = new StreamReader(openfile.FileName))
                                {
                                    XmlSerializer ser = new XmlSerializer(typeof(List<Henkilo>));
                                    object obj = ser.Deserialize(r);
                                    henkilot = (List<Henkilo>)obj;
                                }
                            }
                            paivita();
                        } else
                        {
                            MessageBox.Show("Tiedosto on tyhjä, tarkista tiedosto", "Virhe", MessageBoxButtons.OK);
                        }
                    }
                    
                }
            } catch(Exception)
            {
                MessageBox.Show("Tiedosto on virheellinen, tarkista tiedosto","Virhe",MessageBoxButtons.OK);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = savefile.ShowDialog();
            if(dr == DialogResult.OK)
            {
                if (savefile.FileName.EndsWith(".dat")) {
                    using (FileStream file = File.OpenWrite(savefile.FileName))
                    {
                        BinaryFormatter writer = new BinaryFormatter();
                        writer.Serialize(file, henkilot);
                    }
                }
                else if (savefile.FileName.EndsWith(".json"))
                {
                    using (StreamWriter w = new StreamWriter(savefile.FileName))
                    {
                        string json = JsonConvert.SerializeObject(henkilot);
                        w.Write(json);
                    }
                }
                else if (savefile.FileName.EndsWith(".xml"))
                {
                    using (StreamWriter w = new StreamWriter(savefile.FileName))
                    {
                        XmlSerializer serializer = new XmlSerializer(henkilot.GetType());
                        serializer.Serialize(w, henkilot);
                    }
                }
            }
        }

        private void dgvHenkilot_SelectionChanged(object sender, EventArgs e)
        {
            /*
             * 
             * Mikäli jotain on valittuna, niin salli napit, ja mikäli taas ei niin, laita enable=false
             * 
             * 
             */
            if (dgvHenkilot.SelectedRows.Count > 0) {
                Henkilo item = (Henkilo)dgvHenkilot.SelectedRows[0].DataBoundItem;
                Henkilo row = henkilot.Find(x => x.henkilotunnus == item.henkilotunnus);
                lblHenkilo.Text = row.kutsumanimi + " " + row.sukunimi + " valittu.";

                btnMuokkaaHenkilo.Enabled = true;
                btnPoistaHenkilo.Enabled = true;
                btnLisaaToimisuhde.Enabled = true;

                dgvToimisuhteet.DataSource = null;
                if (row.toimisuhteet.Count > 0)
                {
                    dgvToimisuhteet.DataSource = row.toimisuhteet;
                }

            } else
            {
                lblHenkilo.Text = "";
                btnMuokkaaHenkilo.Enabled = false;
                btnLisaaToimisuhde.Enabled = false;
                btnPoistaHenkilo.Enabled = false;
            }
        }







        private void dgvToimisuhteet_SelectionChanged(object sender, EventArgs e)
        {
            /*
             * 
             * Laittaa napit käytettäväksi tai pois, riippuen onko valittuna mitään.
             *
             */
            if(dgvToimisuhteet.SelectedRows.Count > 0)
            {
                btnMuokkaaToimisuhde.Enabled = true;
                btnPoistaToimisuhde.Enabled = true;
            } else
            {
                btnMuokkaaToimisuhde.Enabled = false;
                btnPoistaToimisuhde.Enabled = false;
            }
        }







        private void dgvHenkilot_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*
             * 
             * 
             *  Järjestellään Kutsumanimi ja Sukunimi sarakkeita [A-Z]
             *  
             *  Melkein kopio esimerkistä, mutta ymmärrän mitä tekee.
             * 
             */
            DataGridView grid = (DataGridView)sender;
            SortOrder so = SortOrder.None;
            SortOrder current = grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection;

            if (current == SortOrder.None || current == SortOrder.Ascending)

            {
                so = SortOrder.Descending;

            }

            else

            {

                so = SortOrder.Ascending;
            }

            string column = grid.Columns[e.ColumnIndex].Name;

            if(column.Equals("Kutsumanimi"))
            {
                if (so == SortOrder.Ascending)

                {

                    dgvHenkilot.DataSource = henkilot.OrderBy(x  => x.kutsumanimi).ToList();

                } 

                else

                {

                    dgvHenkilot.DataSource = henkilot.OrderByDescending(x => x.kutsumanimi).ToList();

                }

            }

            else if(column.Equals("Sukunimi"))
            {

                if (so == SortOrder.Ascending)

                {

                    dgvHenkilot.DataSource = henkilot.OrderBy(x => x.sukunimi).ToList();

                } 
                else
                {

                    dgvHenkilot.DataSource = henkilot.OrderByDescending(x => x.sukunimi).ToList();
                
                }

            } 
            else

            {
                dgvHenkilot.DataSource = henkilot;
            }

            grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = so;
        }
        private void dgvToimisuhteet_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            SortOrder so = SortOrder.None;
            SortOrder current = grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection;
            Henkilo item = (Henkilo)dgvHenkilot.SelectedRows[0].DataBoundItem;
            Henkilo row = henkilot.Find(x => x.henkilotunnus == item.henkilotunnus);

            if (current == SortOrder.None || current == SortOrder.Ascending)

            {
                so = SortOrder.Descending;

            }

            else

            {

                so = SortOrder.Ascending;
            }

            string column = grid.Columns[e.ColumnIndex].Name;

            if (column.Equals("Nimike"))
            {
                if (so == SortOrder.Ascending)

                {

                    dgvToimisuhteet.DataSource = row.toimisuhteet.OrderBy(x => x.nimike).ToList();

                }

                else

                {

                    dgvToimisuhteet.DataSource = row.toimisuhteet.OrderByDescending(x => x.nimike).ToList();

                }

            }
            else

            {
                dgvToimisuhteet.DataSource = row.toimisuhteet;
            }

            grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = so;
        }
        public Dictionary<int, char> lisaaTarkistusmerkit(Dictionary<int, char> dictionary)
        {
            /*
             * otetaan kakki tarkistusmerkit ja laitetaan ne dictionaryyn 
             * (lähinnä pythonin kautta tälläinen ratkaisu, olisi kai voinut käyttää ihan vain pelkkää listaa)
             */
            int i = 0;
            char[] merkit = "0123456789ABCDEFHJKLMNPRSTUVWXY".ToCharArray();
            while (i < merkit.Length)
            {
                dictionary.Add(i, merkit[i]);
                i++;
            }
            return dictionary;
        }
        public void paivita()
        {
            /*
             * 
             *  Päivittää datagridin ja napit, mikäli on valittuna, hyödyllinen funktio
             * 
             */
            dgvHenkilot.DataSource = null;
            dgvHenkilot.DataSource = henkilot;
            if (dgvHenkilot.SelectedRows.Count > 0)
            {
                Henkilo h = (Henkilo)dgvHenkilot.SelectedRows[0].DataBoundItem;
                dgvToimisuhteet.DataSource = null;
                if (h.toimisuhteet.Count > 0)
                {

                    dgvToimisuhteet.DataSource = h.toimisuhteet;
                }
                else
                {
                    btnMuokkaaToimisuhde.Enabled = false;
                    btnPoistaToimisuhde.Enabled = false;
                }
            }
            else
            {
                btnPoistaHenkilo.Enabled = false;
                btnMuokkaaHenkilo.Enabled = false;
            }
        }
        public Boolean tarkistaHETU(string hetu)
        {
            //otetaan hetun eri tiedot eri muuttujiin lähempää tarkistusta varten
            int paiva = int.Parse(hetu.Substring(0, 2));
            int kuukausi = int.Parse(hetu.Substring(2, 2));
            int vuosi = int.Parse(hetu.Substring(4, 2));
            char syntymavuosisata = hetu[6];
            int jarjestys = int.Parse(hetu.Substring(7, 3));
            char tarkistusmerkki = hetu[10];

            int luku = int.Parse(hetu.Substring(0, 6) + hetu.Substring(7, 3));


            //tarkistetaan että on validi
            if (paiva > 0 && paiva < 32)
            {
                if (kuukausi > 0 && kuukausi < 13)
                {
                    if (new[] { '+', '-', 'A' }.Contains(syntymavuosisata))
                    {
                        if (jarjestys >= 2 && jarjestys <= 899)
                        {
                            double tarkistus = (luku / 31.0);
                            tarkistus = tarkistus - Math.Floor(tarkistus);
                            luku = (int)Math.Round(tarkistus * 31);
                            if (char.ToLower(tarkistusmerkki).Equals(char.ToLower(tarkistusmerkit[luku])))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }


    }

}

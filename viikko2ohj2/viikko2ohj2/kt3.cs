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
    public partial class kt3 : Form
    {
        public List<Person> henkilot = new List<Person>();
        public struct Person
        {
            public string firstname, lastname, puhnro, osoite, postinro, postipaikka;

            public DateTime dob;
            public override string ToString()
            {
                return firstname + " " +lastname[0]+"\n";
            }
        }

        public kt3()
        {
            InitializeComponent();
        }

        private void TbPostiNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar))|(char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            } else
            {
                e.Handled = true;
            }
        }

        private void DtpDateOfBirth_Leave(object sender, EventArgs e)
        {
            DateTime now = DateTime.Today.Date;
            DateTime defaultdate = DateTime.Today.AddDays(-1);

            DateTimePicker dtp = (DateTimePicker)sender;
            
            if(dtp.Value.Date >= now)
            {
                dtp.Value = defaultdate;
            }
        }

        private void BtnVie_Click(object sender, EventArgs e)
        {
            Person henkilo = new Person();
            henkilo.firstname = tbFirstName.Text;
            henkilo.lastname = tbLastName.Text;
            henkilo.puhnro = tbPuhNro.Text;
            henkilo.postinro = tbPostiNro.Text;
            henkilo.postipaikka = tbPostiToimipaikka.Text;
            henkilo.osoite = tbOsoite.Text;
            henkilo.dob = dtpDateOfBirth.Value;
            henkilot.Add(henkilo);
            lbHenkilot.DataSource = null;
            lbHenkilot.DataSource = henkilot;
        }

        private void LbHenkilot_Click(object sender, EventArgs e)
        {
            ListBox listbox = lbHenkilot;
            if (listbox.SelectedItem != null)
            {
                Person selecteditem = (Person)listbox.SelectedItem;
                tbFirstName.Text = selecteditem.firstname;
                tbLastName.Text = selecteditem.lastname;
                tbPuhNro.Text = selecteditem.puhnro;
                tbPostiNro.Text = selecteditem.postinro;
                tbPostiToimipaikka.Text = selecteditem.postipaikka;
                dtpDateOfBirth.Value = selecteditem.dob;

                henkilot.Remove(selecteditem);
                lbHenkilot.DataSource = null;
                lbHenkilot.DataSource = henkilot;
            }
        }
    }
}

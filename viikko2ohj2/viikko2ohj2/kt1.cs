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
    public partial class kt1 : Form
    {
        public struct Person
        {
            public string firstname, lastname, 
                dateofbirth, jobtitle, jobstart, jobend;
        }
        public kt1()
        {
            InitializeComponent();
            //tbLastName
            //tbFirstName
            //dtpDateOfBirth
            //cbJobTitle
            //dtpJobStart
            //dtpJobEnd 
            cbJobTitle.Items.Add("Projektityöntekijä");
            cbJobTitle.Items.Add("Suunnittelija");
            cbJobTitle.Items.Add("Asiantuntija");
            cbJobTitle.Items.Add("Johtaja");
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Person henkilo;
            henkilo.firstname = tbFirstName.Text;
            henkilo.lastname = tbLastName.Text;
            henkilo.dateofbirth = dtpDateOfBirth.Text;
            henkilo.jobtitle = cbJobTitle.GetItemText(cbJobTitle.SelectedItem);
            henkilo.jobstart = dtpJobStart.Text;
            henkilo.jobend = dtpJobEnd.Text;
        }
    }
}

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
    /*
     * lukee lokilistan listboxiin
     * 
     * aikalailla siinä, toistaiseksi
     */
    public partial class Loki : Form
    {
        public List<LokiRivi> lista;
        public Loki(List<LokiRivi> loki)
        {
            InitializeComponent();
            lista = loki;
            lbLoki.DataSource = loki;
            
        }
    }
}

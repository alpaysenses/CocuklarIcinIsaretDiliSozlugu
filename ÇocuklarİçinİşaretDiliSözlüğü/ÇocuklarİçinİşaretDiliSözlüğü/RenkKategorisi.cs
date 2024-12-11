using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÇocuklarİçinİşaretDiliSözlüğü
{
    public partial class RenkKategorisi : Form
    {
        public RenkKategorisi()
        {
            InitializeComponent();
        }

        private void btsiyah_Click(object sender, EventArgs e)
        {
            Siyah_İşareti siyah_İşareti = new Siyah_İşareti();
            siyah_İşareti.Show();
        }

        private void btbeyaz_Click(object sender, EventArgs e)
        {
            Beyaz_İşareti beyaz_İşareti = new Beyaz_İşareti();
            beyaz_İşareti.Show();
        }

        private void btpembe_Click(object sender, EventArgs e)
        {
            Pembe_İşareti pembe_İşareti = new Pembe_İşareti();
            pembe_İşareti.Show();
        }

        private void btmor_Click(object sender, EventArgs e)
        {
            Mor_İşareti mor_İşareti = new Mor_İşareti ();
            mor_İşareti.Show ();
        }
    }
}

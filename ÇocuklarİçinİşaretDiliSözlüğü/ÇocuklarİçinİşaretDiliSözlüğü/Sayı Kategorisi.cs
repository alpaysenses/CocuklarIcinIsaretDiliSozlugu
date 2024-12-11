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
    public partial class Sayı_Kategorisi : Form
    {
        public Sayı_Kategorisi()
        {
            InitializeComponent();
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            _6_İşareti _6_İşareti = new _6_İşareti();
            _6_İşareti.Show();
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            _7_İşareti _7_İşareti = new _7_İşareti();
            _7_İşareti.Show();
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            _8_İşareti _8_İşareti = new _8_İşareti();
            _8_İşareti.Show();
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            _9_İşareti _9_İşareti = new _9_İşareti();
            _9_İşareti .Show();
        }
    }
}

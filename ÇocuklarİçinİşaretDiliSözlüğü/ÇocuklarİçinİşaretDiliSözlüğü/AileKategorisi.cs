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
    public partial class AileKategorisi : Form
    {
        public AileKategorisi()
        {
            InitializeComponent();
        }

        private void btanne_Click(object sender, EventArgs e)
        {
            Anne_İşareti anne_İşareti = new Anne_İşareti();
            anne_İşareti.Show();
        }

        private void btbaba_Click(object sender, EventArgs e)
        {
            Baba_İşareti baba_İşareti = new Baba_İşareti();
            baba_İşareti.Show();
        }

        private void btkardeş_Click(object sender, EventArgs e)
        {
            Kardeş_İşareti kardeş_İşareti = new Kardeş_İşareti();
            kardeş_İşareti.Show();
        }

        private void btdede_Click(object sender, EventArgs e)
        {
            Dede_İşareti dede_İşareti = new Dede_İşareti();
            dede_İşareti.Show();
        }
    }
}

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
    public partial class Hayvan_Kategorisi : Form
    {
        public Hayvan_Kategorisi()
        {
            InitializeComponent();
        }

        private void btköpek_Click(object sender, EventArgs e)
        {
            Köpek_İşareti köpek_İşareti = new Köpek_İşareti();
            köpek_İşareti.Show();
        }

        private void bteşşek_Click(object sender, EventArgs e)
        {
            Eşek_İşareti eşek_İşareti = new Eşek_İşareti();
            eşek_İşareti.Show();
        }

        private void bttavuk_Click(object sender, EventArgs e)
        {
            Tavuk_İşareti tavuk_İşareti = new Tavuk_İşareti();
            tavuk_İşareti.Show();
        }

        private void btkuş_Click(object sender, EventArgs e)
        {
            Kuş_İşareti kuş_İşareti = new Kuş_İşareti();
            kuş_İşareti.Show();
        }
    }
}

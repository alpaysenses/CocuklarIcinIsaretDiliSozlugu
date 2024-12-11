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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btaile_Click(object sender, EventArgs e)
        {
            AileKategorisi aileKategorisi = new AileKategorisi();
            aileKategorisi.Show();
        }

        private void btrenk_Click(object sender, EventArgs e)
        {
            RenkKategorisi renkKategorisi = new RenkKategorisi();
            renkKategorisi.Show();
        }

        private void bthayvan_Click(object sender, EventArgs e)
        {
            Hayvan_Kategorisi hayvan_Kategorisi = new Hayvan_Kategorisi();
            hayvan_Kategorisi.Show();
        }

        private void btsayı_Click(object sender, EventArgs e)
        {
            Sayı_Kategorisi sayı_Kategorisi = new Sayı_Kategorisi();
            sayı_Kategorisi.Show();
        }
    }
}

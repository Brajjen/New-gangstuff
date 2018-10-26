using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KortSpelDemo.BryanCaro16B
{
    public partial class speltest : Form
    {
        Kortlek leken = new Kortlek();
        Kortlek kortlek = new Kortlek(true);
        public speltest()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kort ettKort = kortlek.GeKort();
            pictureBox1.Image = ettKort.bild;

            Kort ettKort_två = kortlek.GeKort();
            pictureBox2.Image = ettKort_två.bild;

            Kort ettKort_tre = kortlek.GeKort();
            pictureBox3.Image = ettKort_tre.bild;

            if (ettKort.valor > ettKort_två.valor && ettKort.valor > ettKort_tre.valor)
            {
                MessageBox.Show("kort 1 är störst");
            }

            if (ettKort_två.valor > ettKort.valor && ettKort_två.valor > ettKort_tre.valor)
            {
                MessageBox.Show("kort 2 är störst");
            }

            if (ettKort_tre.valor > ettKort.valor && ettKort_tre.valor > ettKort_två.valor)
            {
                MessageBox.Show("kort 3 är störst");
            }
        }
        
    }
}

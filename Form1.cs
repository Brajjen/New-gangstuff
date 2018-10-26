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
    public partial class Form1 : Form
    {
        Kortlek leken = new Kortlek();
        Kortlek kortlek = new Kortlek(true);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buOK_Click(object sender, EventArgs e)
        {
            Kort ettKort = leken.GeKort();
            tbFarg.Text = ettKort.farg.ToString();
            tbValor.Text = ettKort.valor.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kort ettKort = kortlek.GeKort();
            pictureBox1.Image = ettKort.bild;

            ettKort = kortlek.GeKort();
            pictureBox2.Image = ettKort.bild;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

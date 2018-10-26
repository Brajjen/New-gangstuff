using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace KortSpelDemo.BryanCaro16B
{
    public partial class Blackjack : Form
    {
        Spelare spelare1 = new Spelare("Brajjen");
        Spelare spelare2 = new Spelare("skinnypenis");
        

        Kortlek leken = new Kortlek(true);
        int counter = 0;
        int counter2 = 0;
        public Blackjack()
        {
            InitializeComponent();
        }

        private void Blackjack_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            counter++;
            if (counter == 1)
            {
                Kort ettKort = leken.GeKort();
                pictureBox1.Image = ettKort.bild;
                spelare1.poang += ettKort.valor;
                textBox1.Text = spelare1.poang.ToString();
            }

            if (counter == 2)
            {
                Kort ettKort_två = leken.GeKort();
                pictureBox2.Image = ettKort_två.bild;
                spelare1.poang += ettKort_två.valor;
                textBox1.Text = spelare1.poang.ToString();
                if (spelare1.poang > 21)
                {
                    MessageBox.Show("u suck");
                }
            }

            if (counter == 3)
            {
                Kort ettKort_tre = leken.GeKort();
                pictureBox3.Image = ettKort_tre.bild;
                spelare1.poang += ettKort_tre.valor;
                textBox1.Text = spelare1.poang.ToString();
                if (spelare1.poang > 21)
                {
                    MessageBox.Show("u suck");
                    button1.Enabled = false;
                    button2.Enabled = false;
                }
            }

            if (counter == 4)
            {
                Kort ettKort_fyra = leken.GeKort();
                pictureBox4.Image = ettKort_fyra.bild;
                spelare1.poang += ettKort_fyra.valor;
                textBox1.Text = spelare1.poang.ToString();
                if (spelare1.poang > 21)
                {
                    MessageBox.Show("u suck");
                    button1.Enabled = false;
                    button2.Enabled = false;
                }
            }

            if (counter == 5)
            {
                Kort ettKort_fem = leken.GeKort();
                pictureBox5.Image = ettKort_fem.bild;
                spelare1.poang += ettKort_fem.valor;
                textBox1.Text = spelare1.poang.ToString();
                if (spelare1.poang > 21)
                {
                    MessageBox.Show("u suck");
                    button1.Enabled = false;
                    button2.Enabled = false;
                }
            }



        }

        private void button6_Click(object sender, EventArgs e)
        {

            counter2++;

            if (counter2 == 1)
            {
                Kort ettKort_sex = leken.GeKort();
                pictureBox6.Image = ettKort_sex.bild;
                spelare2.poang += ettKort_sex.valor;
                textBox2.Text = spelare2.poang.ToString();
            }

            if (counter2 == 2)
            {
                Kort ettKort_sju = leken.GeKort();
                pictureBox7.Image = ettKort_sju.bild;
                spelare2.poang += ettKort_sju.valor;
                textBox2.Text = spelare2.poang.ToString();
                if (spelare2.poang > 21)
                {
                    MessageBox.Show("u suck");
                    button6.Enabled = false;
                    button5.Enabled = false;
                }

            }

            if (counter2 == 3)
            {
                Kort ettKort_åtta = leken.GeKort();
                pictureBox8.Image = ettKort_åtta.bild;
                spelare2.poang += ettKort_åtta.valor;
                textBox2.Text = spelare2.poang.ToString();
                if (spelare2.poang > 21)
                {
                    MessageBox.Show("u suck");
                    button6.Enabled = false;
                    button5.Enabled = false;
                }
            }

            if (counter2 == 4)
            {
                Kort ettKort_nio = leken.GeKort();
                pictureBox9.Image = ettKort_nio.bild;
                spelare2.poang += ettKort_nio.valor;
                textBox2.Text = spelare2.poang.ToString();
                if (spelare2.poang > 21)
                {
                    MessageBox.Show("u suck");
                    button6.Enabled = false;
                    button5.Enabled = false;
                }
            }

            if (counter2 == 5)
            {
                Kort ettKort_tio = leken.GeKort();
                pictureBox10.Image = ettKort_tio.bild;
                spelare2.poang += ettKort_tio.valor;
                textBox2.Text = spelare2.poang.ToString();
                if (spelare2.poang > 21)
                {
                    MessageBox.Show("u suck");
                    button6.Enabled = false;
                    button5.Enabled = false;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (spelare1.poang == 21)
            {
                MessageBox.Show("wow u did it");
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                MessageBox.Show("pray 2 god");
                button1.Enabled = false;
                button2.Enabled = false;
            }
                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {

                if (spelare1.poang == 21)
                {
                    MessageBox.Show("wow u did it");
                    button6.Enabled = false;
                    button5.Enabled = false;
                }
                else
                {
                    MessageBox.Show("pray 2 god");
                    button6.Enabled = false;
                    button5.Enabled = false;
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (spelare1.poang > spelare2.poang)
            {
                MessageBox.Show("blajen u win");
            }
            else
            {
                MessageBox.Show("skinnypenis has a smal penis");
            }
        }
    }
}

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
    public partial class DynamiskDemo : Form
    {
        Spelare spelare1 = new Spelare("Bryan");
        Spelare spelare2 = new Spelare("skinnypenis");

        Kortlek leken = new Kortlek(true);
        int counter = 0;
        public DynamiskDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            counter++;
            if (counter == 1)
            {
                Kort ettKort = leken.GeKort();
                pictureBox1.Image = ettKort.bild;
            }

            if (counter == 2)
            {
                Kort ettKort_två = leken.GeKort();
                pictureBox2.Image = ettKort_två.bild;
            }

            if (counter == 3)
            {
                Kort ettKort_tre = leken.GeKort();
                pictureBox3.Image = ettKort_tre.bild;
            }

        }
                               
            private void button2_Click(object sender, EventArgs e)
            {
            Kort ettKort = leken.GeKort();
            spelare2.taEmotKort(ettKort);
            pictureBox4.Image = ettKort.bild;
            pictureBox5.Image = ettKort.bild;
            pictureBox6.Image = ettKort.bild;
            }
        
           
           
        




        
        
          

        
    }
}

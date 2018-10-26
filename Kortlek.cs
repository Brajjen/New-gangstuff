using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace KortSpelDemo.BryanCaro16B
{
    class Kortlek
    {
        private LinkedList<Kort> hogen = new LinkedList<Kort>();
        private List<Image> kortbilder = new List<Image>();

        //konstruktor för kortlek.
        public Kortlek()
        {
            //skapar 52 nya kort.
            for (int f = 0; f <= 3; f++)
            {
                for (int v = 2; v <= 14; v++)
                {
                    hogen.AddLast(new Kort(f, v));
                }
            }
            blanda();
        }

        //konstruktor för kortlek.
        public Kortlek(bool medBild)
        {
            int bildNr = 0;
            hamtaBilder(); //läs in bilderna till en lista.

            //skapar 52 nya kort med bilder.
            for (int f = 0; f <= 3; f++)
                for (int v = 2; v <= 14; v++)
                {
                    Image b = kortbilder.ElementAt(bildNr); // hämta en bild från bildlistan.
                    b.Tag = f.ToString() + v.ToString();

                    hogen.AddLast(new Kort(f, v, b)); // skapar ett nytt kort.
                    bildNr++; //öka bildnummer med ett.
                }
            blanda(); //Blanda kortleken
        }

        // Protperty aktuellt antal kort som finns i kortleken.
        public int antKort
        {
            get { return hogen.Count; }
        }


        public void blanda()
        {
            List<Kort> tmpLek = new List<Kort>();
            short slump;
            Random rnd = new Random();

            for (int i = hogen.Count() - 1; i >= 0; i--)
            {
                slump = (short)rnd.Next(0, i);
                tmpLek.Add(hogen.ElementAt(slump));
                hogen.Remove(hogen.ElementAt(slump));
            }
            hogen.Clear();
            foreach (Kort tmpKort in tmpLek)
                hogen.AddLast(tmpKort);    

        }

        public Kort GeKort()
        {
            Kort tempKort;
            tempKort = hogen.ElementAt(0);
            hogen.RemoveFirst();
            return tempKort;

        }

        //hämtar bilder till korten.
        private void hamtaBilder()
        {
            DirectoryInfo sokvag = new DirectoryInfo("kortbilder"); // sökväg till bilderna.
            FileInfo[] bildArr = sokvag.GetFiles("*.png", SearchOption.TopDirectoryOnly);

            //läser in bilderna till listan
            foreach (FileInfo bild in bildArr)
                kortbilder.Add(Image.FromFile(bild.FullName));
        }
    }

}

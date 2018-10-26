using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.Serialization;

namespace KortSpelDemo.BryanCaro16B
{
    [Serializable]
    class Spelare
    {
         private string _namn;
         private int _poang;
         private List<Kort> _hand = new List<Kort>(); //spelarens alla kort i en lista.
   
         //property för namn
         public string namn
         {
            get { return _namn; }
         }

        //propert för poäng
        public int poang
        {
            get { return _poang; }
            set { _poang = value; }
        }

        //property för hand
        public List<Kort> hand
        {
            get { return _hand; }
        }

        //konstruktor
        public Spelare(string n)
        {
            _namn = n;
        }

        //Ger ett kort från spelarens hand
        public Kort GeKort(int pos)
        {
            Kort tmpkort;
            tmpkort = _hand.ElementAt(pos); //kopiera kortet.
            _hand.RemoveAt(pos); // Ta bort kortet från splarens hand.
            return tmpkort; // Returnera kortet som ska ges ut.
        }

        // Ta mot ett kort till spelarens hand
        public void taEmotKort(Kort k)
        {
            _hand.Add(k);
        }


        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KortSpelDemo.BryanCaro16B
{
    class Kort
    {
        // Egen datatyp
        public enum kortfarg
        {
            Hjärter = 0,
            Klöver = 1,
            Ruter = 2,
            Spader = 3
        }
        private int _valor;
        private kortfarg _farg;
        private Image _bild;

        public int valor
        {
            get { return _valor; }
        }

        public kortfarg farg
        {
            get { return _farg; }
        }

        //property för bild
        public Image bild
        {
            get { return _bild; }
        }
            
        //konstruktor färg/valor
        public Kort(int f, int v)
        {
            _farg = (kortfarg)f;
            _valor = v;
        }

        //konstruktor bild
        public Kort(int f, int v, Image b)
        {
            _farg = (kortfarg)f;
            _valor = v;
            _bild = b;
        }

        
    
    }
}

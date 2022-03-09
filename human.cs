using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_stuff
{
    public abstract class Inimene
    {
        //svoistva
        string eesnimi;
        string perenimi;
        int vanus;
        string staatus;
        int kaal;
        string staatuskaal;
        Emakeel emakeel;
        Sugu sugu;

        
        public Inimene() { } //konstruktor

        public Inimene(string Eesnimi, string Perenimi) // int Vanus, Emakeel emakeel, int Kaal)
        {
            eesnimi = Eesnimi;
            perenimi = Perenimi;
            //vanus = Vanus;
            //this.emakeel = emakeel;
            //kaal = Kaal;
            //staatus = staatus;
        }
        public Emakeel Emakeel
        {
            get { return emakeel; }
        }
        public Sugu Sugu
        {
            get { return sugu; }
        }
        public string Eesnimi
        {
            set
            {
                if (eesnimi == null) eesnimi = value;
            }
            get { return eesnimi; }
        }
        public string Perenimi
        {
            set
            {
                if (perenimi == null) perenimi = value;
            }
            get { return perenimi; }
        }
        public int Vanus
        {
            set
            { vanus = value;
                if (vanus<7)
                {
                    staatus = "väike laps";
                }
                else if (vanus<17)
                {
                    staatus = "kooli laps";
                }
                else if (vanus < 65)
                {
                    staatus = "tööline inimine";
                }
                else
                {
                    staatus = "senior";
                }
            }
            get { return vanus; }
        }
        public string Staatus
        {
            get {
                var staatus = "";
                if (vanus < 7)
                { staatus = "väike laps"; }
                else if (vanus < 17)
                { staatus = "kooli laps"; }
                else if (vanus < 65)
                { staatus = "tööline inimine"; }
                else
                { staatus = "senior"; }
                return staatus;
                
            }
        }       
        public string Staatuskaal
        {
            get
            {
                var staatuskaal = "";
                if (kaal < 50)
                { staatuskaal = "Keskmisest vähem"; }
                else if (kaal < 70)
                { staatuskaal = "normaalne"; }
                else if (kaal < 100)
                { staatuskaal = "Üle keskmise"; }
                else
                { staatuskaal = "ebanormaalne"; }
                return staatuskaal;
            }
        }
        public int Kaal
        {
            set
            { kaal = value;
                if (kaal<50)
                {
                    staatuskaal = "Keskmisest vähem";
                }
                else if (kaal<70)
                {
                    staatuskaal = "normaalne";
                }
                else if (kaal < 100)
                {
                    staatuskaal = "Üle keskmise";
                }
                else
                {
                    staatuskaal = "ebanormaalne";
                }
            }
        }
        public void Tervitame() //metod
        {
            Console.WriteLine("Tere!");
            Console.WriteLine("Minu nimi on {0}. Olen {1} aastat vana. Minu staatus on {2}.", eesnimi, vanus, Staatus);
            Console.WriteLine("Minu kaal on {0}. Minu kaal staatus on {1}", kaal, Staatuskaal);
            Console.WriteLine("Minu ema keel on {0}",emakeel);
        }
        public abstract void kes_ma_olen();
    }
}

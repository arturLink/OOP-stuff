using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_stuff
{
    public class Inimene
    {
        //svoistva
        string eesnimi;
        int vanus;
        string staatus;
        int kaal;
        string staatuskaal;
        Emakeel emakeel;

        //polja
        public Inimene() { } //konstruktor

        public Inimene(string Eesnimi, int Vanus, Emakeel emakeel)
        {
            eesnimi = Eesnimi;
            vanus = Vanus;
            this.emakeel = emakeel;
            //kaal = Kaal;
            //staatus = staatus;
        }
        public Emakeel Emakeel
        {
            get { return emakeel; }
        }
        public string Eesnimi
        {
            set
            {
                if (eesnimi == null) eesnimi = value;
            }
            get { return eesnimi; }
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
            set { if(staatus==null)staatus = value; }
            get { return staatus; }
        }       
        public string Staatuskaal
        {
            set { if (staatuskaal == null) staatuskaal = value; }
            get { return staatuskaal; }
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
            Console.WriteLine("Minu nimi on {0}. Olen {1} aastat vana. Minu staatus on {2}. Minu kaal on {3}. Minu kaal staatus on {4}", eesnimi, vanus, staatus,kaal,staatuskaal);
        }
    }
}

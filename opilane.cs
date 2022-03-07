using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_stuff
{
    class Opilane : Inimene
    {
        string ruhm;
        double hinne;
        bool toetus;
        public Opilane() { }
        public Opilane(string Eesnimi, string Perenimi, string Ruhm):base (Eesnimi,Perenimi)
        {
            ruhm = Ruhm;
        }
        public string Ruhm
        {
            get
            {
                return ruhm;
            }
            set
            {
                ruhm = value;
            }
        }
        public double Hinne
        {
            set { 
                if (value>1 && value<5)hinne = value; }
            get { return hinne; }
        }
        public bool Toetus
        {
            get
            {
                if (hinne>3)
                {
                    toetus = true;
                }
                else
                {
                    toetus = false;
                }
                return toetus;
            }
        }
        public void OpInfo()
        {
            string t = "";
            Console.WriteLine("Opilane: {0} {1}",Eesnimi,Perenimi);
            Console.WriteLine("Hinne: {0}", hinne);
            if (Toetus == true)
            {
                t = "Saan toetust kätte";
            }
            else if (Toetus == false)
            {
                t = "Ei saa toetust";
            }
            Console.WriteLine("Minu keskmine hinne on {0}. {1}", hinne, t);
        }
    }
}

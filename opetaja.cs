using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_stuff
{
    public class Opetaja : Inimene
    {
        string aine;

        public Opetaja() { }
        public Opetaja(string Eesnimi, string Perenimi, string Aine) : base(Eesnimi, Perenimi)
        {
            aine = Aine;
        }

        public string Aine
        {
            set { aine = value; }
            get { return aine; }
        }
        public override void kes_ma_olen()
        {
            Console.WriteLine("Ma olen opetaja, minu nimi on {0} {1} ja minu tund on {2}",Eesnimi, Perenimi,aine);
        }
    }
}

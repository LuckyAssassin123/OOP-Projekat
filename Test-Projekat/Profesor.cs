using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Projekat
{
    class Profesor:Zaposleni
    {
        public string predmet { get; set; }
        public int plata { get; set; }
        public Profesor(string im,string pr,string pred,int pl):base(im,pr)
        {
            predmet = pred;
            plata = pl;
        }
        public override string ToString()
        {
            return "Ime: " + ime + "\nPrezime: " + prezime + "\nNastavni Predmet: " + predmet + "\nPlata: " + plata;
        }
    }
}

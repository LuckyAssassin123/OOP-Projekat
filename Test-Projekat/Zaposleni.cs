using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Projekat
{
    class Zaposleni
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        public Zaposleni(string im, string pr)
        {
            ime = im;
            prezime = pr;
        }
        public void predstaviSe()
        {
            Console.WriteLine("Ja  sam "+ime+" "+prezime);
        }

    }
}

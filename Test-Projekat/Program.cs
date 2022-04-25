using System;

namespace Test_Projekat
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor p1 = new Profesor("Aleksnadar", "Cvetkovic", "Programiranje", 1000);
            p1.predstaviSe();
            Console.WriteLine(p1);
        }
    }
}

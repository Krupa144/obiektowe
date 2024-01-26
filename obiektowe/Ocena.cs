using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiektowe
{
    internal class Ocena
    {
        public int Wartosc { get; set; }
        public string NazwaPrzedmiotu { get; set; }

        public Ocena(int wartosc, string nazwaPrzedmiotu)
        {
            Wartosc = wartosc;
            NazwaPrzedmiotu = nazwaPrzedmiotu;
        }

        public void WypiszInfo()
        {
            Console.WriteLine($"Ocena z przedmiotu {NazwaPrzedmiotu}: {Wartosc}");
        }
    }
}

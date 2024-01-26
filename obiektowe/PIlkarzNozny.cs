using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiektowe
{
    class PIlkarzNozny : Pilkarz
    {
        public PIlkarzNozny(string imie, string nazwisko, int wiek) : base(imie, nazwisko, wiek)
        {
        }

        // Przesłonięta metoda StrzelGola
        public override void StrzelGola()
        {
            base.StrzelGola();
            Console.WriteLine("Nożny strzelił!");
        }
    }
}

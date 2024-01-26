using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiektowe
{
    internal class PIlkarzReczny : Pilkarz
    {
        public PIlkarzReczny(string imie, string nazwisko, int wiek) : base(imie, nazwisko, wiek)
        {
        }

        
        public override void StrzelGola()
        {
            base.StrzelGola();
            Console.WriteLine("Ręczny strzelił!");
        }
    }
}

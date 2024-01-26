using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiektowe
{
    internal class Pilkarz : Osoba
    {
        protected int liczbaGoli;

        public Pilkarz(string imie, string nazwisko, int wiek) : base(imie, nazwisko, wiek)
        {
            liczbaGoli = 0;
        }

        public virtual void StrzelGola()
        {
            liczbaGoli++;
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine($"Liczba strzelonych goli: {liczbaGoli}");
        }
    }
}

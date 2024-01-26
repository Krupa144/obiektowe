using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiektowe
{


    class Student : Osoba
    {

        private List<Ocena> oceny = new List<Ocena>();

        public Student(string imie, string nazwisko, int wiek) : base(imie, nazwisko, wiek)
        {
        }

        public void DodajOcene(Ocena ocena)
        {
            oceny.Add(ocena);
        }

        public void WypiszOceny()
        {
            Console.WriteLine("Oceny studenta:");
            foreach (var ocena in oceny)
            {
                ocena.WypiszInfo();
            }
        }

        public void WypiszOceny(string nazwaPrzedmiotu)
        {
            Console.WriteLine($"Oceny studenta z przedmiotu {nazwaPrzedmiotu}:");
            foreach (var ocena in oceny)
            {
                if (ocena.NazwaPrzedmiotu == nazwaPrzedmiotu)
                {
                    ocena.WypiszInfo();
                }
            }
        }

        public void UsunOcene(int wartosc, string nazwaPrzedmiotu)
        {
            for (int i = oceny.Count - 1; i >= 0; i--)
            {
                if (oceny[i].Wartosc == wartosc && oceny[i].NazwaPrzedmiotu == nazwaPrzedmiotu)
                {
                    oceny.RemoveAt(i);
                }
            }
        }
        
        
    }

}


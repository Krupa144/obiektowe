using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiektowe
{
    internal class Osoba
    {
        private string imie;
        private string nazwisko;
        private int wiek;
        private Samochod[] samochody;
        private int liczbaSamochodow;

        public Osoba(string imie_, string nazwisko_, int wiek_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
            wiek = wiek_;
            samochody = new Samochod[3];
            liczbaSamochodow = 0;
        }

        public void DodajSamochod(string numerRejestracyjny)
        {
            if (liczbaSamochodow < 3)
            {
                Samochod nowySamochod = new Samochod();
                nowySamochod.NumerRejestracyjny = numerRejestracyjny;
                samochody[liczbaSamochodow] = nowySamochod;
                liczbaSamochodow++;
                Console.WriteLine("Dodano samochód o numerze rejestracyjnym: " + numerRejestracyjny);
            }
            else
            {
                Console.WriteLine("Nie można dodać kolejnego samochodu. Osiągnięto maksymalną liczbę samochodów (3).");
            }
        }

        public void UsunSamochod(string numerRejestracyjny)
        {
            for (int i = 0; i < liczbaSamochodow; i++)
            {
                if (samochody[i]?.NumerRejestracyjny == numerRejestracyjny)
                {
                    samochody[i] = null;
                    liczbaSamochodow--;
                    Console.WriteLine("Usunięto samochód o numerze rejestracyjnym: " + numerRejestracyjny);
                    return;
                }
            }

            Console.WriteLine("Nie znaleziono samochodu o numerze rejestracyjnym: " + numerRejestracyjny);
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Imię: " + imie);
            Console.WriteLine("Nazwisko: " + nazwisko);
            Console.WriteLine("Wiek: " + wiek);

            Console.WriteLine("Numery rejestracyjne posiadanych samochodów:");
            for (int i = 0; i < liczbaSamochodow; i++)
            {
                Console.WriteLine();
            }
        }
    }
}



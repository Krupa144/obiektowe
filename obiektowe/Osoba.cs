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
        private string[] numeryRejestracyjneSamochodow;

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        public int Wiek
        {
            get { return wiek; }
            set { wiek = value; }
        }

        public Osoba()
        {
            imie = "nieznane";
            nazwisko = "nieznane";
            wiek = 0;
            numeryRejestracyjneSamochodow = new string[3];
        }

        public Osoba(string imie_, string nazwisko_, int wiek_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
            wiek = wiek_;
            numeryRejestracyjneSamochodow = new string[3];
        }

        public void DodajSamochod(string numerRejestracyjny)
        {
            for (int i = 0; i < numeryRejestracyjneSamochodow.Length; i++)
            {
                if (numeryRejestracyjneSamochodow[i] == null)
                {
                    numeryRejestracyjneSamochodow[i] = numerRejestracyjny;
                    Console.WriteLine($"Dodano samochód o numerze rejestracyjnym: {numerRejestracyjny}");
                    return;
                }
            }

            Console.WriteLine("Nie można dodać kolejnego samochodu. Osiągnięto limit.");
        }

        public void UsunSamochod(string numerRejestracyjny)
        {
            for (int i = 0; i < numeryRejestracyjneSamochodow.Length; i++)
            {
                if (numeryRejestracyjneSamochodow[i] == numerRejestracyjny)
                {
                    numeryRejestracyjneSamochodow[i] = null;
                    Console.WriteLine($"Usunięto samochód o numerze rejestracyjnym: {numerRejestracyjny}");
                    return;
                }
            }

            Console.WriteLine($"Nie znaleziono samochodu o numerze rejestracyjnym: {numerRejestracyjny}");
        }

        public void WypiszInfo()
        {
            Console.WriteLine($"Imię: {imie}");
            Console.WriteLine($"Nazwisko: {nazwisko}");
            Console.WriteLine($"Wiek: {wiek}");
            Console.WriteLine("Numery rejestracyjne posiadanych samochodów:");

            for (int i = 0; i < numeryRejestracyjneSamochodow.Length; i++)
            {
                if (numeryRejestracyjneSamochodow[i] != null)
                {
                    Console.WriteLine($"{i + 1}. {numeryRejestracyjneSamochodow[i]}");
                }
            }
        }
    }

}




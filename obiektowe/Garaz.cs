using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiektowe
{
    internal class Garaz
    {
        private string adres;
        private int pojemnosc;
        private int liczbaSamochodow;
        private Samochod[] samochody;

        private int liczbaSamochow = 0;
        

        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }
         public int Pojemnosc
        {
            get { return pojemnosc;}
            set { 
                pojemnosc = value;
                samochody = new Samochod[pojemnosc]; }
        }

        public Garaz()
        {
            adres = "nienzany";
            pojemnosc = 0;
            liczbaSamochodow = 0;
            samochody = null;
        }

       

            public Garaz(string adres_, int pojemnosc_)
            {
                adres = adres_;
                pojemnosc = pojemnosc_;
                liczbaSamochodow = 0;
                samochody = new Samochod[pojemnosc];
            }

            public void WprowadzSamochod(Samochod nowySamochod)
            {
                if (liczbaSamochodow < pojemnosc)
                {
                    samochody[liczbaSamochodow] = nowySamochod;
                    liczbaSamochodow++;
                }
                else
                {
                    Console.WriteLine("Garaż jest pełny, nie można dodać nowego samochodu.");
                }
            }

            public Samochod WyprowadzSamochod()
            {
                if (liczbaSamochodow > 0)
                {
                    Samochod ostatniSamochod = samochody[liczbaSamochodow - 1];
                    samochody[liczbaSamochodow - 1] = null;
                    liczbaSamochodow--;
                    return ostatniSamochod;
                }
                else
                {
                    Console.WriteLine("Garaż jest pusty, nie można wyprowadzić żadnego samochodu.");
                    return null;
                }
            }

            public void WypiszInfo()
            {
                Console.WriteLine("Adres garażu: " + adres);
                Console.WriteLine("Pojemność garażu: " + pojemnosc);
                Console.WriteLine("Liczba samochodów w garażu: " + liczbaSamochodow);

                for (int i = 0; i < liczbaSamochodow; i++)
                {
                    Console.WriteLine("Informacje o samochodzie " + (i + 1) + ":");
                    samochody[i].WypiszInfo();
                }
            }
        }
    }
    


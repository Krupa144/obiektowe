using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace obiektowe
{
    internal class Samochod
    {
        private string marka;
        private string model;
        private int iloscDrzwi;
        private double pojemnoscSilnika;
        private double srednieSpalanie;
        private string numerRejestracyjny;
        public string NumerRejestracyjny
        {
            get { return numerRejestracyjny; }
            set { numerRejestracyjny = value; }
        }


        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int IloscDrzwi
        {
            get { return iloscDrzwi; }
            set { iloscDrzwi = value; }
        }

        public double PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set { pojemnoscSilnika = value; }
        }
        
        public double SrednieSpalanie
        {
            get { return srednieSpalanie; }
            set { srednieSpalanie = value; }

        }

        private static int iloscSamochodow = 0;


        public Samochod()
        {
            marka = "nienznana";
            model = "nienznany";
            iloscDrzwi = 0;
            pojemnoscSilnika=0.0;
            srednieSpalanie=0.0;
            iloscSamochodow++;
        }

        public Samochod(string marka, string model, int iloscDrzwi, double pojemnoscSilnika, double srednieSpalanie) { 
            this.marka = marka;
            this.model = model;
            this.iloscDrzwi = iloscDrzwi;
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.srednieSpalanie = srednieSpalanie;
            iloscSamochodow++;
        }



        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return (srednieSpalanie * dlugoscTrasy)/100.0  ;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy , double cenaPaliwa)
        {
            double spalanie = ObliczSpalanie(dlugoscTrasy);
                return spalanie * cenaPaliwa;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("marka " + marka);
            Console.WriteLine("model " + model);
            Console.WriteLine("ilosc drzwi" + iloscDrzwi);
            Console.WriteLine("pojemnosc silnika " + pojemnoscSilnika);
            Console.WriteLine("srednie spalanie " + srednieSpalanie);
            Console.WriteLine();
        }

        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine("liczba samochodow "+ iloscSamochodow);
        }
    }
}

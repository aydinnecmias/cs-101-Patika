using System;

namespace Instance__Field__Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Araclar arac1 = new Araclar();

            arac1.Marka = "BMW";
            arac1.Model = "2021";
            arac1.Km = 0;
            arac1.Renk = "Siyah";

            arac1.AracBilgileriGoster();

        }
    }

    class Araclar
    {
        public string Marka;
        public string Model;
        public int Km;
        public string Renk;

        public void AracBilgileriGoster() 
        {
            Console.WriteLine("Arac Markası: {0}",Marka );
            Console.WriteLine("Arac Modeli: {0}", Model);
            Console.WriteLine("Arac Kmsi: {0}", Km);
            Console.WriteLine("Arac Renk: {0}", Renk);

        }
    }
}

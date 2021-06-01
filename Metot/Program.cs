using System;

namespace Metot
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar metotlar = new Metotlar();

            metotlar.EkranaYazdır(Convert.ToString(sonuc));





        }

        static int Topla(int deger1, int deger2)
        {
            return(deger1 + deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri + " " + "metottan geliyorumm");

        }
        // ref anahtar kelimesiyle ana değişken üzerinde değişiklik yapılabilir. Referans tipe işaret eder.

    }
}

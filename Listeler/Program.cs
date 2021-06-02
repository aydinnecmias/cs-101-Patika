using System;
using System.Collections.Generic;

namespace Listeler

{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Aydin";
            kullanici1.Soyisim = "AS";
            kullanici1.Yas = "25";

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Ördek";
            kullanici2.Soyisim = "Yaramaz";
            kullanici2.Yas = "1";

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);


            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine(kullanici.Isim);
                Console.WriteLine(kullanici.Soyisim);
                Console.WriteLine(kullanici.Yas);

            }
        }

        
    }
  
        //liste.Clear(); listeyi temizlemek için kullanılır

        //sayilistesi.Contains(20) sayi listesindeki 20 elemanını bulur

        /*
        Bir diziyi listeye çevirmek için 
        string[] hayvanlar = { "Kedi", "Köpek", "Ördek", "Maymun" };
        List<string> hayvanListesi = new List<string>(hayvanlar);
        */
    
}

using System;

namespace String_Metotları
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime1 = "Deneme Yazısı";
            string kelime2 = "deneme yazısı";

            Console.WriteLine(String.Compare(kelime1,kelime2,false));
            Console.WriteLine(String.Compare(kelime1, kelime2, true));

            Console.WriteLine(kelime1.Contains("ne"));
            Console.WriteLine(kelime2.EndsWith("yazısı"));
            Console.WriteLine(kelime1.IndexOf("Ysdfs")); // yanlışsa -1 döner
            Console.WriteLine(kelime1.Insert(0,"selamlar "));
            Console.WriteLine(kelime1.Remove(0,3));

            Console.WriteLine(kelime1.Replace("Deneme","Test"));

            Console.WriteLine(kelime2.Split(" ")[1]);
            Console.WriteLine(kelime2.Substring(4,6)); //4.indexten başlayarak 6 karakter getir
            Console.WriteLine(kelime2.Substring(2));




        }
    }
}

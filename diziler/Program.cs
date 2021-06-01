using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = {"mavi", "yeşil", "sarı", "kırmızı"};

            string[] isimler = new string[2];

            renkler[3] = "mor";

            foreach(var renk in renkler)
                Console.WriteLine(renk);
        }
    }
}

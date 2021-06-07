using System;
using System.Collections;

namespace ArrayList
{

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList dizi = new ArrayList();

            dizi.Add("Hayvan");
            dizi.Add("sayi");
            dizi.Add(2);

            foreach(var item in dizi)
            {
                Console.WriteLine(item);
            }

        }
    }
}

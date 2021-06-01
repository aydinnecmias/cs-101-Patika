using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {

            int time = DateTime.Now.Hour;

            if (time < 12)
                Console.WriteLine("saat daha erken!");
            else if (time > 12 && time < 17)
                Console.WriteLine("gün ortasındasınız");
            else
                Console.WriteLine("akşam oldu!");


            string sonuc = time <= 18 ? "akşam olmamış" : "gündüz vakti";
            Console.WriteLine(sonuc);

            string result = time >= 20 ? "gece vakti" : time >= 16 ? "ikindi zamanı" : " iyi günler";
            Console.WriteLine(result);


        }
    }
}

using System;

namespace Datetime_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());


            Console.WriteLine(DateTime.Now.AddDays(2)); //2 gün ekler
            Console.WriteLine(DateTime.Now.AddHours(5)); // 5 saat ekler


            Console.WriteLine(DateTime.Now.ToString("dd")); // 6 getirir
            Console.WriteLine(DateTime.Now.ToString("ddd")); // Tue getirir
            Console.WriteLine(DateTime.Now.ToString("dddd")); // Tuesday getirir


            Console.WriteLine(DateTime.Now.ToString("yy"));//21 getirir
            Console.WriteLine(DateTime.Now.ToString("yyyy"));// 2021 getirir



            //Math Kütüphanesi

            Console.WriteLine(Math.Abs(-55)); //mutlak değer alır
            Console.WriteLine(Math.Sin(30)); //sin30 değerini verir

            //ceiling-round-floor
            //ceiling yukarıya yuvarlar round nereye yakınsa oraya floor aşağıya yuvarlar



            Console.WriteLine(Math.Pow(4,6)); //üs almak içinn

            Console.WriteLine(Math.Sqrt(4)); // kök almak için




        }
    }
}

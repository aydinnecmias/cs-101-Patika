using System;

namespace Recursive_Extension_Methods
{
    class Program
    {
        static void Main(string[] args)


        {
            int sayi = 34;
            string ad = "denemeyazısı";

            if (ad.CheckSpaces())
            {
                Console.WriteLine("bosluk vaaarrr");
            }
            else
            {
                Console.WriteLine("bosluk mosluk yok bambambam");
            }

            bool result2 = sayi.isEvenNumber();

            Console.WriteLine(result2);



        }
    }

    public static class Extensions{

        public static bool CheckSpaces(this string param)
        {

            return param.Contains(" ");

        }

        public static bool isEvenNumber(this int param)
        {
            return param % 2 == 0;
        }
        

}
}

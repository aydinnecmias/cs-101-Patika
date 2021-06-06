using System;

namespace FunnyExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz:");
            var cumle = Console.ReadLine();

            string komik = cumle.Troll();
            Console.WriteLine(komik);


        }
    }

    public static class Funny
    {

        public static string Troll(this string param)

        {

            if (param.Contains("i")) { }

                      
                return param.Replace("i", "ö");



        }
       

    }
}

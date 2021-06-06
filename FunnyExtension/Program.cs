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

<<<<<<< HEAD
    public static class Funny
=======
    public static class Funny 
>>>>>>> parent of 9d0abe9 (Delete FunnyExtension directory)
    {

        public static string Troll(this string param)

        {

            if (param.Contains("i")) { }

<<<<<<< HEAD

            return param.Replace("i", "ö");
=======
                      
                return param.Replace("i", "ö");
>>>>>>> parent of 9d0abe9 (Delete FunnyExtension directory)



        }
<<<<<<< HEAD

=======
       
>>>>>>> parent of 9d0abe9 (Delete FunnyExtension directory)

    }
}

using System;

namespace EnumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazartesi);
            
            int bugun =7;           

            if (bugun == (int)Gunler.Pazar)
            {
                Console.WriteLine("Tatil günü");
            }
            else
            {
                Console.WriteLine("tatil yok");
            }


        }

        
    }
    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
}

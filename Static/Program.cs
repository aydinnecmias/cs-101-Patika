using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İlk atanan değer: " + StaticMetot.motor);

            StaticMetot.motor = 60;
            Console.WriteLine("şimdiki değeri: " + StaticMetot.motor);
            Console.WriteLine("Otobus deger: " + StaticMetot.Otobus());
        }
    }

    class StaticMetot
    {
       
        public static int motor = 1000;
        public int benzin = 3; 

        
        public static int Otobus()
        {
            

            StaticMetot staticMet = new StaticMetot();

            staticMet.Otomobil(); 
            staticMet.benzin = 2;
            return motor / 2;
        }

        public void Otomobil() 
        {

        }
    }

    

    
    }


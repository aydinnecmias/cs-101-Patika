using System;

namespace switch_caase
{
    class Program
    {
        static void Main(string[] args)
        {
            int mount = DateTime.Now.Month;

            switch (mount)
            {
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("bahar geldi");
                    break;

                default:
                    Console.WriteLine("mevsimler geçer");
                    break;

            }
        }
    }
}

using System;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int deneme = int.Parse(Console.ReadLine());
                

            }
            catch (OverflowException ex)
            {

                Console.WriteLine("Girdiğiniz sayı çok küçük ya da çok büyük");

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine("Girdiğiniz  değer uygun değil");

            }
            catch (FormatException ex)
            {

                Console.WriteLine("Girdiğiniz veri tipi uygun değil.");

            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı...");

            }
        }
    }
}

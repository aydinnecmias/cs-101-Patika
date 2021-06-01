using System;
/*
--Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

--Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

--Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

--Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
 Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

 */
namespace Algoritma_Soruları
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true) {
               
                Console.WriteLine("Pozitif bir sayi giriniz");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{n} adet pozitif sayi giriniz", n);
                for (int i = 0; i < n; i++)
                {
                    
                    int sayi = Convert.ToInt32(Console.ReadLine());
                   


                }

                    if (n > 0) 
                {
                    for (int i = 0; i < n; i++) 
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);                       

                        }
                    
                    }
                
                
                }

            }

            Console.WriteLine("Pozitif bir sayi giriniz");
            int n =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{n} adet pozitif sayi giriniz",n);
            







        }
    }
}

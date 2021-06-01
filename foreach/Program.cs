using System;


    class Program
{
    static void Main(string[] args)
    {
        int[] sayiDizisi = { 1,2,3,4,5,6,7,8,10 };
        int toplam = 0;

        foreach (int i in sayiDizisi)
        {
            toplam += i;
            
        }
        Console.WriteLine(toplam);
    }
}


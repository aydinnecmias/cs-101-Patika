using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Personel

        

    {
        private DateTime _GoreveBaslamaTarih;
        public DateTime GoreveBaslamaTarih
        {
            
            get { return _GoreveBaslamaTarih; }
            
            set
            {
                if (_GoreveBaslamaTarih.Year < DateTime.Now.Year)
                    Console.WriteLine("Hatalı Göreve Başlama Tarih Bilgisi");
                    _GoreveBaslamaTarih = value;
            }
        }
    }
}

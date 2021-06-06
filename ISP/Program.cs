using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        interface IArac // Yanlış bir kullanım
        {
            void motor();
            void tekerlek();
            void pervane();
            void kanat();
            void kaporta();
            void yelken();
        }
        interface IDenizAracı
        {
            void motor();
            void pervane();
            void kaporta();
            void yelken();

        }

        interface IKaraAracı
        {
            void tekerlek();
            void kaporta();
            void motor();

        }
        interface IHavaAracı
        {
            void tekerlek();
            void motor();
            void kanat();


        }

        class DenizAraclari : IDenizAracı
        {
            public void kaporta()
            {
                throw new NotImplementedException();
            }

            public void motor()
            {
                throw new NotImplementedException();
            }

            public void pervane()
            {
                throw new NotImplementedException();
            }

            public void yelken()
            {
                throw new NotImplementedException();
            }
        }

        class KaraAraclari : IKaraAracı
        {
            public void kaporta()
            {
                throw new NotImplementedException();
            }

            public void motor()
            {
                throw new NotImplementedException();
            }

            public void tekerlek()
            {
                throw new NotImplementedException();
            }
        }

        class HavaAraclari : IHavaAracı
        {
            public void kanat()
            {
                throw new NotImplementedException();
            }

            public void motor()
            {
                throw new NotImplementedException();
            }

            public void tekerlek()
            {
                throw new NotImplementedException();
            }
        }
    }

}

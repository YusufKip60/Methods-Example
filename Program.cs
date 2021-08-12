using System;

namespace ysf
{
    class Program
    {
        static void Main(string[] args)
        {
            string Malzemeadi = "Demir";
            int Agırlıgı = 10;
            double Fiyatı = 150;

            Malzeme malzeme1 = new Malzeme();
            malzeme1.Adi = "Demir";
            malzeme1.Agırlıgı = 10;
            malzeme1.Fiyatı = 150;
            malzeme1.StokAdedi = 2000;


            Malzeme malzeme3 = new Malzeme();
            malzeme3.Adi = "Kömür";
            malzeme3.Agırlıgı = 30;
            malzeme3.Fiyatı = 50;
            malzeme3.StokAdedi = 10.000;


            Malzeme malzeme2 = new Malzeme();
            malzeme2.Adi = "Bakır";
            malzeme2.Agırlıgı = 20;
            malzeme2.Fiyatı = 90;
            malzeme2.StokAdedi = 2000;

            Malzeme[] malzemeler = new Malzeme[] { malzeme1, malzeme2, malzeme3 };

            foreach (var Malzeme in malzemeler)
            {
                Console.WriteLine(Malzeme.Adi);
                Console.WriteLine(Malzeme.Agırlıgı);
                Console.WriteLine(Malzeme.Fiyatı);
                Console.WriteLine(Malzeme.StokAdedi);
                Console.WriteLine("------------");
            }


                Console.WriteLine("----Sepettekiler----");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(malzeme1);
            sepetManager.Ekle(malzeme2);
            sepetManager.Ekle(malzeme3);







        }
    }
}

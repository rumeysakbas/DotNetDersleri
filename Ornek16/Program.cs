namespace Ornek16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Kullanıcıdan 2 tane sayı alınız
            //Kullanıcıya hangi işlemi yapmak istediğini sorunuz (toplama çıkarma)
            //İstenilen işlemi kullanıcının girdiği sayılara uygulayınız

            int s1 = 0, s2 = 0;
            bool kontrol1, kontrol2;

            int islemTuru;

            bool islemKontrol;

        Sayi1Giris:
            Console.Write("Bir sayı giriniz   :");
            kontrol1 = int.TryParse(Console.ReadLine(), out s1);
            if (!kontrol1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hatalı giriş!");
                Console.ResetColor();
                goto Sayi1Giris;
            }

            Console.WriteLine("\n");
        Sayi2Giris:
            Console.Write("Bir sayı giriniz   :");
            kontrol2 = int.TryParse(Console.ReadLine(), out s2);

            if (!kontrol2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hatalı giriş!");
                Console.ResetColor();
                goto Sayi2Giris;
            }
        islemTurSec:
            Console.WriteLine("\nİşlem türünüzü seçiniz. 1---> Toplama \n2---->Çıkarma");

            islemKontrol = int.TryParse(Console.ReadLine(), out islemTuru);
            if (!islemKontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Seni anlayamadım!");
                Console.ResetColor();
                goto islemTurSec;
            }
            //ıslemTuru değişkenini IslemTurleri enum 'una cast ediyorum.
            else if ((IslemTurleri)islemTuru == IslemTurleri.Toplama)
            {
                Console.WriteLine($"toplam={s1 + s2}");
            }
            else if (islemTuru == 2)
            {
                Console.WriteLine($"sonuç={s1 - s2}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("işlem türünü 1 ya da 2 seçmelisin!");
                Console.ResetColor();
                goto islemTurSec;
            }


            //Sude'nin sorusu: 
            //convert edebildiklerimiz için de cast kullanabilir miyiz?

            double a = 10;
            int x = (int)a; // cast etti



        }

    } // class burada bitmiş

    public enum IslemTurleri
    {
        Toplama = 1,
        Cikarma = 5,
        Carpma = 100,
        Bolme,
        ModAlma
    }
}

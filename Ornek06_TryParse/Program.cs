namespace Ornek06_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Bir sayı giriniz  :");
            //    int sayi=Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Değer alındı. Teşekkür ederiz");

            //Console.WriteLine("Stok adet giriniz  :");
            //byte stok = Convert.ToByte(Console.ReadLine());

            //Console.WriteLine("Değer alındı. Teşekkür ederiz");

            //sayı giriniz dedik
            //ve kullanıcı sayı girmedi ya da yanlışlıkla girdiği sayının sonunda farklı karakter vardı PATLATTI
            //ve kullanıcı gerçekten sayı girdi! ama girdiği sayı PATLATTI

            //PATLAMA olmaması için daha farklı bir dönüştürücü kullanabilir miyiz?

            //try parse 
            //Eğer kullanıcılardan değerler alıyorsanız ve patlama durumu olabilirse tryparse kullanabilirsimiz
            //eğer patlama durumu yoksa convert ya da parse kullanabilirsiniz
            Console.WriteLine("Stok adet giriniz  :");
            byte stok = 0;//değişken tanımlandı ve ilk değeri verildi.
            bool kontrol = byte.TryParse(Console.ReadLine(), out stok);
            Console.WriteLine("Girilen değer uygun mu?" + kontrol);


            Console.WriteLine("Doğum tarihi  giriniz  :");
            bool kontroltrh = DateTime.TryParse(Console.ReadLine(), out DateTime trh);
            Console.WriteLine("Girilen doğum tarihi uygun mu?" + kontroltrh);
        }
    }
}

namespace Ornek13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 2 tane sayı alınız
            //Kullanıcıya hangi işlemi yapmak istediğini sorunuz (toplama çıkarma)
            //İstenilen işlemi kullanıcının girdiği sayılara uygulayınız

            int s1 = 0, s2 = 0;
            bool kontrol;
            int islemTuru = 0; // toplama 1 çıkarma  2
        Baslangic:

        Sayi1Giris:
            Console.Write("Bir sayı giriniz   :");
            kontrol = int.TryParse(Console.ReadLine(), out s1);
            if (!kontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hatalı giriş!");
                Console.ResetColor();
                goto Sayi1Giris;
            }

            Console.WriteLine("\n");
        Sayi2Giris:
            Console.Write("Bir sayı giriniz   :");
            kontrol = int.TryParse(Console.ReadLine(), out s2);

            if (!kontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hatalı giriş!");
                Console.ResetColor();
                goto Sayi2Giris;
            }
        islemTurSec:
            Console.WriteLine("\nİşlem türünüzü seçiniz. 1---> Toplama \n2---->Çıkarma");
            kontrol = int.TryParse(Console.ReadLine(), out islemTuru);
            if (!kontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Seni anlayamadım!");
                Console.ResetColor();
                goto islemTurSec;
            }
            else if (islemTuru == 1)
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

            Console.WriteLine("-------------------\n");
            goto Baslangic;
        }
    }
}

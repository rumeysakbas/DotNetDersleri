namespace Ornek30_BreakveContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Örn: 
        //break komutu: döngüyü kırar.
        //continue komutu: döngüde atlama sıçrama yapar
        //yani continue'dan sonraki satıra geçmeden döngü başa döner.

        //for (int i = 0; i <= 5; i++)
        //{
        //    if (i == 4)
        //    {
        //        break;
        //    }
        //    Console.WriteLine(i);
        //}
        //Console.WriteLine("---------------------------------");

        //for (int i = 0; i <= 5; i++)
        //{
        //    if (i == 4)
        //    {
        //        continue;
        //    }
        //    Console.WriteLine(i);
        //}


        //Örn: Girilen sayının asal olup olmadığını bulalım
        //7 
        //6 5 4 3 2  ASaldır
        //8
        //7 6 5 4--> bölen buldum asal değil!
        Baslangic:
            int sayi = 0;
            bool kontrol;
            bool asalDegilMi = false;
            bool asalMi = true;
            Console.WriteLine("Bir sayı giriniz   :");
            kontrol = int.TryParse(Console.ReadLine(), out sayi);
            if (!kontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("HATALI giriş!");
                Console.ResetColor();
                goto Baslangic;
            }
            //else if (sayi <0)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Negatif sayılarda ASALLık aranamz!");
            //    Console.ResetColor();
            //    goto Baslangic;
            //}
            //else if (sayi < 2)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Lütfen 2 ve 2den büyük sayılar giriniz!");
            //    Console.ResetColor();
            //    goto Baslangic;
            //}

            for (int i = sayi - 1; i > 1; i--)
            {
                if (sayi % i == 0)
                {
                    asalDegilMi = true;
                    break;
                }

            }
            if (asalDegilMi || sayi < 2)
            {
                Console.WriteLine("Bu sayı ASAL DEĞİL!");
            }
            else
            {
                Console.WriteLine("Bu sayı ASALDIR!");
            }


            //    for (int i = sayi - 1; i > 1; i--)
            //{
            //    if (sayi % i == 0)
            //    {
            //        asalMi = false;
            //        break;
            //    }

            //}
            //if (asalMi && sayi >= 2)
            //{
            //    Console.WriteLine("Bu sayı ASALdır!!");
            //}
            //else
            //{
            //    Console.WriteLine("Bu sayı ASAL DEĞİL!");
            //}

            goto Baslangic;
            //NOT: senaryomuz nasıl ilerliyorsa
            //kurduğunuz algoritmanız
            //ona göre iflerinizi yerleştirebilirsiniz
            //NOT2: Değişkenlerinizi isimlendirirken ters mantık kelimeleriyle isimlendirdiğinizde kodu okumak zorlaşabilir bu nedenle asalMi aktifMi gibi okurken kafa karışmayacak şekilde isimlendiriniz.
        }
    }
}

namespace Ornek35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖRN: kullanıcı "devam etmek" istediği sürece sayı girişi yapsın. "Devam etmek" istemediğinden girdiği tüm sayıları toplayalım.
            int toplam = 0;
            int sayi = 0;
            bool sayiKontrol = false;
            ConsoleKeyInfo secim = new ConsoleKeyInfo();
            bool programYeniBasladi = true;

            while (secim.Key == ConsoleKey.E || programYeniBasladi)
            {
                programYeniBasladi = false;
                sayiKontrol = false;
                while (!sayiKontrol)
                {
                    Console.WriteLine("Bir sayı girinizzz :");
                    sayiKontrol = int.TryParse(Console.ReadLine(), out sayi);

                    if (!sayiKontrol)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("HATALI sayı girişi!");
                        Console.ResetColor();
                    }
                    else
                    {
                        //demekki sayı girişi düzgün
                        //  toplam = toplam + sayi;
                        toplam += sayi;
                    }
                } // while sayiKontrol burada bitti
                  //şimdi kullanıcıya devam etmek ile ilgili sorumu sorucam
                Console.WriteLine("\nDevam etmek ister misiniz? Evet ise e'ye hayır ise herhangi bir tuşa basınız.");
                secim = Console.ReadKey();
                Console.WriteLine();
            }
            Console.WriteLine("Güle güle.....");
            Console.WriteLine($"Toplam = {toplam}");
        }
    }
}

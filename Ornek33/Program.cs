namespace Ornek33_WhileBreakContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asal mi
            bool asalMi = true;
            int sayi = 0;
            bool kontrol = false;
        Baslangic:

            asalMi = true; // değişkenin içeriği refresh edildi.
            Console.WriteLine("Bir sayı giriniz   :");
            kontrol = int.TryParse(Console.ReadLine(), out sayi);
            if (!kontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("HATALI giriş!");
                Console.ResetColor();
                goto Baslangic;
            }
            else if (sayi < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Negatif sayılarda Asallık aranmaz!");
                Console.ResetColor();
                goto Baslangic;
            }
            else if (sayi < 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lütfen 2 ve 2 den büyük bir sayı giriniz!!");
                Console.ResetColor();
                goto Baslangic;
            }
            //7
            int bolen = sayi - 1;
            while (bolen > 1)
            {
                if (sayi % bolen == 0)
                {
                    asalMi = false;
                    break;
                }
                bolen--;
            } // while bitti


            if (asalMi)
            {
                Console.WriteLine("ASALDIR");

            }
            else
            {
                Console.WriteLine("ASAL sayı değildir!");
            }
            goto Baslangic;
        }
    }
}

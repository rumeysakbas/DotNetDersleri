using System.Runtime.CompilerServices;

namespace Ornek34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖRN:
            //#region OncekiKullanimimiz
            //Baslangic:
            //    bool kontrol = false;
            //    int sayi = 0;
            //    Console.WriteLine("Bir sayı giriniz   :");
            //    kontrol = int.TryParse(Console.ReadLine(), out  sayi);
            //    if (!kontrol)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("HATALI giriş!");
            //        Console.ResetColor();
            //        goto Baslangic;
            //    }
            //    #endregion


            bool kontrolum = false;
            int sayim = 0;
            while (!kontrolum)
            {
                Console.WriteLine("Bir sayı giriniz   :");
                kontrolum = int.TryParse(Console.ReadLine(), out sayim);
                if (!kontrolum)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("HATALI giriş!");
                    Console.ResetColor();
                }

            }

        }
    }
}

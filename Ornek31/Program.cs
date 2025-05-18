namespace Ornek31_BolenBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Örn: girilen sayının bölenlerini bulalım


        Baslangic:
            int sayi = 0;
            bool kontrol;
            Console.WriteLine("Bir sayı giriniz   :");
            kontrol = int.TryParse(Console.ReadLine(), out sayi);
            if (!kontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("HATALI giriş!");
                Console.ResetColor();
                goto Baslangic;
            }

            //8 :  1 2 3 4 5 6 7 8
            //for (int i = 1; i <=sayi; i++)
            Console.WriteLine("Bu sayının bölenleri");
            for (int i = 1; i < sayi + 1; i++)
            {
                if (sayi % i == 0)
                {
                    Console.WriteLine(i);
                    //Console.WriteLine($"{i * -1}");
                }
            }

        }
    }
}

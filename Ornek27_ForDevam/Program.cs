namespace Ornek27_ForDevam
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Kullanıcıdan başlangıç değeri alın
        //Kullanıcıdan bitiş değeri alalım
        //Artış ya da azalış alalım
        Baslangic:
            int baslangic = 0;
            int bitis = 0;
            int degisim = 0;
            bool kontrol = false;

            Console.WriteLine("Başlangıç değeri giriniz   :");
            kontrol = int.TryParse(Console.ReadLine(), out baslangic);
            if (!kontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("hatalı giriş!");
                Console.ResetColor();
                goto Baslangic;
            }
            Console.WriteLine("Bitiş değeri giriniz   :");
            kontrol = int.TryParse(Console.ReadLine(), out bitis);
            if (!kontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("hatalı giriş!");
                Console.ResetColor();
                goto Baslangic;
            }
            Console.WriteLine("Artış ya da azalış giriniz (Artış pozitif azalış için negatif sayı giriniz  :");
            kontrol = int.TryParse(Console.ReadLine(), out degisim);

            if (!kontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("hatalı giriş!");
                Console.ResetColor();
                goto Baslangic;
            }

            Console.WriteLine("İşlem başlıyor...");
            if (degisim >= 0)
            {
                for (int i = baslangic; i <= bitis; i += degisim)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = baslangic; i >= bitis; i += degisim)
                {
                    Console.WriteLine(i);
                }
            }
            goto Baslangic;

        }
    }
}

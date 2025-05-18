namespace Ornek28_27ninFarklisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Baslangic:
            int baslangic = 0;
            int bitis = 0;
            int degisim = 0;
            int secim = 0;
            bool kontrol = false;


            Console.WriteLine("Artan döngü için 1\nAzalan döngü için 2'ye basınız");

            kontrol = int.TryParse(Console.ReadLine(), out secim);
            if (!kontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("hatalı giriş!");
                Console.ResetColor();
                goto Baslangic;
            }

            switch (secim) // switch'teki koşulu 
            {
                case 1: // küçükten büyüğe doğru artarak gidecek
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
                    Console.WriteLine("Kaçar kaçar artsın?   :");
                    kontrol = int.TryParse(Console.ReadLine(), out degisim);
                    if (!kontrol)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("hatalı giriş!");
                        Console.ResetColor();
                        goto Baslangic;
                    }

                    //mesela burada baslangic < bitis mi diye kontrol edebilirsiniz?
                    if (baslangic >= bitis)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("HATA: Artan sayım için başlangıç değeri bitişten küçük olmalıdır!");
                        Console.ResetColor();
                        goto Baslangic;
                    }
                    Console.WriteLine("-------------işlem yapıldı----------------");

                    for (int i = baslangic; i <= bitis; i += degisim)
                    {
                        Console.WriteLine(i);
                    }
                    break;

                case 2: // büüykten küçüğe doğru artarak gidecek
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

                    Console.WriteLine("Kaçar kaçar azalsın?   :");
                    kontrol = int.TryParse(Console.ReadLine(), out degisim);
                    if (!kontrol)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("hatalı giriş!");
                        Console.ResetColor();
                        goto Baslangic;
                    }
                    //mesela burada baslangic < bitis mi diye kontrol edebilirsiniz?
                    if (baslangic < bitis)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("HATA: Azalan sayım için başlangıç değeri bitişten BÜYÜK olmalıdır!");
                        Console.ResetColor();
                        goto Baslangic;
                    }
                    Console.WriteLine("-------------işlem yapıldı----------------");
                    for (int i = baslangic; i >= bitis; i -= degisim)
                    {
                        Console.WriteLine(i);
                    }
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("hatalı seçim!!");
                    Console.ResetColor();
                    goto Baslangic;
                    break;
            }

            //  Console.Clear();
            goto Baslangic;

            //örnek 28 için 
            //ödev: Artış ya da azalış verilen başlangıç ve bitişten çok fazla ya da çok az ya da eşit olmasın!
            //ödev: başlangıç ve bitiş aynı sayılar olmasın!
        }
    }
}

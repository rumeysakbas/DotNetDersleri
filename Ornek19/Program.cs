namespace Ornek19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bu örnek sonraki tekrar yapılacak
            //ÖRN: bir bankanın A  B C şeklinde kampanyaları vardır
            //A miktarı %5 B +200 lira C
            //C içinde bulunduğumuz dakika çiftse %4 tekse %7 
            //Kullanıcıdan miktar alınız.
            //sonra kullanıcı kampanya seçsin
            //eğer o gün kullanıcının dopum günü ise kampanya 2 defa kullanıcya hak versin

            decimal bakiye = 0;
            DateTime dogumTarihi;
            byte kampanyaSecim = 0;
        Baslangic:


            Console.WriteLine(DateTime.Now);
            Console.WriteLine("-------------------");
            Console.Write("Bakiye giriniz   :");
            bool kontrol = decimal.TryParse(Console.ReadLine(), out bakiye);

            if (!kontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hatalı bakiye girişi!");
                Console.ResetColor();
                goto Baslangic;
            }


            Console.Write("Doğum tarihiniz   :");
            kontrol = DateTime.TryParse(Console.ReadLine(), out dogumTarihi);

            if (!kontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hatalı doğum tarihi girişi!");
                Console.ResetColor();
                goto Baslangic;
            }


            Console.WriteLine("\nA kampanyası % 5\nB kampanyası +200\nC kampanyası   bulunduğumuz dakika çiftse %4 tekse %7");
            Console.Write("Kampanya seç   :");
            Console.Write("100 --->A  :");
            Console.Write("101----> B  :");
            Console.Write("102-----> C  :");
            Console.Write("Kampanya seç   :");
            kontrol = byte.TryParse(Console.ReadLine(), out kampanyaSecim);


            if (!kontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hatalı kampanya seçimi!");
                Console.ResetColor();
                goto Baslangic;
            }


            switch (kampanyaSecim)
            {
                case 100:
                    if (dogumTarihi.Day == DateTime.Now.Day && dogumTarihi.Month == DateTime.Now.Month)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Doğum gününüz kutlu olsun");
                        bakiye = bakiye * Convert.ToDecimal(1.10);
                        Console.WriteLine($"A Kampanyası uygulandı. {bakiye} ");

                        Console.ResetColor();
                    }
                    else
                    {
                        bakiye = bakiye * Convert.ToDecimal(1.05);
                        //bakiye = bakiye * decimal.Parse("1.05");
                        //bakiye = bakiye * (decimal)1.05;

                        Console.WriteLine($"A Kampanyası uygulandı. {bakiye} ");
                    }
                    break;


                case 101:
                    if (dogumTarihi.Day == DateTime.Now.Day && dogumTarihi.Month == DateTime.Now.Month)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Doğum gününüz kutlu olsun");
                        bakiye = bakiye + (200 * 2);
                        Console.WriteLine($"B Kampanyası uygulandı. {bakiye} ");
                        Console.ResetColor();
                    }
                    else
                    {
                        bakiye = bakiye + 200;
                        Console.WriteLine($"B Kampanyası uygulandı. {bakiye} ");
                    }
                    break;


                case (byte)Kampanyalar.C:

                    if (DateTime.Now.Minute % 2 == 0 && dogumTarihi.Day == DateTime.Now.Day && dogumTarihi.Month == DateTime.Now.Month)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("dakikamız çift ve doğum günüsü");
                        Console.WriteLine($"Saat: {DateTime.Now.ToString("HH:mm")}");
                        Console.WriteLine("Doğum gününüz kutlu olsun");
                        bakiye = bakiye * Convert.ToDecimal(1.08);
                        Console.WriteLine($"C Kampanyası uygulandı. {bakiye} ");
                        Console.ResetColor();
                    }
                    else if (DateTime.Now.Minute % 2 == 0 && dogumTarihi.Day != DateTime.Now.Day && dogumTarihi.Month != DateTime.Now.Month)
                    {
                        // çift  %4
                        bakiye = bakiye * Convert.ToDecimal(1.04);
                        Console.WriteLine($"Saat: {DateTime.Now.ToString("HH:mm")}");
                        Console.WriteLine($"C Kampanyası uygulandı. {bakiye} ");
                    }
                    else if (DateTime.Now.Minute % 2 != 0 && dogumTarihi.Day == DateTime.Now.Day && dogumTarihi.Month == DateTime.Now.Month)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("dakikamız tek ve doğum günüsü");
                        Console.WriteLine($"Saat: {DateTime.Now.ToString("HH:mm")}");
                        Console.WriteLine("Doğum gününüz kutlu olsun");
                        bakiye = bakiye * Convert.ToDecimal(1.14);
                        Console.WriteLine($"C Kampanyası uygulandı. {bakiye} ");
                        Console.ResetColor();
                    }
                    else if (DateTime.Now.Minute % 2 != 0 && dogumTarihi.Day != DateTime.Now.Day && dogumTarihi.Month != DateTime.Now.Month)
                    {
                        // tek  %7
                        bakiye = bakiye * Convert.ToDecimal(1.07);
                        Console.WriteLine("dakikamız tek ve doğum günü değil");
                        Console.WriteLine($"Saat: {DateTime.Now.ToString("HH:mm")}");
                        Console.WriteLine($"C Kampanyası uygulandı. {bakiye} ");

                    }

                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Böyle bir kampanya tanımlı değil!");
                    Console.ResetColor();
                    goto Baslangic;
                    break;
            }

            goto Baslangic;



        }
    }

    public enum Kampanyalar
    {
        A = 100,
        B = 101,
        C = 102
    }
}

using System;

namespace Ornek20
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //ÖRN: bir bankanın A  B C şeklinde kampanyaları vardır
            //A miktarı %5 B +200 lira C
            //C içinde bulunduğumuz dakika çiftse %4 tekse %7 
            //Kullanıcıdan miktar alınız.
            //sonra kullanıcı kampanya seçsin
            //eğer o gün kullanıcının dopum günü ise kampanya 2 defa kullanıcya hak versin

            decimal bakiye = 0;
            DateTime dogumTarihi;
            char kampanyaSecim;
        Baslangic:
            Console.ResetColor();

            Console.Write("Bakiye giriniz   :");
            bool kontrolbakiye = decimal.TryParse(Console.ReadLine(), out bakiye);

            Console.Write("Doğum tarihiniz   :");
            bool kontroltrh = DateTime.TryParse(Console.ReadLine(), out dogumTarihi);

            Console.WriteLine("\nA kampanyası % 5\nB kampanyası +200\nC kampanyası   bulunduğumuz dakika çiftse %4 tekse %7");
            Console.Write("Kampanya seç   A ya da B ya da C:");
            bool kontrolkampanya = char.TryParse(Console.ReadLine(), out kampanyaSecim);

            if (!kontrolbakiye || !kontrolkampanya || !kontroltrh)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("girişlerinizde hata var! Başa gidin!");
                goto Baslangic;
            }
            // else yazmadım çünkü ife girerse zaten aşağı inemez!


            switch (kampanyaSecim)
            {
                case 'C':
                case 'c':

                    if (DateTime.Now.Day == dogumTarihi.Day && DateTime.Now.Month == dogumTarihi.Month)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Doğum gününüz kutlu olsun!");
                        if (DateTime.Now.Minute % 2 == 0)
                        {
                            //çift
                            Console.WriteLine("dakikamız çift ve doğum günüsü");
                            Console.WriteLine($"Saat: {DateTime.Now.ToString("HH:mm")}");
                            bakiye = bakiye * Convert.ToDecimal(1.08);
                            Console.WriteLine($"C Kampanyası uygulandı. {bakiye} ");
                        }
                        else
                        {
                            // tek
                            Console.WriteLine("dakikamız tek ve doğum günüsü");
                            Console.WriteLine($"Saat: {DateTime.Now.ToString("HH:mm")}");
                            bakiye = bakiye * Convert.ToDecimal(1.14);
                            Console.WriteLine($"C Kampanyası uygulandı. {bakiye} ");
                        }

                        Console.ResetColor();


                    }

                    else
                    {

                        if (DateTime.Now.Minute % 2 == 0)
                        {
                            //çift
                            bakiye = bakiye * Convert.ToDecimal(1.04);
                            Console.WriteLine($"C Kampanyası uygulandı. {bakiye} ");
                        }
                        else
                        {
                            // tek

                            bakiye = bakiye * Convert.ToDecimal(1.07);
                            Console.WriteLine($"C Kampanyası uygulandı. {bakiye} ");
                        }

                    }





                    break;
                default:
                    break;
            }

            goto Baslangic;

        }

    }
}


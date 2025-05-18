namespace Ornek29_Faktoryel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Örn: bir sayının faktöryel hesaplaması
            int sayi = 7; // 5 4 3 2 1
            int sonuc = 1;

            for (int i = sayi; i >= 1; i--)
            {
                sonuc = sonuc * i;
                // sonuc *= i;
            }

            Console.WriteLine($"Faktöryel sonuç= {sonuc}");
            Console.WriteLine($"{sayi}!= {sonuc}");

            //ödev: Örnek 29 için Kullanıcıdan sayı alarak bu örneği tekrar yapınız!
        }
    }
}

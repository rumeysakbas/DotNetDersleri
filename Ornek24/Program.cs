namespace Ornek24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 10; //başlangıç değeri

        Baslangic:
            if (sayac >= 1) // koşul
            {
                Console.WriteLine(sayac);
                // Console.WriteLine("Betül");
                //sayac = sayac - 1; // azalma
                //sayac -= 1;
                sayac--;
            }

            goto Baslangic;
        }
    }
}

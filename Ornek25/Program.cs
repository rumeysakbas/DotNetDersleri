namespace Ornek25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int sayac = 2; //başlangıç değeri

            //Baslangic:
            //    if (sayac <= 10) // koşul
            //    {
            //        Console.WriteLine(sayac);
            //     //   Console.WriteLine("Betül");
            //        //  sayac = sayac + 2; // artış azalış
            //        sayac += 2;

            //    }

            //    goto Baslangic;


            int sayac = 10; //başlangıç değeri

        Baslangic:
            if (sayac >= 0) // koşul
            {
                Console.WriteLine(sayac);
                //   Console.WriteLine("Betül");
                sayac = sayac - 2; // artış azalış
                                   //  sayac -= 2;

            }

            goto Baslangic;
        }
    }
}

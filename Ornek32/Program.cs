namespace Ornek32_WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while : iken anlamına gelir
            //şart sağlandığı sürece bu döngü döner!
            //1den 10 a kadar sayıları ekrana yazmak
            int sayac = 1;

            while (sayac <= 10) // sayac < 11
            {
                Console.WriteLine(sayac);
                //sayac++;
                sayac += 2;
            }

            Console.WriteLine("------");
            int sayacim = 10;

            while (sayacim >= 1) // sayacim > 0
            {
                Console.WriteLine(sayacim);
                //sayacim--;
                sayacim -= 3;
            }
        }
    }
}

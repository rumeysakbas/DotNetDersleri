namespace Ornek23_DongulereGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Döngü: Tekrar eden işlem ya da kod bloğudur.
            //Tekrar eden bir işlemi kolayca devam ettirmek için de kullanılır.

            int sayac = 1; //başlangıç değeri

        Baslangic:
            if (sayac <= 10) // koşul
            {
                //Console.WriteLine(sayac);
                Console.WriteLine("Rumeysa");
                sayac = sayac + 1; // artış azalış
                //sayac += 1;
                //sayac++;
            }

            goto Baslangic;
        }
    }
}

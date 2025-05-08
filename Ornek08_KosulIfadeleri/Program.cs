namespace Ornek08_KosulIfadeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programın iş akışına göre sorgulanması istenen kuralların 
            //if ya da swicth case ile koşula tabi tutulmasıdır.

            //if eğer demektir.
            if (5 < 10) // condition şart
            {
                Console.WriteLine("5 sayısı 10dan küçüktür!");
            }

            if (1 != 0) // eğer şart sonucu true ise ife girer
            {
                Console.WriteLine("koşula girdi. 1 eşit değildir sıfır!");
            }

            if (2 == 2)
            {
                Console.WriteLine("2=2");
            }


            Console.WriteLine("Sayı giriniz  :");
            byte sayi = 0;
            bool kntrl = byte.TryParse(Console.ReadLine(), out sayi);

            //if (kntrl==true)
            //{

            //}
            if (kntrl)
            {
                Console.WriteLine("Değer geçerlidir. Bir sonraki adıma gidelim");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; //atama yaptı. buradaki yapılar nedir?
                //ilerleyen derse öğreneceksinzi.
                Console.WriteLine("Lütfen geçerli sayı girişi yapınız!");
                Console.ResetColor(); // ekranı default rengine çevir
            }
        }
    }
}

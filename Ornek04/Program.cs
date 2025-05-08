namespace Ornek04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //c#'ta bulunan değişken tipleriyle değişkenler tanımlanır
            //char string 
            //int byte long short decimal double

            string ad = "Rumeysa";
            Console.WriteLine("Soyadınız girin   :");
            string soyad = Console.ReadLine();

            Console.WriteLine("Kilo giriniz  :");
            //double kilo = Console.ReadLine();

           
            Console.WriteLine("Doğum Tarihinizi giriniz  :");
            DateTime dogumTarihi = new DateTime(28, 01, 2004); 
            // değişken  INSTANCE alınarak da tanımlanabilir.Instance new kelimesi ile yazmaktır.
            //Bir classtan ya da bir structtan new keywordü ile nesne türetmektir.

            //Datetime demekki bir structmış. Struct class gibi kavramları ilerde öğreneceğiz.

        }
    }
}

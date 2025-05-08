namespace Ornek05_Convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Convert: dönüştürmek
            //C# tip bağımlı bir dildir. Bu nedenle alınan dataların içlerine yerleştirilecek değişkenlere göre tür ya da tip dönüşümleri gerekmektedir.
            Console.WriteLine("Kilo giriniz  :");
            double kilo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Harf giriniz  :");
            char girilenHarf = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Ürün stok adeti giriniz  :");
            int stok = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Son kull tarihi giriniz :");
            DateTime sonKulTrh = Convert.ToDateTime(Console.ReadLine());


            //Yöntem 2 : Parse 
            Console.WriteLine("Sayı giriniz  :");
            int sayi = int.Parse(Console.ReadLine());

            char harf = char.Parse(Console.ReadLine());

            double deger = double.Parse(Console.ReadLine());

            DateTime trh = DateTime.Parse(Console.ReadLine());
        }
    }
}

using System.Text;

namespace Ornek07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stok adet giriniz  :");
            byte stok = 0;//değişken tanımlandı ve ilk değeri verildi.
            bool kontrol = byte.TryParse(Console.ReadLine(), out stok);


            //yöntem 1
            Console.WriteLine("Girilen değer uygun mu? " + kontrol);
            //yöntem 2
            Console.WriteLine($"Girilen değer uygun mu? {kontrol}");
            //Dolar işareti gelmeden önce nasıl yazıyorlardı?
            //cevap: yöntem 1
            // ve aşağıdaki şekillerde yazılırdı.

            Console.WriteLine(string.Format("Girilen değer uygun mu? ", kontrol));

            Console.WriteLine("Girilen değer uygun mu? cevap: {0}, değer : {1}", kontrol, stok);

            //string builder
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Girilen değer uygun mu? ");
            // sb.AppendLine(Convert.ToString(kontrol));
            sb.AppendLine(kontrol.ToString());
        }
    }
}

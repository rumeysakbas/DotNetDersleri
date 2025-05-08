namespace Ornek15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Örn: kullanıcı 1-15 arasında değer girsin. Girilen değere karşılık gelen renk ile ekranın yazı rengini ayarlayalım.

            //int renkDegeri = 15;
            int renkDegeri;
        Baslangic:
            renkDegeri = Convert.ToInt32(ConsoleColor.White);
            Console.Write("1-15 arasında değer giriniz   :");
            bool kontrol = int.TryParse(Console.ReadLine(), out renkDegeri);

            if (!kontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("HATALI giriş!");
                Console.ResetColor();
                goto Baslangic;
            }
            else if (renkDegeri > 15 || renkDegeri < 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Bu sayı değerine karşılık bir renk yok!!");
                Console.ResetColor();
                goto Baslangic;
            }
            else
            {
                Console.ForegroundColor = (ConsoleColor)renkDegeri; // cast etmek
                Console.WriteLine("Renk değişti");
                Console.ResetColor();
            }
            Console.WriteLine("\n");
            goto Baslangic;
        }
    }
}

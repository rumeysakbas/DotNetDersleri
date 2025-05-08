namespace Ornek09
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
        // Kullanıcıdan yaş isteyiniz ve 18 ile 70 yaşı arasındakilere onay verilecek  //diğer aralıktakileri kayıt etmeyelim
        Baslangic:
            byte yas = 0;
            Console.WriteLine("Yaşınızı giriniz   :");
            bool kontrol = byte.TryParse(Console.ReadLine(), out yas);

            if (!kontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hatalı giriş! ");
                Console.ResetColor();
            }
            else if (yas < 18 || yas > 70)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Yaş aralığının 18 -70 arasında olması gerekmektedir! ");
                Console.ResetColor();

            }
            else
            {
                Console.WriteLine("İşleminiz BAŞARILIDIR!");
            }

            goto Baslangic;

            //if tek başına kullanılabilir
            //if - else olarak kullanabilir
            //if - else if ... kullanılabilir
            //if - else if ... esle kullanılabilir
        }
    }
}

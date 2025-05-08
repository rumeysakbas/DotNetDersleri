namespace Ornek17_switchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gun;
        baslangic:

            Console.WriteLine("1-7 arasında değer giriniz  :");
            bool kontrol = int.TryParse(Console.ReadLine(), out gun);
            if (!kontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lütfen sayı girdiğinize emin olun!");
                Console.ResetColor();
            }
            else
            {
                switch (gun)
                {
                    case 1:
                        Console.WriteLine("Pazartesi");
                        break;

                    case 2:
                        Console.WriteLine("Salı");
                        break;
                    case 3:
                        Console.WriteLine("Çarşamba");
                        break;
                    case 4:
                        Console.WriteLine("Perşembe");
                        break;
                    case 5:
                        Console.WriteLine("cuma");
                        break;
                    case 6:
                    case 7:
                        Console.WriteLine("haftasonu");
                        break;
                    default:
                        Console.WriteLine("Girdiğiniz değer hatalı!");
                        break;
                }
            }

            Console.WriteLine();
            goto baslangic;

        }
    }
}

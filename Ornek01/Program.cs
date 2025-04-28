namespace Ornek01 //namespace proje adıdır 
{
    internal class Program // class bölümü
    { 

        static void Main(string[] args) //çalışan ana metot(main)
        {// metodun başladığı yer 
            Console.WriteLine("Rümeysa AKBAŞ"); // Console ekranına yazı yazıyor ve ; kodu okuması için gerekli

            //Console // classlar ve metotlar ilk harfi büyük olur !!

            //WriteLine bir satır aşağı ekrana yazı yazdırır ve imleci bir satır aşağı indirir

            Console.Write("Deneme");

            //Write aşağı inmeden yazı yazdırır imleç yazdığı yerde kalır
            /*
             * Console: Konsol ekranı denilen siyah ekran üzarinde girdi alınması çıktı verilmesi işlemlerinde kullanılan sınıtır. 
             * \n = enter
             * \t = tab
             */

            //MOR KÜP = METOT

            Console.WriteLine("Rümeysa\n AKBAŞ");
            Console.WriteLine("Rümeysa\t AKBAŞ");

            //girdiler niteliklerine göre ayrılır
            /*
             * c# tip bağımlı bir dildir 
             * değişkenlerin amacı daha sonra kullanabilmek için verileri depolamaktır. veriyi tutan yapıdır . tiplerin olması gerekir 
             * kesirli sayı = float, money = decimal
            */

            int a;
            string ad;
            char harf;
            double kilo;
            bool ehliyetVarMi;
            //gözümüzün aşina olduğu tiplerden farklı olarak değişken tanımlayabiliriz
            DateTime dogumtarihi; // struct
            string soyad = "AKBAŞ"; // hem değişken tanımladım hem de kullandım
            ad = "Rümeysa"; // daha önce tanımlanmış olan değişkeni kullandım değer atadım. 
            harf = 'R';// CHAR TEK TIRNAK
            kilo = 80.20;
            Console.WriteLine(kilo);
        }//metotun bittiği yer 
    }//class bitti
}//proje bitti


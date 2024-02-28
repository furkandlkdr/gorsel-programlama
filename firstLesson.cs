
    internal class Program
    {
        public static int globalNumber = 10;
        static void Main(string[] args)
        {
            // C# tekrarı ve konu anlatımı

            Console.WriteLine(DateTime.Now.Year.ToString() + " " + DateTime.Now.Month + " çok iyi bir ay olacak");
            //System.ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            //if (KeyInfo.Key == ConsoleKey.Escape)
            //{
            //    Console.WriteLine("Çıkış yapıldı");
            //    System.Environment.Exit(0);
            //} Bu şekilde kısayollar da tanımlayabiliriz

            // readonly ve const arasındaki farka bak
            // const derleme zamanında değeri atanmış olmalı
            // readonly çalışma zamanında atanabiliyor

            // Referans ve değer değişken türleri var referans dediğimiz dizi, string gibi adres tutan değişkenlerdir
            // Stack 'te adres tutulur, heap'te veri tutulur 

            string ad = "Furkan";

            // Heap 'te memoryAdress = furkan tutulur
            // stack'te degişken adı = memoryAdress tutulur.

            // Stack belirli bir kapasitede çalışır ve alanımız kısıtlıdır. Bir şey tanımlayacaksak boyutunu belirtmeliyiz.
            // heap alan adreslere karşılık gelen verileri tuttuğu için daha dinamiktir. Garbage collector yardımıyla bellekten düşümü yapılır

            // Object ile tanımlanmış referans tipli veri, hata üretir ve kontrole izin verir
            // Dynamic ile tanımlanmış referans tipli veri hata üretmez ve kontrol edilemez

            /* ****************************************************************** */

            // global ve local değişkenlerin farkı

            // Console.WriteLine("Global Number: ", globalNumber);


            // boxing ve unboxing bak
            // object boxing = degisken;

            // degisken.GetType() === typeof (byte) ile byte mı değil mi ona bakıyoruz
            // degisken.GetType().ToString() === "System.Byte" şeklinde bir kontrol de yapabiliriz

            // tip dönüşümlerinde string b = 2.5 + "" yaparsak string olarak "2.5" olur.

            // is ve as operatörleri
            // Dönüşüm esnasında oluşan bir hatayı yönetebilmek için is ve as operatörlerini kullanıyoruz
            // object a = 21.5      if (a is int) yaparsak a int oldu mu diye bakıyoruz
            // as ise doğruysa true, tutmazsa null dönüyor

            // Parse string türündeki bir veriyi belirtilen bir veri türüne dönüştürmek amacıyla kullanılır
            // Parse hata dönderip programı kapattığı için kullandığımız yerlere dikkat etmemiz gerekiyor
            // Parse null exception, format exception ve overflow exception hatalarını dönderiyor.
            // TryParse ise hata oluşturduğunda 0 değerini döndererek programımızın devamını sağlıyor.
            // TryParse degiskentürü.TryParse(dönüştürelecek değer, out sonuç değer);

            // Convert fonksiyonu null değere sahipse 0, farklı bir değişken türüne sahipse formatexception hatası dönderir.

            // Convert ve parse ile ilgili chatgptye sorarak örnekler çöz

            // Kullanıcı tanımlı veri tipleri: struct, class, enum
            // struct StructAdi{
            //  public değişkenTipi değişkenAdı;
            // }

            // Haftaya struct devam edecek

            // Aritmetik operatörler
            // -> ve <- operatörleri while içerisine yazılarak birer birer azalt veya arttır anlamına gelir
            // while (15 -> 0) 


            // // // Pattern Matching


            // Type pattern ?? if (sayi is int) gibi kontrol aşamasında bu ise x'e ata demek için if (sayi s int x) yazabiliyoruzi.

            // Constant Pattern if (x is 128) şeklinde yazarak x 125 mi diye kontrol ediyoruz.

            // object x = "Türkiye" ve if (x is var a) diyerek a ya atayabiliyoruz?

            // switch case içerisinde de pattern matching kullanabiliyoruz ve bu şekilde SQL sorgularımız çok koloy oluyor
            object deger = 5;
            switch (deger)
            {

            }
            // Recursive Pattern ileride tekrar dönülecek

            // if yapısı ile sayı tahmin oyunu yapın
            // renk değiştirme form uygulamasi
            // Yaş ve ad bilgisiyle patternMatching kullanarak mesajlar ver hata kontrolü yap

            Console.ReadLine();
        }
    }

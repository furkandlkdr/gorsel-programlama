using System.Collections;
using System.Diagnostics.Tracing;

namespace Ders2
{
    internal class Program
    {
        struct firstLessonContinue
        {
            //struct personnel
            //{
            //    public int id;
            //    public string name;
            //    public int age;
            //    public double salary;
            //    public struct CEO
            //    {
            //        public string ceoAttr;
            //    }
            //}

            //enum Gunler
            //{
            //    Pazartesi,
            //    Salı,
            //    Çarşamba,
            //    Perşembe,
            //    Cuma,
            //    Cumartesi,
            //    Pazar
            //}

            //enum uzmanlık
            //{
            //    VBNet = 1,
            //    CSharp = 2,
            //    ASPNet = 4,
            //    PHP = 8,
            //    Python = 10,
            //    Perl = 20
            //}
        }

        static void Main(string[] args)
        {
            void firstLessonCont()
            {
                //personnel p1 = new personnel();
                //personnel[] pArray = new personnel[5];
                //pArray[0] = p1;
                //personnel.CEO ceo = new personnel.CEO();
                //ceo.ceoAttr = "Can open big gate";

                // Struct kullanımı, public olmalı ve içerisine fonk alabiliyor.

                // Enum içerisinde bir elemanın tanımlanıp tanımlanmadığını bulmakj için kullanılır.
                // if (Gunler.IsDefined(typeof(Gunler), "Pazartesi")) şeklindeki kontrol pazartesinin olup olmadığını kontrol ediyor.
                //Gunler gunAdi;
                //gunAdi = (Gunler) 1;
                //Console.WriteLine(gunAdi.ToString());
                //Console.WriteLine(gunAdi.ToString("G")); General anlamına gelir ve enum olarak yazdırır
                //Console.WriteLine(gunAdi.ToString("d")); Decimal anlamına gelir ve decimal karşılığını yazdırır
                //Console.WriteLine(gunAdi.ToString("F")); Flag olarak yazdırır ve enum değerinin string karşılığını yazdırır
                //Console.WriteLine(gunAdi.ToString("x")); Hexadecimal olarak yazdırır ve enum değerinin hexadecimal karşılığını gösterir.

                //uzmanlık dildeUz = uzmanlık.VBNet | uzmanlık.CSharp;
                //Console.WriteLine(dildeUz.ToString());
                //Console.WriteLine(dildeUz.ToString("G"));
                //Console.WriteLine(dildeUz.ToString("d")); 
                //Console.WriteLine(dildeUz.ToString("F")); // Flag olarak grubu yazdırdığı için VBNet ve CSharp yazar diğerleri 3 yazar
                //Console.WriteLine(dildeUz.ToString("x")); 
            }

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 2) continue;
            //    Console.WriteLine("i" + i);
            //    if (i == -1) break;
            //    Console.WriteLine("TAB");
            //}

            //int sutun = 1, satir = 0;
            //for (int i = 1; i < 11; i++) {
            //    for (int j = 1; j < 11; j++){
            //        Console.SetCursorPosition(sutun, satir + j);
            //        Console.WriteLine(i + "x" + j + " = " + i*j +" ");    }
            //    sutun = sutun + 14;
            //    if (i == 5){
            //        sutun = 1;
            //        satir = 13;    }    }

            // Form için foreach ile nesne kontrolü
            //private void Form1_Load(object sender, EventArgs e)
            //{
            //    foreach( Control nesne in this.Controls) {
            //        if ((nesne) is TextBox) {
            //            nesne.Text = " ";
            //            nesne.BackColor = Color.Salmon;
            //            nesne.ForeColor = Color.Snow;
            //        }    }    }

            //int toplam = 0;
            //do{
            //    Console.WriteLine("Sayi girin:");
            //    string userInput = Console.ReadLine();
            //    toplam += Convert.ToInt32(userInput);
            //    if (userInput == "0") break;
            //} while (true);
            //Console.WriteLine("Toplam = ", toplam);

            //int[] dizi = { 1, 2, 3 };
            //int[] dizi2 = new int[3];
            //string[,] adSoyad = { { "Banu", "Aktaş", "Selamlar" }, { "Furkan", "Dulkadir" , "Selamlar" } };
            //adSoyad.GetLength(0); // yazarak 2 sayısına
            //adSoyad.GetLength(1); // yazarak 3 sayısına ulaşıyoruz.
            //int[][] duzensizDizi = { new int[] { 1 }, new int[] { 1, 2, 3 }, new int[] { 1, 2 } }; // Duzensiz dizileri bu şekilde tanımlayabiliyoruz.

            //dizi2 = new int[5]; // Yaparsak içerisindeki verileri kaybeder ve yeni bir dizi oluşturur.
            //Array.Resize(ref dizi, 5); // yaparak içerisindeki verileri koruyarak 5 boyutlu bir dizi oluştururuz.

            //Array okulTuru = Array.CreateInstance(typeof(string), 3);
            //string[] okulTurleri = (string[]) okulTuru; // Bu şekilde de atayabiliriz.

            //Array diller = Array.CreateInstance(typeof(string), 3, 4); // Çok boyutlu bir dizi
            //diller.SetValue("C#", 0); // Veya bu şekilde atayabiliriz
            //diller.SetValue("C++", 1);
            //Console.WriteLine(diller.GetValue(1)); // ile erişebiliriz.


            //Type tip;
            //tip = diller.GetType();
            //if (tip.IsArray) { Console.WriteLine("Arraymış"); }

            //string.Join(",", array)
            //Array.Copy(sourceArray, destinationArray, indexCount);
            //Array.Copy(kaynakDizi, kaynakIndis, hedefDizin, hedefIndex, elemanSayisi);

            //dizi.Contains(içeriyor mu diye bakılacak veri);
            //Array.IndexOf(hedefDizi, aranacak.ToString(), baslangicIndexi);
            //Array.BinarySearch(dizininAdi, aranacak.ToString()); //indeks dönderir, dizi sıralı olmalı


            void Koleksiyonlar()
            {
            //NonGeneric koleksiyolar: ArrayList, HashTable ve SortedList
                ArrayList isimler = new ArrayList(); // İçerisinde tutulan veriler objelerden oluştuğu için boxing ve unboxing kullanılır
                isimler.Add("Denemelik bir şeyler");
                isimler.Add(555444); // Sonuna ekler
                isimler.Insert(0, "Sumeyye"); // 0. index'e bunu ekler diğerlerini kaydırır
                Console.WriteLine(isimler.Count); //Uzunluğunu yazdırır
                isimler.Remove("Denemelik bir şeyler"); // elemanı kaldırır
                isimler.RemoveAt(2); // 2. indisi kaldırır
                Console.WriteLine(isimler.Capacity); //Eleman sayısı + 4 / 4 kadar yer açılır, onu gösterir

                isimler.GetRange(0, isimler.Count); // 0. indisten, virgülden sonraki eleman kadar dönderir.
                ArrayList yeniIsimler = new ArrayList();
                yeniIsimler.AddRange(isimler);
                yeniIsimler.InsertRange(2, isimler);
                yeniIsimler.RemoveRange(2, 3); //2den başlar 3ile arasındakini siler
                // CopyTo ? Diziyi ArrayList'e kopyalıyor


            }
            Koleksiyonlar();

        }
    }
}

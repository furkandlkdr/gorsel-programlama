namespace Odev2_1
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Farklı veri türlerinden elemanlar içeren bir dizi oluşturma
            Array myArray = Array.CreateInstance(typeof(object), new int[] { 5 });
            myArray.SetValue(10, 0);
            myArray.SetValue("Merhaba", 1);
            myArray.SetValue(3.14, 2);
            myArray.SetValue(true, 3);
            myArray.SetValue('A', 4);

            // Dizinin boyutunu ve uzunluğunu yazdırma
            Console.WriteLine("Dizinin boyutu: {0}", myArray.Rank);
            Console.WriteLine("Dizinin uzunluğu: {0}", myArray.Length);

            // Belirli bir elemanı bulma ve yazdırma
            int arananIndex = 2;
            object bulunanEleman = myArray.GetValue(arananIndex);
            Console.WriteLine("Dizinin {0}. indisindeki eleman: {1}", arananIndex, bulunanEleman);

            // Diziyi sıralama ve yazdırma
            Array.Sort(myArray);
            Console.WriteLine("Sıralanmış dizi:");
            foreach (object eleman in myArray)
            {
                Console.WriteLine(" - {0}", eleman);
            }

            // Belirli bir elemanın indeksini bulma
            object arananDeger = 'A';
            int bulunanIndeks = Array.IndexOf(myArray, arananDeger);
            Console.WriteLine("{0} değerinin dizideki indeksi: {1}", arananDeger, bulunanIndeks);

            // Diziyi tersine çevirme ve yazdırma
            Array.Reverse(myArray);
            Console.WriteLine("Tersine çevrilmiş dizi:");
            foreach (object eleman in myArray)
            {
                Console.WriteLine(" - {0}", eleman);
            }

            // Diziyi belirli bir aralıkta kopyalama ve yazdırma
            int baslangicIndeks = 1;
            int kopyalanacakElemanSayisi = 3;
            Array kopyalananDizi = Array.CreateInstance(typeof(object), new int[] { kopyalanacakElemanSayisi });
            Array.Copy(myArray, baslangicIndeks, kopyalananDizi, 0, kopyalanacakElemanSayisi);
            Console.WriteLine("Kopyalanan dizi:");
            foreach (object eleman in kopyalananDizi)
            {
                Console.WriteLine(" - {0}", eleman);
            }
        }
    }

}

namespace Odev2_1
{
    using System;

    public class Program
    {
        static void Main(string[] args)
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
            int index = Array.IndexOf(myArray, 3.14);
            if (index != -1)
            {
                Console.WriteLine("Bulunan eleman: {0} (indis: {1})", myArray.GetValue(index), index);
            }
            else
            {
                Console.WriteLine("Eleman bulunamadı!");
            }

            // Diziyi sıralama ve yazdırma
            Array.Sort(myArray);
            Console.WriteLine("Sıralanmış dizi:");
            foreach (object element in myArray)
            {
                Console.WriteLine(element);
            }

            // Belirli bir elemanın indeksini bulma
            index = Array.IndexOf(myArray, 'A');
            Console.WriteLine("Elemanın indeksi: {0}", index);

            // Diziyi tersine çevirme ve yazdırma
            Array.Reverse(myArray);
            Console.WriteLine("Tersine çevrilmiş dizi:");
            foreach (object element in myArray)
            {
                Console.WriteLine(element);
            }

            // Diziyi belirli bir aralıkta kopyalama ve yazdırma
            Array myArrayCopy = Array.CreateInstance(typeof(object), new int[] { 3 });
            Array.Copy(myArray, 1, myArrayCopy, 0, 3);
            Console.WriteLine("Kopyalanan dizi:");
            foreach (object element in myArrayCopy)
            {
                Console.WriteLine(element);
            }
        }
    }

}

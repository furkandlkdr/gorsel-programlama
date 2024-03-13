using System.Collections;

namespace Ders3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable siniflar = new Hashtable();
            siniflar.Add("E10A", "Endüstri Meslek");
            siniflar.Add("E10B", "Endüstri Lise");
            // Hashtable bir key ve value üzerinden çalışıyor
            foreach (DictionaryEntry item in siniflar){
                Console.WriteLine(item.Key + " " + item.Value);
            }
            siniflar[2] = ("Anadolu");
            if (siniflar.ContainsKey("E10A")) Console.WriteLine("I found 'e10a' key");
            if (siniflar.ContainsValue("Endüstri Lise")) Console.WriteLine("I found 'Endüstri Lise' value");

            void GenericKoleksiyonlar()
            {
                // Değişken tipini vermek zorunda olduğumuz için boxing - unboxing 'e ihtiyaç kalmıyor ve performansımız artıyor
                void list(){
                    List<string> list = new List<string>();
                    //List sınıfı arrayList'in karşılığı, sadece generic olan versiyonu
                    // ArrayList ile kullanılan tüm fonksiyonlar burada da çalışıyor.
                }
                void stack(){
                    //last in first out
                    Stack<string> stack = new Stack<string>();
                    stack.Push("Deneme1");
                    stack.Push("Deneme2");
                    Console.WriteLine(stack.Pop());
                    stack.ElementAt(1); //dersek, deneme1 'e ulaşırız. Her yeni element eklendiğinde 0'a atanıyor. Normal diziye göre tersten indexlenir
                    Console.WriteLine(stack.Peek()); // en üstteki elemanı gösterir.
                }
                void queue(){
                    //first in first out
                    Queue<string> queue = new Queue<string>();
                    queue.Enqueue("Deneme1");
                    queue.Enqueue("Deneme2");
                    queue.Dequeue(); // pop ile aynı işlev
                    Console.WriteLine(queue.Peek()); // deneme1 yazdırır.
                }
                void LinkedList(){
                    LinkedList<string> list = new LinkedList<string>();
                    list.AddLast("Deneme1");
                    list.AddLast("Deneme2");
                    list.AddLast("Deneme3");
                    list.Remove("Deneme2"); // yaptığımızda kendiliğinden bağlama yapar.
                    //list.RemoveLast();
                    //list.AddBefore(list.Find("Deneme2")); // hata veriyor ama buna yakın bir şey yazıyoruz
                }
                void Dictionary(){
                    Dictionary<string,string> dic = new Dictionary<string,string>();
                    dic.Add("Banu Ulu", "Programlama");
                    dic.Add("Burak KARAHAN", "Programlama");
                }
                void SortedDictionary(){
                    SortedDictionary<string, int> sortedDic = new SortedDictionary<string, int>() { { "Talha AKTAS", 101 }, { "Azra AKTAS", 22 } };
                } // Key'e göre sıralar
                void indexVariable(){
                    Index i1 = 2; //Bastan 2. indexe ulaşırız
                    Index i2 =^ 3; //Sondan 2. indexe ulaşırız (Dizide vs kullandığımzda
                } // pdf 65 - 83 arası yok
            }

        }
    }
}

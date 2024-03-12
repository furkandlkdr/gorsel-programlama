using System.Collections;

namespace Odev2
{
    internal class Program
    {
        class Book{
            public int Id { get; set; }
            string title;
            string publisher;
            public Book(string title, string publisher, int id){
                this.title = title;
                this.publisher = publisher;
                Id = id;
            }
            public string GetTitle(){ return title; }
            public string GetPublisher() { return publisher; }
            public void SetPublisher(string publisher) { this.publisher = publisher; }
        }
        class Library{
            public ArrayList Books;
            int id = 0;
            public Library(){
                Books = new ArrayList();
                Book book = new Book("C# Programming", "Microsoft", id++);
                Books.Add(book);    
            }
            public void AddBook(string title, string publisher){
                Book book = new Book(title, publisher, id++);
                Books.Add(book);    
            }
            public void ListAllBooks(){
                Console.WriteLine(" All books:");
                foreach (Book book in Books){
                    Console.WriteLine(book.Id + " " + book.GetTitle() + ", Publisher: " + book.GetPublisher());    }    
            }
            public void ListByPublisher(string publisher){
                int bookCount = 0;
                foreach (Book book in Books){
                    if (book.GetPublisher() == publisher)
                        Console.WriteLine(book.Id + " " + book.GetTitle() + ", Publisher: " + book.GetPublisher()); bookCount++;    
                }
                if (bookCount == 0) { Console.WriteLine("There is no book published by " + publisher); }
            }
            public void ChangePublisher(int id, string publisher){
                int bookCount = 0;
                foreach (Book book in Books)
                {
                    if (book.Id == id){
                        book.SetPublisher(publisher);
                        bookCount++;    }    }
                if (bookCount == 0) { Console.WriteLine("There is no book with the id " + id); }
            }
        }
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddBook("Java Programming", "Oracle");
            library.AddBook("Python Programming", "Python Software Foundation");
            library.AddBook("C++ Programming", "Microsoft");
            library.AddBook("C Programming", "Microsoft");
            library.ListAllBooks();
            Console.WriteLine("\n Publisher = Microsoft only");
            library.ListByPublisher("Microsoft");
            Console.WriteLine("\n Publisher = Oracle only");
            library.ListByPublisher("Oracle");
            Console.WriteLine("\n");
            library.ChangePublisher(1, "Microsoft Cooperation");
            library.ChangePublisher(2, "Oracle Cooperation");
            library.ListAllBooks();
        }
    }
}

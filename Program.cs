namespace basics_cSharp01
{

    internal class Program
    {
        class Book
        {
            public string title;
            public int pages;


        }
        static void Main(string[] args)
        {
            Book book = new Book();
            book.title = "c# basics";
            book.pages = 500;

            object obj = book;
            Console.WriteLine(obj);
        }
    }
}
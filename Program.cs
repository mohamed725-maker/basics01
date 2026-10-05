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
            #region q1

           
            Book book = new Book();
            book.title = "c# basics";
            book.pages = 500;

            object obj = book;
            Console.WriteLine(obj);
            #endregion

            #region 2
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(obj.GetHashCode());
            Console.WriteLine(obj.GetType());
            #endregion
        }
    }
}
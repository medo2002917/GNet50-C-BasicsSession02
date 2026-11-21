namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q01
            Book book = new Book();
            book.Title = "Clean Code";
            book.Pages = 464;

            object bookObject = book;
            Console.WriteLine(bookObject);

            // Q02
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
        }
    }

    internal class Book
    {
        public string Title = "";
        public int Pages;
    }
}

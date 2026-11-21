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
        }
    }

    internal class Book
    {
        public string Title = "";
        public int Pages;
    }
}

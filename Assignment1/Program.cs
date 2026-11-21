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

            // Q03: Compile-time error, so we use a number instead of a string.
            {
                int pages = 464;
                Console.WriteLine(pages);
            }

            // Q04
            try
            {
                int zero = 0;
                int answer = 10 / zero;
                Console.WriteLine(answer);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }

            // Q05
            {
                int pages = 300;
                double doublePages = pages;
                Console.WriteLine(doublePages);
            }

        }
    }

    internal class Book
    {
        public string Title = "";
        public int Pages;
    }
}

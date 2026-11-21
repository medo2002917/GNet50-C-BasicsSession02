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

            // Q06
            double price = 49.99;
            int priceAsInt = (int)price;
            Console.WriteLine(priceAsInt);

            // Q07
            string pagesText = "464";
            int convertedPages = Convert.ToInt32(pagesText);
            Console.WriteLine(convertedPages);

            // Q08
            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year);

            string badText = "abc";
            bool isNumber = int.TryParse(badText, out int number);

            if (isNumber == false)
            {
                Console.WriteLine("Invalid number");
            }

            // Q09
            {
                int pages = 464;
                string pagesAsString = pages.ToString();
                Console.WriteLine(pagesAsString.GetType());
            }


        }
    }

    internal class Book
    {
        public string Title = "";
        public int Pages;
    }
}

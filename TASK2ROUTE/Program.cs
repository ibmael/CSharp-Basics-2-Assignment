namespace TASK2ROUTE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //Task One
            #region Task 1
            int pages1 = 464;
            bool isAvailable = true;
            if (pages1 > 300 && isAvailable)
            {
                Console.WriteLine("Task 1: You can borrow this book");
            }
            Console.WriteLine();
            #endregion
            //Task Two
            #region Task 2
            string title = "Refactoring";
            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Task 2: Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Task 2: Nice pick!");
                    break;
                default:
                    Console.WriteLine("Task 2: Never heard of it");
                    break;
            }
            Console.WriteLine();

            #endregion
            //Task Three
            #region Task 3
            int pages3 = 464;
            string sizeLabel = pages3 > 300 ? "Long Book" : "Short Book";
            Console.WriteLine($"Task 3: {sizeLabel}");
            Console.WriteLine();
            #endregion
            //Task Four
            #region Task 4
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"Task 4: {i + 1}. {books[i]}");
            }
            Console.WriteLine();
            #endregion
            //Task Five
            #region Task 5
            int j = 0;
            while (j < books.Length)
            {
                Console.WriteLine($"Task 5: {books[j]}");
                j++;
            }
            Console.WriteLine();
            #endregion
            //Task Six
            #region Task 6
            int count = 0;
            do
            {
                Console.WriteLine("Task 6: Checking book...");
                count++;
            } while (count < 3);
            Console.WriteLine();
            #endregion
            //Task Seven
            #region Task 7
            foreach (string book in books)
            {
                Console.WriteLine($"Task 7: {book}");
            }
            Console.WriteLine();
            #endregion
            //Task Eight
            #region Task 8
            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    Console.WriteLine($"Task 8: {book}");
                    break;
                }
                Console.WriteLine($"Task 8: {book}");
            }
            Console.WriteLine();
            #endregion
            //Task Nine
            #region Task 9
            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine($"Task 9: {book}");
            }
            Console.WriteLine();
            #endregion
            //Task Ten
            #region Task 10
            PrintFirstBook(books);
            PrintFirstBook(new string[] { });
            #endregion

            Console.ReadKey();

        }
        static void PrintFirstBook(string[] books)
        {
            if (books.Length == 0)
            {
                return;
            }
            Console.WriteLine($"Task 10: {books[0]}");
        }
    }
}

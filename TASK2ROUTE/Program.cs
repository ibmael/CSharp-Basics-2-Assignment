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

        }
    }
}

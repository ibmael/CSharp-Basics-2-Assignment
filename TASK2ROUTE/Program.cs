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
        }
    }
}

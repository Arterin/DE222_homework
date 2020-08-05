namespace W2_SumOf
{
    internal class Program
    {
        private static void Main()
        {
            var controller = new SumOfController(new ConsoleView(), new SumOf());
            controller.Go();
        }
    }
}
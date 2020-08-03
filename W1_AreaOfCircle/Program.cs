namespace W1_AreaOfCircle
{
    internal class Program
    {
        private static void Main()
        {
            var controller = new CircleAreaCalculatorController(new ConsoleView(), new CircleAreaCalculator());
            controller.Go();
        }
    }
}
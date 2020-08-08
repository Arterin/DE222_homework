namespace W2_AreaOfTriangle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var controller = new AreaOfTriangleController(new ConsoleView(), new AreaOfTriangle());
            controller.Go();
        }
    }
}
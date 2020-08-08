using System;

namespace W2_AreaOfTriangle
{
    public class ConsoleView : IView
    {
        public void Stop()
        {
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        public void Show<T>(T message)
        {
            Console.WriteLine(message);
        }
    }
}
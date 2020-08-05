using System;

namespace W2_SumOf
{
    public class ConsoleView : IView
    {
        public void Stop()
        {
            Console.WriteLine("Press any key to finish...");
            Console.ReadKey();
        }

        public void Show<T>(T message)
        {
            Console.WriteLine(message);
        }
    }
}
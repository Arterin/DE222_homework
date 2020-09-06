using System;

namespace W6_ClassNotes
{
    internal class LooksLikeCollection<T>
    {
        private readonly T[] _data = new T[100];

        public T this[int i]
        {
            get => _data[i];
            set => _data[i] = value;
        }
    }

    internal class Program
    {
        private static void Main()
        {
            var greetings = new LooksLikeCollection<string>();
            greetings[0] = "hello";
            greetings[1] = "world";

            Console.WriteLine(greetings[1]);
        }
    }
}
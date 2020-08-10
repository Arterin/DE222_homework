using System;

namespace W3_BoxOfToy
{
    internal class Program
    {
        private static void Main()
        {
            var theBox = new Box();
            Console.WriteLine(theBox);

            theBox.AddToy("ball", "red", 18.55M);
            theBox.AddToy("doll", "blue", 15.55M);
            theBox.AddToy("bear", "brown", 55.55M);

            Console.WriteLine(theBox);
            theBox.SortByName();
            Console.WriteLine(theBox);
            Console.ReadKey();
        }
    }
}
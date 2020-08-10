using System.Collections.Generic;

namespace W3_BoxOfToy
{
    public class Box
    {
        private readonly List<Toy> toys = new List<Toy>();

        public int ToyCount => toys.Count;

        public void AddToy(string name, string color, decimal cost)
        {
            var newToy = new Toy(name, color, cost);
            toys.Add(newToy);
        }

        public override string ToString()
        {
            var result = $"A box with {ToyCount} toys\n";
            foreach (var aToy in toys) result += "\n" + aToy;
            return result;
        }

        public void SortByName()
        {
            toys.Sort((x, y) => x.Name.CompareTo(y.Name));
        }
    }
}
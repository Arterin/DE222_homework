using System.Collections.Generic;

namespace W3_BoxOfToy
{
    public class Box
    {
        List<Toy> toys = new List<Toy>();

        private int ToyCount
        {
            get => toys.Count;
        }

        public void AddToy(string name, string color, decimal cost)
        {
            Toy newToy = new Toy(name, color, cost);
            toys.Add(newToy);
        }

        public override string ToString()
        {
            string result = $"A box with {ToyCount} toys\n";
            foreach (Toy aToy in toys)
            {
                result += "\n" + aToy;
            }
            return result;
        }

        public void SortByName()
        {
            toys.Sort((x,y) => x.Name.CompareTo(y.Name));
        }
    }
}
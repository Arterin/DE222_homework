namespace W3_BoxOfToy
{
    internal class Toy
    {
        private readonly string _color;
        private decimal _cost;
        private readonly string _name;

        public Toy(string name, string color, decimal cost)
        {
            _name = name;
            _color = color;
            _cost = cost;
        }

        public decimal Cost
        {
            set => _cost = value;
        }

        public string Name => _name;

        public override string ToString()
        {
            return $"This is a {_name} which is {_color} and costs ${_cost}";
        }
    }
}
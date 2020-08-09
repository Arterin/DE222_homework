namespace W3_BoxOfToy
{
    internal class Toy 
    {
        protected string _name;
        protected string _color;
        protected decimal _cost;

        public Toy(string name, string color, decimal cost)
        {
            _name = name;
            _color = color;
            _cost = cost;
        }

        public decimal Cost
        {
            set { _cost = value; }
        }

        public string Name
        {
            get => _name;
        }

        public override string ToString()
        {
            return $"This is a {_name} which is {_color} and costs ${_cost}";
        }
    }
}
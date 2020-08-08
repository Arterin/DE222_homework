namespace W2_AreaOfTriangle
{
    public class AreaOfTriangle : IAreaOfTriangle
    {
        private decimal _area;
        private decimal _base;
        private decimal _height;

        public decimal GetArea()
        {
            _area = _base / 2 * _height;
            return _area;
        }

        public void SetHeight(decimal height)
        {
            _height = height;
        }

        public void SetWidth(decimal width)
        {
            _base = width;
        }
    }
}
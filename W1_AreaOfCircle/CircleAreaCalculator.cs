using System;

namespace W1_AreaOfCircle
{
    public class CircleAreaCalculator : ICircleAreaCalculator
    {
        private decimal _area;
        private decimal _radius;

        public decimal GetArea()
        {
            _area = _radius * _radius * (decimal) Math.PI;
            return _area;
        }

        public void SetRadius(decimal newRadius)
        {
            _radius = newRadius;
        }
    }
}
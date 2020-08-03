namespace W1_AreaOfCircle
{
    public class CircleAreaCalculatorController
    {
        private readonly ICircleAreaCalculator _circleAreaCalculator;
        private readonly IView _view;

        public CircleAreaCalculatorController(IView newView, ICircleAreaCalculator newCircleAreaCalculator)
        {
            _view = newView;
            _circleAreaCalculator = newCircleAreaCalculator;
        }

        public void Go()
        {
            _circleAreaCalculator.SetRadius(15.5M);
            var area = _circleAreaCalculator.GetArea();
            _view.Show(area);
            _view.Stop();
        }
    }
}
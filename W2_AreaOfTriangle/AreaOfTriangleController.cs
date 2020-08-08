namespace W2_AreaOfTriangle
{
    public class AreaOfTriangleController
    {
        private readonly IAreaOfTriangle _areaOfTriangle;
        private decimal _result;
        private readonly IView _view;

        public AreaOfTriangleController(IView newView, IAreaOfTriangle newAreaOfTriangle)
        {
            _view = newView;
            _areaOfTriangle = newAreaOfTriangle;
        }

        public void Go()
        {
            _areaOfTriangle.SetHeight(15M);
            _areaOfTriangle.SetWidth(50M);
            _result = _areaOfTriangle.GetArea();
            _view.Show(_result);
        }
    }
}
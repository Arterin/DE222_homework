namespace W2_SumOf
{
    public class SumOfController
    {
        private static ISumOf _sumOf;
        private readonly IView _view;
        private int _result;

        public SumOfController(IView newView, ISumOf newSumOf)
        {
            _view = newView;
            _sumOf = newSumOf;
        }

        public void Go()
        {
            _result = _sumOf.GetSumOf(10, 15);
            _view.Show(_result);
        }
    }
}
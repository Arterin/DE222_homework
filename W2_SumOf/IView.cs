namespace W2_SumOf
{
    public interface IView
    {
        public void Stop();
        public void Show<T>(T message);
    }
}
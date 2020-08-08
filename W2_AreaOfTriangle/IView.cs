namespace W2_AreaOfTriangle
{
    public interface IView
    {
        public void Stop();
        public void Show<T>(T message);
    }
}
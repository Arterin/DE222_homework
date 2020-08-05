namespace W2_SumOf
{
    public class SumOf : ISumOf
    {
        public int GetSumOf(int int1, int int2)
        {
            var result = int1 + int2;
            return result;
        }
    }
}
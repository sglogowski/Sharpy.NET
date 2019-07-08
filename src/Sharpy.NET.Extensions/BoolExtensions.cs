namespace SharpyNet.Extensions
{
    public static class BoolExtensions
    {
        public static bool IsFalsy(this bool b)
        {
            return b == false;
        }

        public static bool IsTruthy(this bool b)
        {
            return b == true;
        }
    }
}

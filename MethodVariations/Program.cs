namespace MethodVariations
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            float numerator = 17f;
            float denominator = 3f;
            float result = numerator / denominator;
            
            Console.WriteLine("{numerator} / {denominator} = {result}");
        }

        void TryDividing(float numerator, float denominator)
        {
            float result = numerator / denominator;
        }

        float Divide(float numerator, float denominator)
        {
            return numerator / denominator;
        }

        void DivideByRef(float numerator, float denominator, ref float result)
        {
            result = numerator / denominator;
        }

        void DivideByRefSafe(float numerator, float denominator, ref float result)
        {
            result = denominator == 0f ? 0f : numerator / denominator;
        }

        bool DivideByRefSafeAndRobust(float numerator, float denominator, ref float result)
        {
            result = denominator == 0f ? 0f : numerator / denominator;
            return denominator == 0f;
        }

        object DivideAnonymous(float numerator, float denominator)
        {
            return new {
                ErrorCode = denominator == 0f,
                Result = denominator == 0f ? 0f : numerator / denominator
            };
        }

        Tuple<bool, float> DivideStrong(float numerator, float denominator)
        {
            return new Tuple<bool, float>(denominator == 0, denominator == 0f ? 0f : numerator / denominator);
        }
    }
}

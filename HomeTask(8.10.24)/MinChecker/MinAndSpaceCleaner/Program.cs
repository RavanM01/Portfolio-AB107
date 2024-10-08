namespace MinChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 34,56,123,5676,12, 2, 3 };
            Console.WriteLine(MinChecker(ints));
        }
        static int MinChecker(int[] ints) {
            int min = ints[0];

            foreach (int i in ints)
            {
                
                if (i < min)
                {
                    min = i;
                }
            }

            return min;

        }
    }
}

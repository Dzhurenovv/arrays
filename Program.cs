namespace Double_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
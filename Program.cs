namespace Deliverable_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 25;
            int[] fibonacciSequence = new int[size];
            fibonacciSequence[0] = 0;
            fibonacciSequence[1] = 1;

            for (int i = 2; i < size; i++)
            {
                fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Fibonacci number ({0}) = {1}", i, fibonacciSequence[i]);
            }

            Console.ReadLine();
        }
    }
}
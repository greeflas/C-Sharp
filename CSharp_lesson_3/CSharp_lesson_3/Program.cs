using System;
using System.Linq;

namespace CSharp_lesson_3
{
    class Program
    {
        static void DisplayMatrix(int[,] matrix)
        {
            int N = matrix.GetLength(0);
            int M = matrix.GetLength(1);

            //int minIndex = matrix.GetLowerBound(0); // get first index
            //int maxIndex = matrix.GetUpperBound(0); // get last index

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                    Console.Write("{0, 4}", matrix[i, j]);
                Console.WriteLine("\n");
            }
        }

        static void DisplayArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            /* Example 1 */

            // GetLength(), GetLowerBound(), GetUpperBound()
            const int N = 4;
            const int M = 3;

            int[,] matrix = new int[N, M]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9},
                {11, 12, 13}
            };

            Console.WriteLine("> Matrix\n");
            DisplayMatrix(matrix);

            /* Example 2 */

            // Length
            const int ARR_SIZE = 5;

            int[] arr = new int[ARR_SIZE] { 1, 2, 3, 4, 5 };

            Console.WriteLine("> Array\n");
            DisplayArray(arr);

            // CopyTo()
            const int COPY_ARR_SIZE = 7;

            int[] copy = new int[COPY_ARR_SIZE];
            arr.CopyTo(copy, 2);

            Console.WriteLine("> Copy of Array\n");
            DisplayArray(copy);

            // Clear()
            Array.Clear(arr, 0, 2);

            Console.WriteLine("> Cleaned Array\n");
            DisplayArray(arr);

            // IndexOf()
            int index = Array.IndexOf(arr, 3); // return -1 if not found
            Console.WriteLine("Index: {0}", index);

            // Resize()
            Array.Resize(ref copy, 10); // 'ref' like '&' in C++

            Console.WriteLine("\nNew size: {0}", copy.Length);
            DisplayArray(copy);

            // Random array
            const int RANDOM_ARR_SIZE = 15;

            int[] random_array = new int[RANDOM_ARR_SIZE];
            Random r = new Random();

            for (int i = 0; i < random_array.Length; i++)
                random_array[i] = r.Next(1, 15);

            Console.WriteLine("> Random Array\n");
            DisplayArray(random_array);

            // Sort()
            Array.Sort(random_array);

            Console.WriteLine("> Sorted Randow Array");
            DisplayArray(random_array);

            Console.WriteLine(
                "Min: {0}\nMax: {1}\nAverage: {2}\n",
                random_array.Max(),
                random_array.Min(),
                random_array.Average()
             );
        }
    }
}
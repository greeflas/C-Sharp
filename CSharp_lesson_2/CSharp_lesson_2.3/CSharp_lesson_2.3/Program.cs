using System;

namespace CSharp_lesson_2._3
{
    class Program
    {
        static void InitArray(int[] arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = r.Next(1, 100);
        }

        static void DisplayArray(int[] arr)
        {
            Console.WriteLine("\nArray values");
            // foreach cannot modified values of object
            foreach (int item in arr)
            {
                Console.Write("> ");
                Console.WriteLine(item);
            }
        }

        static void InitMatrix(int[,] arr, int N, int M)
        {
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                    arr[i, j] = rand.Next(1, 10);
            }
        }

        static void DisplayMatrix(int[,] arr, int N, int M)
        {
            Console.WriteLine("\n Matrix\n");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                    Console.Write(" {0}", arr[i, j]);
                Console.WriteLine("\n");
            }
        }

        static void Main(string[] args)
        {
            /* ARRAY */
            int size = 0;

            // input size of the array
            Console.WriteLine("Input size of the array");
            Console.Write("> ");
            try
            {
                size = Convert.ToInt32(Console.ReadLine());

                // create array
                int[] array = new int[size];

                // init array
                InitArray(array);

                // display array
                DisplayArray(array);
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(err.Message);
                Console.ResetColor();
            }

            /* MATRIX */
            const int N = 3;
            const int M = 4;

            // create matrix
            int[,] matrix = new int[N, M];

            // init matrix
            InitMatrix(matrix, N, M);

            // display matrix
            DisplayMatrix(matrix, N, M);

            /* RIPPED ARRAYS */
            // create array
            const int RIPPED_ARR_SIZE = 3;
            int[][] ripped_array = new int[RIPPED_ARR_SIZE][];

            // init array
            ripped_array[0] = new int[] { 1, 2, 3 };
            ripped_array[1] = new int[] { 4, 5, 6 };
            ripped_array[2] = new int[] { 7, 8, 9 };

            Console.WriteLine(" Ripped array\n");
            for (int i = 0; i < RIPPED_ARR_SIZE; i++)
            {
                foreach (int item in ripped_array[i])
                    Console.Write(" {0}", item);
                Console.WriteLine("\n");
            }
        }
    }
}

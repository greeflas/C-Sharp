using System;
using System.Linq;
using System.IO;

namespace CSharp_lesson_4
{
    class Program
    {
        static uint CalcMinValues(int[] arr)
        {
            uint min = 0;
            foreach (int item in arr)
            {
                if (item < (int)arr.Average())
                    ++min;
            }

            return min;
        }

        static uint CalcMaxValues(int[] arr)
        {
            uint max = 0;
            foreach (int item in arr)
            {
                if (item > (int)arr.Average())
                    ++max;
            }

            return max;
        }

        static uint CalcPercent(uint a, uint b)
        {
            return ((b * 100) / a);
        }

        static void Main(string[] args)
        {
            // Generate data to file
            const uint DATA_ITEMS_NUM = 30;

            const string PATH_TO_DATA_FILE = @"..\..\data\data.txt";
            
            FileStream wf = 
                new FileStream(PATH_TO_DATA_FILE, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(wf);

            Random r = new Random();
            for (uint i = 0; i < DATA_ITEMS_NUM; i++ )
                sw.Write(r.Next(160, 200) + "\n");

            sw.Close();
            wf.Close();

            // Read data from file
            FileStream rf = 
                new FileStream(PATH_TO_DATA_FILE, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(rf);

            int[] arr = new int[DATA_ITEMS_NUM];

            for (uint i = 0; i < arr.Length; i++)
                arr[i] = Convert.ToInt32(sr.ReadLine());

            sr.Close();
            rf.Close();

            // display data
            foreach(int item in arr)
                Console.WriteLine(item);
            Console.WriteLine();

            // calc data
            uint min = CalcMinValues(arr);
            uint max = CalcMaxValues(arr);

            Console.WriteLine("Average: " + (int)arr.Average());
            Console.WriteLine("< " + CalcPercent(DATA_ITEMS_NUM, min) + "%");
            Console.WriteLine("> " + CalcPercent(DATA_ITEMS_NUM, max) + "%");

            // sort array and write result to file
            const string PATH_TO_RESULT_FILE = @"..\..\data\result.txt";

            FileStream wf2 = 
                new FileStream(PATH_TO_RESULT_FILE, FileMode.Open, FileAccess.Write);
            StreamWriter sw2 = new StreamWriter(wf2);

            Array.Sort(arr);
            foreach(int item in arr)
                sw2.WriteLine(item);

            sw2.Close();
            wf2.Close();
        }
    }
}

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace HackerRate
{
    class Program
    {// Complete the hourglassSum function below.
        static int hourglassSum(int[][] arr)
        {
            int result = 0;
            int hourGlassSum = 0;
            List<int> LinkedList = new List<int>();
          
        arr

            for (int x = 1; x < arr.Length - 1; x++)
            {
                for (int y = 1; y < arr.Length - 1; y++)
                {
                    hourGlassSum = arr[x - 1][y - 1] + arr[x][y - 1] + arr[x + 1][y - 1]
                                                    + arr[x][y] +
                                     arr[x - 1][y + 1] + arr[x][y + 1] + arr[x + 1][y + 1];
                    LinkedList.Add(hourGlassSum);
                    hourGlassSum = 0;
                }

            }
            return result = (int)LinkedList.Sum();
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}

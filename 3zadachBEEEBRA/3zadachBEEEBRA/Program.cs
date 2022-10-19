using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3zadachBEEEBRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int GetClosestToTen(params int[] array)
            {
                int closestToTen = 0;
                int closestToTenIndex = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (Math.Abs(array[i] - 10) > Math.Abs(closestToTen - 10)) continue;
                    closestToTen = array[i];
                    closestToTenIndex = i;
                }
                return array[closestToTenIndex];
            }

            

            string GetLargestGeneralPrefics(params string[] array)
            {
                string largestGeneralPrefics = "";
                for (int i = 0; i < array[0].Length; i++)
                {
                    for (int j = 1; j < array.Length; j++)
                    {
                        if (array[0][i] != array[j][i])
                        {
                            return largestGeneralPrefics;
                        }
                    }
                    largestGeneralPrefics += array[0][i];
                }
                return largestGeneralPrefics;
            }
            



            bool IsReapeating(params int[] array) => array.ToHashSet().Count < array.Length;
            
            
            bool IsReapeatingGovno(params int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            return true;
                        }
                    }
                }
                return false;
            }


            
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(IsReapeating(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(IsReapeating(1, 2, 2, 4, 5, 6, 7, 8, 9, 10));
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            Console.ReadKey();

        }
    }
}

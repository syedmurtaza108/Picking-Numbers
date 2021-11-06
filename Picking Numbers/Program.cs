using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picking_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int[] a = Array.ConvertAll(Console.ReadLine().TrimEnd().Split(' '), aTemp => Convert.ToInt32(aTemp));

            int result = pickingNumbers(a);
            Console.WriteLine(result);
        }
        public static int pickingNumbers(int[] a)
        {
            List<int> counts = new List<int>();
            Array.Sort(a);
            for (int i = 0; i < a.Length - 1; i++)
            {
                List<int> subArray = new List<int>();
                subArray.Add(a[i]);
                for (int j = i+1; j < a.Length; j++)
                {
                    if (Math.Abs(a[i] - a[j]) <= 1)
                        subArray.Add(a[j]);
                    else
                        break;
                }
                counts.Add(subArray.Count);
            }

            return counts.Max();
        }
        


    }
}

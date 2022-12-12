using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 2, 3, 5, 7, -3, 1, 0, 8, 9, 1, 5};
            Console.WriteLine(string.Join(" ", arr));
            int len = arr.Length;
            int[] newarr1 = new int[arr.Length/2];
            int[] newarr2 = new int[arr.Length/2];
            int[] zd = new int[len];
            int min = 100;
            int sum = 0;
            for (int i = 0; i < len; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[0] == 0)
                {
                    if (i != 0)
                    {
                        sum += arr[i];
                    }
                }
            }

            for (int i = 0, i1 = 0, i2 = 0; i < arr.Length; i++)
                if (i % 2 != 0)
                    newarr1[i1++] = arr[i];
                else
                    newarr2[i2++] = arr[i];

            for (var i = 0; i < arr.Length; i++)
                arr[i] = i < newarr1.Length ? newarr1[i] : newarr2[i - newarr1.Length];


            Console.WriteLine(min);
            Console.WriteLine(sum);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}

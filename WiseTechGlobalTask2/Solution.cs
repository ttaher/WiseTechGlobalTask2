using System;
using System.Collections.Generic;
using System.Linq;
namespace WiseTechGlobalTask2
{
    class Solution
    {
        static void Main(string[] args)
        {
            int x = solution(new int[] { 2, 1, 3, 5, 4 });
            Console.WriteLine(x);
            int x1 = solution(new int[] { 2, 3, 4, 1, 5 });
            Console.WriteLine(x1);
            int x2 = solution(new int[] { 1, 3, 4, 2, 5 });
            Console.WriteLine(x2);

        }
        public static int solution(int[]a)
        {
            int res = 0;
            var sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
                res++;
                if (sum >= a.Length)
                    break;
            }
            return res;
        }
    }
}

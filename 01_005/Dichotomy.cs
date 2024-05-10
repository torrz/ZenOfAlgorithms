using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_005
{
    /// <summary>
    /// 二分法
    /// </summary>
    internal class Dichotomy
    {
        public static int Sum(int[] arr, int li, int hi)
        {
            if (li == hi) { return arr[li]; }
            int mi = li + (hi - li) / 2;
            return Sum(arr, li, mi) + Sum(arr, mi + 1, hi);
        }


        public static int Sum2(int[] arr, int li, int hi)
        {
            if (li > hi) { return 0; }
            int mi = li + (hi - li) / 2;
            return arr[mi] + Sum2(arr, li, mi - 1) + Sum2(arr, mi + 1, hi);
        }
    }
}

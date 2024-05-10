namespace _01_005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[25000];
            Array.Fill(arr, 1);

            var sum1=Sum(arr);
            Console.WriteLine(sum1);

            //var sum2=SumToEnd(arr, 0);
            //Console.WriteLine(sum2);
            Console.WriteLine(TailRecursion.Sum(arr));
            Console.WriteLine(Dichotomy.Sum(arr, 0, arr.Length - 1));
            Console.WriteLine(Dichotomy.Sum2(arr, 0, arr.Length - 1));
            Console.WriteLine("Hello, World!");
        }

        /// <summary>
        /// 17页
        /// recurrent,递推的
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int Sum(int[] arr)
        {
            var sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;

        }

        static int SumToEnd(int[] arr, int cur)
        {
            if (cur == arr.Length) { return 0; }
            return arr[cur] + SumToEnd(arr, cur + 1);
        }

        
    }
}

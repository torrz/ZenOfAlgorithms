namespace _01_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 100, 200, 300, 400, 500, 600 };

            var sum1=sum(arr);
            var sum2=sumToEnd(arr,0);

            var sum3 = sumToEnd2(arr, 0);
            Console.WriteLine($"{sum1} and {sum2} and {sum3} are equal.");

            Console.ReadLine();
        }

        /// <summary>
        /// recurrent,递推的
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int sum(int[] arr)
        {
            var sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        /// <summary>
        /// recursive,递归的
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="cur"></param>
        /// <returns></returns>
        static int sumToEnd(int[] arr, int cur)
        {
            if (cur == arr.Length - 1)
            {
                return arr[cur];
            }
            else
            {
                return arr[cur] + sumToEnd(arr, cur + 1);
            }
        }

        /// <summary>
        /// recursive,递归的
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="cur"></param>
        /// <returns></returns>
        static int sumToEnd2(int[] arr, int cur)
        {
            if (cur == arr.Length)
            {
                return 0;//越界代偿
            }
            else
            {
                return arr[cur] + sumToEnd2(arr, cur + 1);
            }
        }
    }
}

namespace _01_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GoDeeper(2);
            //GoDeeper2(2);

            Console.WriteLine("Hello, World!");
        }

        /// <summary>
        /// 16页
        /// </summary>
        /// <param name="level"></param>
        static void GoDeeper(int level)
        {
            //刻意移除停止机制
            //if (level == 10000) return;
            if (level > 0)
            {
                GoDeeper(level + 1);
            }
        }


        /// <summary>
        /// 17页
        /// 添加异常处理机制也没用
        /// </summary>
        /// <param name="level"></param>
        static void GoDeeper2(int level)
        {
            //刻意移除停止机制
            //if (level == 10000) return;
            try
            {
                GoDeeper2(level + 1);
            }
            catch (Exception)
            {

                Console.WriteLine("溢出");
            }
        }
    }
}

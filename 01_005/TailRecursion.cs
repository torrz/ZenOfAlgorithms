using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_005
{
    public class TailRecursion
    {
        /// <summary>
        /// 外部累加器
        /// </summary>
        private static int sum;


        public static int Sum(int[] arr)
        {
            SumNext(arr, 0);
            return sum;
        }

        /// <summary>
        /// 18页
        /// 尾递归
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="i"></param>
        public static void SumNext(int[] arr, int i)
        {
            if (i == arr.Length)
            {
                return;
            }
            sum += arr[i];
            SumNext(arr, i + 1);
        }
        /// <summary>
        /// 要使用编译器选项 /optimize+ 来启用优化，您可以按照以下步骤进行操作：
        ///1.	打开 Visual Studio 或者其他 C# 编辑器。
        ///2.	打开您的项目。
        ///3.	在解决方案资源管理器中，右键单击项目并选择 "属性"。
        ///4.	在项目属性窗口中，选择 "生成" 选项卡。
        ///5.	在 "生成" 选项卡下，找到 "优化代码" 选项，勾选。
        ///完成上述步骤后，您的项目将使用编译器选项 /optimize+ 来启用优化。这将告诉编译器在可能的情况下对尾递归进行优化。
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>


        public static int Fibonacci(int n) {
            if (n <= 0) return 0;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}

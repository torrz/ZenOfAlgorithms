using _ClassLibrary;
using System.Runtime.CompilerServices;

namespace _01_006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreePathSum.Run();
            Console.WriteLine("Hello, World!");

            var root=TreePathSum.BuildTree(20000);
            var sums = GetPathSums(root);
            
            Console.WriteLine(string.Join(",",sums));
        }


        public static List<int> GetPathSums(Node root)
        {
            var stack = new Stack<Frame>();
            var primer = new Frame(root);
            stack.Push(primer);

            while (true)
            {
                var top = stack.Peek();
                if (top.Node == null)
                {
                    stack.Pop();//越界代偿
                    stack.Peek().Count++;
                }
                else if (top.Count == 0)
                {
                    stack.Push(new Frame(top.Node.left));
                }
                else if (top.Count == 1)
                {
                    stack.Push(new Frame(top.Node.right));
                }
                else if (top.Count == 2)//这里的if可以省略
                {
                    var popped = stack.Pop();
                    if (popped.Sums.Count == 0)
                    {
                        //叶子
                        popped.Sums.Add(popped.Node.val);
                    }
                    if (stack.Count==0)
                    {
                        break;
                    }
                    top = stack.Peek();
                    foreach (var sum in popped.Sums)
                    {
                        top.Sums.Add(sum + top.Node.val);
                    }
                    top.Count++;
                }

            }
            return primer.Sums;

        }
    }
}

using _ClassLibrary;

namespace _01_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //可以这样写
            //var arr=Enumerable.Range(1, 7).ToArray();
            int[] arr = [1, 2, 3, 4, 5, 6, 7];
            var root = BuildTree(arr, 0, arr.Length - 1);
            LibMethod.PrintTree(root);

            Console.WriteLine("简化版本");
            var node = BuildTreeSimplify(arr, 0, arr.Length - 1);
            LibMethod.PrintTree(node);

            Console.WriteLine("求路径和");
            var pathSums = GetPathSums(root);
            foreach (int item in pathSums)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static Node? BuildTree(int[] arr, int li, int hi)
        {
            if (li > hi) return null;//越界代偿
            var mi = li + (hi - li) / 2;
            var leftSubtreeRoot = BuildTree(arr, li, mi - 1);
            var rightSubtreeRoot = BuildTree(arr, mi + 1, hi);
            var root = new Node(arr[mi]);
            root.left = leftSubtreeRoot;
            root.right = rightSubtreeRoot;
            return root;
        }

        /// <summary>
        /// 简化
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="li"></param>
        /// <param name="hi"></param>
        /// <returns></returns>
        static Node? BuildTreeSimplify(int[] arr, int li, int hi)
        {
            if (li > hi) return null;//越界代偿
            var mi = li + (hi - li) / 2;
            var root = new Node(arr[mi]);
            root.left = BuildTree(arr, li, mi - 1);
            root.right = BuildTree(arr, mi + 1, hi);
            return root;
        }

        static List<int> GetPathSums(Node root)
        {
            var sums = new List<int>();
            var sumQ = new Queue<int>();
            var nodeQ = new Queue<Node>();
            sumQ.Enqueue(0);
            nodeQ.Enqueue(root);

            while (nodeQ.Count > 0)
            {
                var curNode = nodeQ.Dequeue();
                if (curNode == null)
                {
                    continue;
                }
                var curSum = curNode.val + sumQ.Dequeue();
                if (curNode.left == null && curNode.right == null)
                {
                    sums.Add(curSum);
                }
                sumQ.Enqueue(curSum);
                nodeQ.Enqueue(curNode.left);
                sumQ.Enqueue(curSum);
                nodeQ.Enqueue(curNode.right);

            }
            return sums;
        }

        
    }
}

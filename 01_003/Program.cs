using _ClassLibrary;

namespace _01_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 2, 3, 4, 5, 6, 7];
            var root = LibMethod.BuildTree(arr, 0, arr.Length - 1);

            var pathSums = GetPathSums(root);
            LibMethod.PrintTree(root);
            foreach (var item in pathSums)
            {
                Console.WriteLine($"Root to {item.Key.val} : {item.Value}");
            }


            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("递归版本");
            var dic = new Dictionary<Node, int>();
            GetPathSums2(root,0, dic);
            foreach (var item in dic)
            {
                Console.WriteLine($"Root to {item.Key.val} : {item.Value}");
            }
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("递归式代码");
            var sums=CollectSums(root);
            foreach (var item in sums)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("递归式代码2");
            var sums2 = CollectSums2(root);
            foreach (var item in sums2)
            {
                Console.WriteLine($"{item}");
            }

            Console.ReadLine();
        }
        /// <summary>
        /// 书第12页
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static Dictionary<Node, int> GetPathSums(Node root)
        {

            var sums = new Dictionary<Node, int>();
            var nodeQ = new Queue<Node>();
            sums.Add(root, root.val);//绑定结点到当前结点的路径和
            nodeQ.Enqueue(root);

            while (nodeQ.Count > 0)
            {
                var curNode = nodeQ.Dequeue();
                var curSum = sums[curNode];

                //去掉不完成路径和
                if (curNode.left != null || curNode.right != null)
                    sums.Remove(curNode);

                if (curNode.left != null)
                {
                    nodeQ.Enqueue(curNode.left);
                    sums.Add(curNode.left, curSum + curNode.left.val);
                }
                if (curNode.right != null)
                {
                    nodeQ.Enqueue(curNode.right);
                    sums.Add(curNode.right, curSum + curNode.right.val);
                }
            }
            return sums;
        }

        /// <summary>
        /// 书第14页
        /// </summary>
        /// <param name="root"></param>
        /// <param name="parentSum"></param>
        /// <param name="sums"></param>
        public static void GetPathSums2(Node root, int parentSum, Dictionary<Node, int> sums)
        {
            if (root == null)
                return;

            parentSum += root.val;
            if (root.left == null && root.right == null)
            {
                sums.Add(root, parentSum);
            }
            else
            {
                GetPathSums2(root.left, parentSum, sums );
                GetPathSums2(root.right, parentSum, sums);
            }
        }

        /// <summary>
        /// 书第15页
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static List<int> CollectSums(Node node) {

            var sums = new List<int>();
            if (node == null) return sums;
            sums.AddRange(CollectSums(node.left));
            sums.AddRange(CollectSums(node.right));

            for (int i = 0; i < sums.Count; i++)
            {
                sums[i] = sums[i] + node.val;
            }

            if (sums.Count==0)
            {
                sums.Add(node.val);
            }
            return sums;
        }

        /// <summary>
        /// 书第16页
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static List<int> CollectSums2(Node node)
        {

            var sums = new List<int>();
            if (node == null) return sums;

            foreach (var item in CollectSums2(node.left))
            {
                sums.Add(item + node.val);
            }

            foreach (var item in CollectSums2(node.right))
            {
                sums.Add(item + node.val);
            }

            if (sums.Count == 0)
            {
                sums.Add(node.val);
            }
            return sums;
        }

    }
}

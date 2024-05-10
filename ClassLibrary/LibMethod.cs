using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ClassLibrary
{
    public static class LibMethod
    {
        public static Node? BuildTree(int[] arr, int li, int hi)
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
        /// 图形的方式打印树
        /// </summary>
        /// <param name="root"></param>
        /// <param name="indent"></param>
        public static void PrintTree(Node root, string indent = "")
        {
            if (root == null)
                return;

            PrintTree(root.right, indent + "   ");
            Console.WriteLine(indent + root.val);
            PrintTree(root.left, indent + "   ");
        }
    }
}

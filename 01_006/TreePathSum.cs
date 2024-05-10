using _ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_006
{
    public class TreePathSum
    {
        public static void Run()
        {
            var root = BuildTree(20000);
        }

        public static Node AddChild(Node node, int val, bool toLeft)
        {
            var child = new Node(val);
            return toLeft ? node.left = child : node.right = child;
        }

        public static Node BuildTree(int n) {
            Node root = new Node(1);
            var p = root;
            var q = root;
            for (int i = 1; i <= n; i++)
            {
                //构建上部的"人"字
                p = AddChild(p, 1, true);
                q = AddChild(q, 1, false);
            }

            Node pp = p;
            Node qq = q;
            for (int i = 1; i <= n; i++) 
            {
                p = AddChild(p, 1, true);
                pp= AddChild(pp, 1, false);
                q= AddChild(q, 1, false);
                qq=AddChild(qq, 1, true);
            }
            return root;
        }
    }
}

namespace _ClassLibrary
{
    public class Node
    {
        public int val;
        public Node? left;//加上?表示可以为空
        public Node? right;

        public Node(int val)
        {
            this.val = val;
        }
    }
}

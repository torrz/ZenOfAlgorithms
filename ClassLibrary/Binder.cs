namespace _ClassLibrary
{
    public class Binder
    {
        public Node CurNode;
        public int ParentSum;

        public Binder(Node curNode, int parentSum)
        {
            CurNode = curNode;
            ParentSum = parentSum;
        }
    }
}

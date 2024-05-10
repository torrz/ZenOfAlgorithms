using _ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_006
{
    public class Frame
    {
        public Node Node;
        public int Count { get; set; }
        public List<int> Sums { get; set; }
        public Frame(Node node)
        {
            Node = node;
            Count = 0;
            Sums = [];
        }
    }
}

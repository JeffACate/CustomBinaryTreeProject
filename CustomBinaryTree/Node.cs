using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBinaryTree
{
    class Node
    {
        public int data;
        public Node rightBranch;
        public Node leftBranch;
        public Node(int data)
        {
            this.data = data;
            rightBranch = null;
            leftBranch = null;
        }

    }
}

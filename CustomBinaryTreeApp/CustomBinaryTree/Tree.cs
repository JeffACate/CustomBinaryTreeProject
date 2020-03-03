using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBinaryTree
{
    class Tree
    {
        private Node root;
        
        public void Add(int number)
        {
            if(root == null)
            {
                Node node = new Node(number);
                return;
            }
            Node counterNode = root;
            while(counterNode != null)
            {
                if (number < counterNode.)
                {

                }
            }
        }
        public bool Search(int numberToSearch) 
        {
            throw new NotImplementedException();
            return false;
        }
    }
}

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
            Node node = new Node(number);
            //IF ROOT IS NULL ASSIGN ROOT
            if (root == null)
            {
                root = node;
                return;
            }
            Node currentTree = root;

            // IF BOTH SUB TREES ARE NULL ASSIGN ONE
            if (currentTree.leftSubTree == null && currentTree.rightSubTree == null)// NOT RIGHT
            {
                if (node.Data < currentTree.Data) { currentTree.leftSubTree = node; }
                else if (node.Data > currentTree.Data) { currentTree.rightSubTree = node; }
                return;
            }
            while (true)
            {
                if (node.Data <= currentTree.Data && currentTree.leftSubTree == null) { currentTree.leftSubTree = node; return; }
                else if (node.Data <= currentTree.Data && currentTree.leftSubTree != null) { currentTree = currentTree.leftSubTree; }
                else if (node.Data >= currentTree.Data && currentTree.rightSubTree == null) { currentTree.rightSubTree = node; return; }
                else if (node.Data >= currentTree.Data && currentTree.rightSubTree != null) { currentTree = currentTree.rightSubTree; }
            }
        }
        public bool Search(int numberToSearch)
        {
            if (root == null) { return false; }
            else if (root.leftSubTree == null && root.rightSubTree == null) { return false; }

            Node currentTree = root;

            while (true)
            {
                if (currentTree.Data == numberToSearch) { return true; }
                else if (numberToSearch < currentTree.Data && currentTree.leftSubTree == null) { return false; }
                else if (numberToSearch < currentTree.Data && currentTree.leftSubTree != null) { currentTree = currentTree.leftSubTree; }
                else if (numberToSearch > currentTree.Data && currentTree.rightSubTree == null) { return false; }
                else if (numberToSearch > currentTree.Data && currentTree.rightSubTree != null) { currentTree = currentTree.rightSubTree; }
            }
        }
    }
}

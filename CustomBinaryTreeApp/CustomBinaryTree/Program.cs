using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree myTree = new Tree();
            int[] nums = new int[] { 5, 1, 8, 2, 7, 3, 6, 4, 9 };
            foreach (int num in nums)
            {
                myTree.Add(num);
            }
            Console.WriteLine(myTree.Search(19));

            Console.ReadKey();
        }
    }
}

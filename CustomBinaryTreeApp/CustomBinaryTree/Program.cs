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
            int[] nums = new int[] {1,3,5,4,5,4,8,7,9,9,9,2,4,6,5,3,2};
            foreach (int num in nums)
            {
                myTree.Add(num);
            }
            Console.WriteLine(myTree.Search(5));
            Console.ReadKey();
        }
    }
}

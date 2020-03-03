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
            int[] nums = new int[] { 0, 9, 1, 8, 2, 7, 3, 6, 4, 5 };
            foreach (int num in nums)
            {
                myTree.Add(num);
            }

            if(myTree.Search(4))
            {
                Console.WriteLine("Item found!!");
            }
            else
            {
                Console.WriteLine("Number not found!");
            }
            Console.ReadKey();
        }
    }
}

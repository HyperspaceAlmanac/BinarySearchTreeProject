using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            Random rand = new Random();
            int temp;
            // Arrange
            for (int i = 0; i < 100; i++)
            {
                temp = rand.Next(100);
                tree.Add(temp);
            }
            tree.DisplayTree();
            Console.ReadLine();

        }
    }
}

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
            tree.Add(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(7);
            tree.Add(20);
            tree.Add(4);
            tree.DisplayTree();
            tree.Search(7);
            Console.ReadLine();

        }
    }
}

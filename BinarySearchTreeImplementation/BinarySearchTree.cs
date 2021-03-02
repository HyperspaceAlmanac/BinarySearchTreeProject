using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree<T>
    {
        private Node<T> root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Add(T value)
        {
            if (root is null)
            {
                root = new Node<T>(value);
            }
        }

        public bool Search(T value)
        {
            return false;
        }
    }
}

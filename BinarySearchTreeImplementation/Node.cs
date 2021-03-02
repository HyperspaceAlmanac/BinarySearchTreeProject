using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node<T>
    {
        T value;
        Node<T> left;
        Node<T> right;
        public Node(T value, Node<T> left = null, Node<T> right = null)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }
    }
}

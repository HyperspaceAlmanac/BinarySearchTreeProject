using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeImplementation
{
    public class Node<T>
    {
        public T value;
        public Node<T> left;
        public Node<T> right;
        public Node(T value, Node<T> left = null, Node<T> right = null)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }
    }
}

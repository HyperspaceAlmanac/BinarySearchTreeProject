using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeImplementation
{
    public class BinarySearchTree<T>
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
            else
            {
                Add(root, value);
            }
        }

        public bool Search(T value)
        {
            if (root is null)
            {
                return false;
            }
            else
            {
                return Search(root, value); 
            }

        }

        public static int CompareT(T left, T right)
        {
            return Comparer.DefaultInvariant.Compare(left, right);
        }
        public void Add(Node<T> node, T target)
        {
            int compareValue = CompareT(node.value, target);
            if (compareValue == 0)
            {// Since there is no remove, duplicates will not matter
                return;
            } // New value is smaller
            else if (compareValue == -1)
            {
                if (node.left is null)
                {
                    node.left = new Node<T>(target);
                }
                else
                {
                    Add(node.left, target);
                }
            } // New value is bigger
            else
            {
                if (node.right is null)
                {
                    node.right = new Node<T>(target);
                }
                else
                {
                    Add(node.right, target);
                }
            }
        }

        public bool Search(Node<T> node, T target)
        {
            int compareValue = CompareT(node.value, target);
            // Equal
            if (compareValue == 0)
            {
                return true;
            } // target is smaller
            else if (compareValue == -1)
            {
                if (node.left is null)
                {
                    return false;
                }
                else
                {
                    return Search(node.left, target);
                }
            } // target is bigger
            else
            {
                if (node.right is null)
                {
                    return false;
                }
                else
                {
                    return Search(node.right, target);
                }
            }
        }
    }
}

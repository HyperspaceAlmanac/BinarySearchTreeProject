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
            else if (compareValue == 1)
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
            else if (compareValue == 1)
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

        public void DisplayTree()
        {
            if (root is null)
            {
                return;
            }
            List<Tuple<Node<T>, int>> stack = new List<Tuple<Node<T>, int>>();
            int currentLayer = 0;
            stack.Add(new Tuple<Node<T>, int>(root, 0));
            while (stack.Count > 0)
            {
                Tuple<Node<T>, int> temp = stack[0];
                stack.RemoveAt(0);
                if (temp.Item2 > currentLayer)
                {
                    currentLayer += 1;
                    Console.WriteLine();
                }
                if (temp.Item1 is null)
                {
                    Console.Write("_,");
                    continue;
                }
                Console.Write(temp.Item1.value + ", ");
                if (temp.Item1.left == null)
                {
                    //Console.Write($"parent of null is {temp.Item1.value} ");
                    stack.Add(new Tuple<Node<T>, int>(null, temp.Item2 + 1));
                }
                else
                {
                    stack.Add(new Tuple<Node<T>, int> (temp.Item1.left, temp.Item2 + 1));
                }
                if (temp.Item1.right == null)
                {
                    //Console.Write($"parent of null is {temp.Item1.value} ");
                    stack.Add(new Tuple<Node<T>, int>(null, temp.Item2 + 1));
                }
                else
                {
                    stack.Add(new Tuple<Node<T>, int>(temp.Item1.right, temp.Item2 + 1));
                }
            }
        }
    }
}

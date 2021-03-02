using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearchTreeImplementation;
using System;
using System.Collections.Generic;
using System.Collections;

namespace BinarySearchTreeTests
{
    [TestClass]
    public class BinarySearchTreeUnitTests
    {
        [TestMethod]
        public void Search_EmptyTree_ShouldReturnFalse()
        {
            // Arrange
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            // Act
            bool expected = false;
            bool actual = tree.Search(5);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Search_AddIntValue_ShouldReturnTrue()
        {
            // Arrange
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(5);
            // Act
            bool expected = true;
            bool actual = tree.Search(5);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Search_AddStringValue_ShouldReturnTrue()
        {
            // Arrange
            BinarySearchTree<string> tree = new BinarySearchTree<string>();
            tree.Add("hello");
            // Act
            bool expected = true;
            bool actual = tree.Search("hello");
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Search_AddIntValue_DifferentValueShouldReturnFalse()
        {
            // Arrange
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(5);
            // Act
            bool expected = false;
            bool actual = tree.Search(10);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Search_AddTwoIntValue_DifferentValueShouldReturnFalse()
        {
            // Arrange
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(5);
            tree.Add(100);
            // Act
            bool expected = false;
            bool actual = tree.Search(10);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Search_AddTwoIntValue_SameValueShouldReturnTrue()
        {
            // Arrange
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(5);
            tree.Add(100);
            // Act
            bool expected = true;
            bool actual = tree.Search(5);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Flatten_FiveValuesList_ShouldMatchSortedList()
        {
            // Arrange
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            List<int> expected = new List<int>();
            tree.Add(5);
            expected.Add(5);
            tree.Add(100);
            expected.Add(100);
            tree.Add(-5);
            expected.Add(-5);
            tree.Add(30);
            expected.Add(30);

            // Act
            expected.Sort();
            List<int> actual = tree.Flatten(); 
            // Assert
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
        [TestMethod]
        public void Flatten_HundredValuesList_ShouldMatchSortedList()
        {
            Random rand = new Random();
            int temp;
            // Arrange
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            List<int> expected = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                temp = rand.Next(100);
                tree.Add(temp);
                expected.Add(temp);
            }

            // Act
            expected.Sort();
            List<int> actual = tree.Flatten();
            // Assert
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
        [TestMethod]
        public void Search_HundredValuesList_ShouldReturnTrue()
        {
            Random rand = new Random();
            int temp;
            // Arrange
            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            // Act
            bool expected = true;
            int expectedToExist = -1;
            for (int i = 0; i < 100; i++)
            {
                temp = rand.Next(100);
                tree.Add(temp);
                if (i == 50)
                {
                    expectedToExist = temp;
                }
            }
            bool actual = tree.Search(expectedToExist);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Search_HundredValuesList_ShouldReturnFalse()
        {
            Random rand = new Random();
            int temp;
            int notInTree = rand.Next(100);
            // Arrange
            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            // Act
            bool expected = false;
            for (int i = 0; i < 100; i++)
            {
                temp = rand.Next(100);
                if (temp != notInTree)
                {
                    tree.Add(temp);
                }
                else
                {
                    i--;
                }
                
            }
            bool actual = tree.Search(notInTree);
            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearchTreeImplementation;
using System;

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
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LCA_Csharp;

namespace LCATests
{
    [TestClass]
    public class LCATests
    {
        [TestMethod]
        public void TestLCAMethod()
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            tree.root.right.left = new Node(6);
            tree.root.right.right = new Node(7);

            Assert.AreEqual(2, tree.FindLCA(4, 5).data);
            Assert.AreEqual(1, tree.FindLCA(4, 1).data);
            Assert.AreEqual(2, tree.FindLCA(4, 5).data);
            Assert.AreEqual(2, tree.FindLCA(4, 2).data);
            Assert.AreEqual(3, tree.FindLCA(7, 6).data);
            Assert.ThrowsException<System.NullReferenceException>(() => tree.FindLCA(10, 9).data);
        }
    }
}

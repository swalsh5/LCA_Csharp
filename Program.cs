using System;

//C# implementation to find lowest common ancestor of 
// n1 and n2 using one traversal of binary tree
namespace LCA_Csharp
{

	public class LCA
	{
		static void Main(string[] args)
		{
			BinaryTree tree = new BinaryTree();
			tree.root = new Node(1);
			tree.root.left = new Node(2);
			tree.root.right = new Node(3);
			tree.root.left.left = new Node(4);
			tree.root.left.right = new Node(5);
			tree.root.right.left = new Node(6);
			tree.root.right.right = new Node(7);
			Console.WriteLine("LCA(4, 5) = {0}", tree.FindLCA(4, 5).data);
			Console.WriteLine("LCA(4, 6) = {0}", tree.FindLCA(4, 6).data);
			Console.WriteLine("LCA(3, 4) = {0}", tree.FindLCA(3, 4).data);
			Console.WriteLine("LCA(2, 4) = {0}", tree.FindLCA(2, 4).data);
			Console.WriteLine("LCA(7, 6) = {0}", tree.FindLCA(7, 6).data);
		}
	}
}

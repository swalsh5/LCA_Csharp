using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Csharp
{
	//class to implement binary tree
	class BinaryTree
	{
		//Root of the Binary Tree 
		public Node root;

		public Node FindLCA(int n1, int n2)
		{
			return FindLCA(root, n1, n2);
		}

		// Returns pointer to LCA of two given 
		// values n1 and n2. This function assumes that n1 and 
		// n2 are present in Binary Tree 
		Node FindLCA(Node node, int n1, int n2)
		{
			// Base case 
			if (node == null)
				return null;

			// If either n1 or n2 matches with root's key, report 
			// the presence by returning root (Note that if a key is 
			// ancestor of other, then the ancestor key becomes LCA 
			if (node.data == n1 || node.data == n2)
				return node;

			// Look for keys in left and right subtrees 
			Node left_lca = FindLCA(node.left, n1, n2);
			Node right_lca = FindLCA(node.right, n1, n2);

			// If both of the above calls return Non-NULL, then one key 
			// is present in once subtree and other is present in other, 
			// So this node is the LCA 
			if (left_lca != null && right_lca != null)
				return node;

			// Otherwise check if left subtree or right subtree is LCA 
			return (left_lca != null) ? left_lca : right_lca;
		}
	}
}

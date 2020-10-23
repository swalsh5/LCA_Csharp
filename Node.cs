using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Csharp
{
	/* Class containing left and right child of current 
   node and key value*/
	public class Node
	{
		public int data;
		public Node left, right;

		public Node(int item)
		{
			data = item;
			left = right = null;
		}
	}
}

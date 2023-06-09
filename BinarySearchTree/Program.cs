﻿using Algorithms.Common;
using BinarySearchTree;

Node rootNode = new Node(100);
BinaryTree tree = new BinaryTree(root: rootNode);

tree.Add(95);
tree.Add(105);
tree.Add(107);
tree.Add(104);
tree.Add(106);
tree.Add(92);
tree.Add(25);
tree.Add(34);
tree.Add(47);

tree.WriteAsDepthFirst();
tree.WriteAsBreadthFirst();

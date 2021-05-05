using System;
using System.Collections.Generic;
using System.Linq;

namespace BreadthFirst
{
    public class DFSGraphAlgorithm
    {
        public IGraphNode Search(IGraphNode root, string nameToSearchFor)
        {
            Stack<IGraphNode> stack = new Stack<IGraphNode>();
            HashSet<IGraphNode> visited = new HashSet<IGraphNode>();
            stack.Push(root);
            visited.Add(root);

            while (stack.Count > 0)
            {
                IGraphNode e = stack.Pop();
                if (e.name == nameToSearchFor)
                    return e;
                foreach (IGraphNode friend in e.Children)
                {
                    if (!visited.Contains(friend))
                    {
                        stack.Push(friend);
                        visited.Add(friend);
                    }
                }
            }
            return null;
        }

        public void Traverse(IGraphNode root)
        {
            HashSet<IGraphNode> visited = new HashSet<IGraphNode>();
            Stack<IGraphNode> stack = new Stack<IGraphNode>();
            Queue<IGraphNode> traverseOrder = new Queue<IGraphNode>();
            stack.Push(root);
            while (stack.Count != 0)
            {
                var current = stack.Pop();
                traverseOrder.Enqueue(current);
                if (!visited.Add(current))
                {
                    continue;
                }
                var reversedChildren = Enumerable.Reverse(current.Children).ToList();
                // If you don't care about the left-to-right order, remove the Reverse
                foreach (var neighbour in reversedChildren)
                {
                    stack.Push(neighbour);
                }
            }
            while (traverseOrder.Count > 0)
            {
                IGraphNode e = traverseOrder.Dequeue();
                Console.WriteLine(e);
            }

        }
    }
}
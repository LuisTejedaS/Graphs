using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreadthFirst
{
    public class BFSGraphAlgorithm
    {
        public IGraphNode Search(IGraphNode root, string nameToSearchFor)
        {
            Queue<IGraphNode> queue = new Queue<IGraphNode>();
            HashSet<IGraphNode> visited = new HashSet<IGraphNode>();
            queue.Enqueue(root);
            visited.Add(root);

            while (queue.Count > 0)
            {
                IGraphNode e = queue.Dequeue();
                if (e.name == nameToSearchFor)
                    return e;
                foreach (IGraphNode friend in e.Children)
                {
                    if (!visited.Contains(friend))
                    {
                        queue.Enqueue(friend);
                        visited.Add(friend);
                    }
                }
            }
            return null;
        }

        public void Traverse(IGraphNode root)
        {
            Queue<IGraphNode> traverseOrder = new Queue<IGraphNode>();

            Queue<IGraphNode> queue = new Queue<IGraphNode>();
            HashSet<IGraphNode> visited = new HashSet<IGraphNode>();
            queue.Enqueue(root);
            int level = 1;
            root.level = level;
            visited.Add(root);

            while (queue.Count > 0)
            {
                IGraphNode e = queue.Dequeue();
                traverseOrder.Enqueue(e);
                foreach (IGraphNode emp in e.Children)
                {
                    if (!visited.Contains(emp))
                    {
                        queue.Enqueue(emp);
                        visited.Add(emp);
                        emp.level = e.level + 1;
                    }
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
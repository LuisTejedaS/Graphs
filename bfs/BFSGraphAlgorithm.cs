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
 
                Queue<IGraphNode> Q = new Queue<IGraphNode>();
                HashSet<IGraphNode> S = new HashSet<IGraphNode>();
                Q.Enqueue(root);
                int level = 1;
                root.level = level;
                S.Add(root);
                
                while (Q.Count > 0)
                {
                    IGraphNode e = Q.Dequeue();                     
                    traverseOrder.Enqueue(e);
                    foreach (IGraphNode emp in e.Children)
                    {
                        if (!S.Contains(emp))
                        {
                            Q.Enqueue(emp);
                            S.Add(emp);
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
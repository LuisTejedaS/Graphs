using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace BreadthFirst
{
    public interface IGraphNode
    {  
        int level { get; set; }
        string name { get; set; }
        string code { get; set; }
        List<IGraphNode> Children { get;   }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BreadthFirst
{
public class Account : IGraphNode
        {
            public Account(string code, string name)
            {
                this.name = name;
                this.code = code;
            }
 
            public int level { get; set; }
            public string name { get; set; }
            public string code { get; set; }

            public List<IGraphNode> Children
            {
                get
                {
                    return CildrenList;
                }
            }
 
            public void isParentOf(IGraphNode p)
            {
                CildrenList.Add(p);
            }
 
            List<IGraphNode> CildrenList = new List<IGraphNode>();
 
            public override string ToString()
            {
                return code + " " + name + " " + level;
            }
        }
}
using System;
using System.Collections.Generic;
using System.Text;
namespace TrieFunctions
{

    class Node
    {
        char content;
        internal bool ends;
        Node parent;
        Node[] child = new Node[26];
        public Node(char c, Node pi)
        {
            parent = pi;
            content = c;
        }

        public Node getChild(char c)
        {
            return child[c - 'a'];
        }

        public void addChild(Node node)
        {
            child[node.content - 'a'] = node;
        }
    }
}
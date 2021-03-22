using System;
using System.Collections.Generic;
using System.Text;
namespace TrieFunctions
{

    class Trie
    {
        Node root = new Node('\0', null);

        public void insert(String word)
        {
            Node current = root;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                Node sub = current.getChild(c);
                if (sub != null)
                {
                    current = sub;
                }
                else
                {
                    current.addChild(new Node(c, current));
                    current = current.getChild(c);
                }
                if (i == word.Length - 1) current.ends = true;
            }
        }

        public bool search(String word)
        {
            Node current = root;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                Node sub = current.getChild(c);
                if (sub == null)
                {
                    return false;
                }
                current = sub;
            }
            return current.ends;
        }
    }
}
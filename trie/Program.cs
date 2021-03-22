using System;

namespace TrieFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Trie trie = new Trie();

            trie.insert("zapato");

            Console.WriteLine(trie.search("zapato"));
        }
    }
}

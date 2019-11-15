﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace BreadthFirst
{
    class Program
    {
        
        static void Main(string[] args)
        {
             
            AccountTreeBuillder builder = new AccountTreeBuillder();
            IGraphNode root = (IGraphNode) builder.BuildAccountGraph();
            BFSGraphAlgorithm algo = new  BFSGraphAlgorithm();
            

            Console.WriteLine("Traverse Graph\n------");
            algo.Traverse(root);

            Console.WriteLine("\nSearch in Graph\n------");
            IGraphNode e = algo.Search(root, "Pasivo");
            Console.WriteLine(e == null ? "Account not found" : e.name);
            e = algo.Search(root, "Proveedores Nacionales");
            Console.WriteLine(e == null ? "Account not found" : e.name);
            e = algo.Search(root, "Activo");
            Console.WriteLine(e == null ? "Account not found" : e.name);

        }
    }
}
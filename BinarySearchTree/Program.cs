using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(10);
            //tree.Add(15);
            //tree.Add(20);
            //tree.Add(25);
            tree.Add(7);
            //tree.Add(3);
            tree.Add(9);
            tree.Add(8);
            tree.Add(15);
            Console.ReadLine();

        }
    }
}

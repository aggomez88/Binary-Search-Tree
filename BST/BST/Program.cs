using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Add(100);
            tree.Add(110);
            tree.Add(56);
            tree.Add(75);
            
            tree.Search(56);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class Tree
    {
        //------------------------MEMBER VARIABLES-----------//
        public Node root;
        //------------------------CONSTRUCTOR----------------//
        public Tree()
        {

        }
        //-------------------------MEMBER METHODS------------//
        public void Add(int data)
        {
            Node current;

            if (root == null)
            {
                root = new Node(data);
            }
            current = root;

            while (data >= current.data)
            {
                if (current.rightChild == null)
                {
                    current.rightChild = new Node(data);
                }
                else
                {
                    current = current.rightChild;
                }
            }
            while (data <= current.data)
            {
                if (current.leftChild == null)
                {
                    current.leftChild = new Node(data);
                }
                else
                {
                    current = current.leftChild;
                }
            }
        }
        public int Search(Node node, int data)
        {

            Node current;
            current = root;
            if (root == null)
            {
                return node.data;
            }
            while (true)
            {
                if (current.rightChild == null)
                {
                    return node.data;
                }
                else if (current == current.rightChild)
                {
                    return current.data;
                }
            }

            while (true)
            {
                if (current.leftChild == null)
                {
                    return node.data;
                }

                else if (current == current.leftChild)
                {
                    return current.data;
                }
            }
                
            

            
        }

    }
}

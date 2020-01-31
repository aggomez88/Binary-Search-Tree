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
            else
            {
                current = root;

                while (true)
                {
                    if (data >= current.data)
                    {
                        if (current.rightChild == null)
                        {
                            current.rightChild = new Node(data);
                            break;
                        }
                        else
                        {
                            current = current.rightChild;
                        }
                    }
                    else
                    {
                        if (current.leftChild == null)
                        {
                            current.leftChild = new Node(data);
                            break;
                        }
                        else
                        {
                            current = current.leftChild;
                        }
                    }

                }
            }
            
        }
        public bool Search(int data)
        {
            
            if (root == null)
            {
                return false;
            }

            Node current;
            current = root;

            while (true)
            {
                if(current.data == data)
                {
                    return true;
                }
                else if (data >= current.data)
                {
                    if (current.rightChild == null)
                    {
                        return false;
                    }
                    else
                    {
                        current = current.rightChild;
                    }
                }
                else
                {
                    if (current.leftChild == null)
                    {
                        return false;
                    }
                    else
                    {
                        current = current.leftChild;
                    }
                }
            }

          
                
            

            
        }

    }
}

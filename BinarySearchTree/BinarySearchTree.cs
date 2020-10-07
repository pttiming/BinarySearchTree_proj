using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        //Member Variables
        Node root;
        

        //Constructor
        public BinarySearchTree()
        {
            root = null;
        }
        //Methods
        public void Add(int data)
        {
            Node newNode = new Node(data);
            Node parent;
            Node current;

            if (root == null)
            {
                Console.WriteLine($"{newNode.data} inserted as root");
                root = newNode;
                return;
            }

            current = root;

            while (current != null)
            {
                parent = current;
                if(newNode.data < current.data)
                {
                   if(current.leftNode != null)
                    {
                        Console.WriteLine(current.data);
                        current = current.leftNode;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(current.data);
                        Console.WriteLine($"{newNode.data} inserted");
                        parent.leftNode = newNode;
                        break;
                    }
                }
                else if (newNode.data > current.data)
                {
                    if (current.rightNode != null)
                    {
                        Console.WriteLine(current.data);
                        current = current.rightNode;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(current.data);
                        Console.WriteLine($"{newNode.data} inserted");
                        parent.rightNode = newNode;
                        break;
                    }
                }
                else if(newNode.data == current.data)
                {
                    Console.WriteLine("Current Data matches current node.  Counter Increased");
                    current.counter++; //Counter used to keep track of duplicate values added.  
                    break;
                }
            }


        }

        public bool Search(int data)
        {
            Node current;
            current = root;

            while (current != null)
            {
                if (data == current.data)
                    return true;
                else if(data < current.data)
                {
                    if(current.leftNode == null)
                    {
                        return false;
                    }
                    else
                    {
                        current = current.leftNode;
                        continue;
                    }  
                }
                else if (data > current.data)
                {
                    if (current.rightNode == null)
                    {
                        return false;
                    }
                    else
                    {
                        current = current.rightNode;
                        continue;
                    }
                }
            }
            return false;
            
        }
    }

}

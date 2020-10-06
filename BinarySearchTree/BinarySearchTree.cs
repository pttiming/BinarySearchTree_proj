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
        int value;
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
            Node current;
            Node temp;

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                current = root;
                temp = current;

                if(newNode.data < current.data)
                {

                }
            }


        }

        public bool Search(int data)
        {
            Node current;
            current = root;

            while (true)
            {
                if (data == current.data)
                    return true;
                else if(data < current.data && current.leftNode != null)
                {
                    current = current.leftNode;
                }
                else if (data > current.data && current.rightNode != null)
                {
                    current = current.rightNode;
                }
                else
                {
                    return false;
                }
            }
            
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDatastructsPractice.LinkedList
{
    public class LinkedLists
    {
        public Node Start { get; set; }

        public void InsertToStart(int data)
        {
            //Create a new node for the linked list
            Node newNode = new Node();
            //Insert the data into this newly created node
            newNode.Data = data;
            //Point the new node to the current start
            newNode.Next = Start;
            //Make the Start be the new node to insert it to the beginning of the linked list
            Start = newNode;
        }

        //Deletion at the start is simply changing the start to a different node
        public Node DeleteStartNode()
        {
            //Assign node we want to replace
            Node temp = Start;

            //Create the new start
            Start = Start.Next;

            return temp;
        }

        //Summary:
            //Display values in the linked list
        public void IterateLinkedList()
        {
            Console.WriteLine("Iterating thru the list...");
            var start = Start;

            while(start != null)
            {
                start.DisplayNode();
                start = start.Next;
            }
        }
    }
}

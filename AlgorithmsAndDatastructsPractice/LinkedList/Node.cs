using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDatastructsPractice.LinkedList
{
    //Node has two points of data
    //The actual node
    //The referance(pointer)
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        //Just to display, not apart of the data structure
        public void DisplayNode()
        {
            Console.WriteLine(Data);
        }
    }
}

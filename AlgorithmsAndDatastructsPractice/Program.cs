using AlgorithmsAndDatastructsPractice.AbstratctDataTypes;
using AlgorithmsAndDatastructsPractice.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array = AlgorithmsAndDatastructsPractice.Arrays.Array;

namespace AlgorithmsAndDatastructsPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Array array = new Array();

            array.DataInsert();
            //// Array inserting at last position
            array.InsertLast(8);

            //Console.WriteLine(array.intArray);
            //Console.ReadLine();

            //Array inserting at start position
            //array.InsertFirst(8);

            //array.intArray[0] = 8;

            //Inserting data anywhere in array
            //array.IndexInsert(2, 8);
        }
    }
}

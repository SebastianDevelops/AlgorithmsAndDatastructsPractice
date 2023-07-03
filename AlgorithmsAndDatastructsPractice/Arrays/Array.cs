using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDatastructsPractice.Arrays
{
    public class Array
    {
        //Arrays
        //Array Insertions & Deletions

        //Inserting into the end of an array
        public Array()
        {
            this.intArray = new int[6];
        }

        public int[] intArray { get; set; }

        public int length { get; set; } = 0;

        public void DataInsert()
        {
            for(int i = 0; i < 3; i++)
            {
                intArray[length] = i + 1;
                length++;
            }
        }

        public void  IndexInsert(int index, int value)
        {
            for (int i = 4; i >= index; i--)
            {
                //Moving all values to the right
                intArray[i + 1] = intArray[i];
            }

            intArray[index] = value;
        }

        public void InsertFirst(int value)
        {
            for(int i = 3; i >= 0;i--)
            {
                //Moving all values to the right
                intArray[i + 1] = intArray[i];
            }
            intArray[0] = value;
        }

        public void InsertLast(int value)
        {
            intArray[length] = value;
            length++;
        }
    }
}

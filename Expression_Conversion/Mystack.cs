using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_Conversion
{
    public class MyStack //Stack class
    {
        public int MaxSize; //maxsize
        public string[] Arr; //array to stroe datas
        public int Top; //Top of the stack

        public MyStack(int max) //construction
        {
            if (max < 0)
            {
                throw new Exception("The max Number cannot be less than 0");
            }
            else
            {
                MaxSize = max;
                Arr = new string[MaxSize];
                Top = -1;
            }
        }

        public bool EmptyStack() //to see if the stack is empty
        {
            if (Top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FullStack() //to see if the stack is full
        {
            if (Top == MaxSize - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Push(string input) //to add a new data to stack
        {
            if (FullStack())
            {
            }
            else
            {
                Arr[++Top] = input;
            }
        }

        public string Pop() // to remove and a new data from stack and returning it
        {
            if (EmptyStack())
            {
                return null;
            }
            else
            {
                return Arr[Top--];
            }
        }

        public string Last() // just return the last data in stack
        {
            if (EmptyStack())
            {
                return null;
            }
            else
            {
                return Arr[Top];
            }
        }

    }
}

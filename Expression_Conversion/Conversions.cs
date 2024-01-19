using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_Conversion
{
    public class Conversion
    {
        private static int GenValue(string input) //To show the value of the operator
        {
            switch (input)
            {
                case "+":
                    return 1;
                case "-":
                    return 1;
                case "*":
                    return 2;
                case "/":
                    return 2;
                case "^":
                    return 3;
                case null:
                    return 0;
                default:
                    return -1;
            }
        }

        public static string InToPost(string infix) //Infix to Postfix conversion
        {
            MyStack tempstack = new MyStack(infix.Length);
            string temp = "";

            foreach (char item in infix)
            {
                string newitem = item.ToString();

                if (newitem == "(")
                {
                    tempstack.Push(newitem);
                }
                else if (newitem == ")")
                {
                    while (tempstack.Last() != "(")
                    {
                        temp += tempstack.Pop();
                    }
                    tempstack.Pop();
                }

                else if (GenValue(newitem) == -1)
                {
                    temp += newitem;
                }

                else if (GenValue(newitem) > GenValue(tempstack.Last()) && GenValue(newitem) != -1)
                {
                    tempstack.Push(newitem);
                }
                else if (GenValue(newitem) <= GenValue(tempstack.Last()))
                {
                    while (GenValue(newitem) <= GenValue(tempstack.Last()) && tempstack.EmptyStack() == false)
                    {
                        temp += tempstack.Pop();
                    }
                    tempstack.Push(newitem);
                }
            }
            while (tempstack.EmptyStack() == false)
            {
                temp += tempstack.Pop();
            }
            return temp;
        }

        public static string InToPre(string infix)//Infix to Prefix conversion
        {
            string revinfix = "";
            string postfix = "";
            string prefix = "";

            for (int i = infix.Length - 1; i >= 0; i--)
            {
                if (infix[i] == '(')
                {
                    revinfix += ")";
                }
                else if (infix[i] == ')')
                {
                    revinfix += "(";
                }
                else
                    revinfix += infix[i];
            }

            postfix = Conversion.InToPost(revinfix);

            for (int i = postfix.Length - 1; i >= 0; i--)
            {
                prefix += postfix[i];
            }

            return prefix;

        }

        public static string PostToIn(string postfix)//Postfix to Infix conversion
        {
            MyStack tempstack = new MyStack(postfix.Length);
            string temp = "";
            string infix = "";

            foreach (char item in postfix)
            {
                string newitem = item.ToString();

                if (GenValue(newitem) == -1)
                {
                    tempstack.Push(newitem);
                }
                else
                {
                    temp = tempstack.Pop();
                    infix = "(" + tempstack.Pop() + newitem + temp + ")";
                    tempstack.Push(infix);
                }
            }
            return infix;
        }

        public static string PreToIn(string prefix)//Prefix to Infix conversion
        {
            MyStack tempstack = new MyStack(prefix.Length);
            string temp = "";
            string infix = "";
            string revprefix = "";

            for (int i = prefix.Length - 1; i >= 0; i--)
            {
                if (prefix[i] == '(')
                {
                    revprefix += ")";
                }
                else if (prefix[i] == ')')
                {
                    revprefix += "(";
                }
                else
                    revprefix += prefix[i];
            }
            temp = Conversion.PostToIn(revprefix);

            for (int i = temp.Length - 1; i >= 0; i--)
            {
                if (temp[i] == '(')
                {
                    infix += ")";
                }
                else if (temp[i] == ')')
                {
                    infix += "(";
                }
                else
                    infix += temp[i];
            }
            return infix;
        }

        public static string PreToPost(string prefix)//Prefix to Postfix conversion
        {
            string infix = Conversion.PreToIn(prefix);

            return Conversion.InToPost(infix);
        }

        public static string PostToPre(string postfix)//Postfix to Prefix conversion
        {
            string infix = Conversion.PostToIn(postfix);

            return Conversion.InToPre(infix);
        }
    }
}

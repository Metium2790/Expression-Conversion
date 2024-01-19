using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try //try to catch the exceptions
            {   //simple command access
                Console.WriteLine("Welcome to the expression convertor\nyou can easily convert any kind of expression to another\nJust use these commands bellow");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("1-INFIX to POSTFIX");
                Console.WriteLine("2-INFIX to PREFIX");
                Console.WriteLine("3-POSTFIX to INFIX");
                Console.WriteLine("4-PREFIX to INFIX");
                Console.WriteLine("5-PREFIX to POSTFIX");
                Console.WriteLine("6-POSTFIX to PREFIX\n");
                Console.WriteLine("0-EXIT");
                while (true)
                {
                    string infix = "";
                    string postfix = "";
                    string prefix = "";
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.Write("CMD: ");
                    string CMD = Console.ReadLine();
                    switch (CMD)
                    {
                        case "0":
                            Environment.Exit(0);
                            break;
                        case "1":
                                Console.WriteLine("Please enter your INFIX expression");
                                Console.Write("INFIX: ");
                                infix = Console.ReadLine();
                                postfix = Conversion.InToPost(infix);
                                Console.WriteLine("POSTFIX: "+postfix);
                                break;
                        case "2":
                                Console.WriteLine("Please enter your INFIX expression");
                                Console.Write("INFIX: ");
                                infix = Console.ReadLine();
                                prefix = Conversion.InToPre(infix);
                                Console.WriteLine("PREFIX: " + prefix);
                                break;
                        case "3":
                                Console.WriteLine("Please enter your POSTFIX expression");
                                Console.Write("POSTFIX: ");
                                postfix = Console.ReadLine();
                                infix = Conversion.PostToIn(postfix);
                                Console.WriteLine("INFIX: " + infix);
                                break;
                        case "4":
                                Console.WriteLine("Please enter your PREFIX expression");
                                Console.Write("PREFIX: ");
                                prefix = Console.ReadLine();
                                infix = Conversion.PreToIn(prefix);
                                Console.WriteLine("INFIX: " + infix);
                                break;
                        case "5":
                                Console.WriteLine("Please enter your PREFIX expression");
                                Console.Write("PREFIX: ");
                                prefix = Console.ReadLine();
                                postfix = Conversion.PreToPost(prefix);
                                Console.WriteLine("POSTFIX: " + postfix);
                                break;
                        case "6":
                                Console.WriteLine("Please enter your POSTFIX expression");
                                Console.Write("POSTFIX: ");
                                postfix = Console.ReadLine();
                                prefix = Conversion.PostToPre(infix);
                                Console.WriteLine("PREFIX: " + prefix);
                                break;
                        case "7":
                                Console.WriteLine("Please enter your infix expression");
                                Console.Write("INFIX: ");
                                infix = Console.ReadLine();
                                postfix = Conversion.InToPost(infix);
                                Console.WriteLine("POSTFIX: " + postfix);
                                break;
                        default:
                                Console.WriteLine("-----------please use the right commands-----------");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }
    }

}//Coded by : Mohammad Mahdi Mohammadi (AKA Metium)

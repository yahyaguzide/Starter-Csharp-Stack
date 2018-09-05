using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Starter_Csharp_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Little Stack Simulator \n Please choose a Type");
            string type = Console.ReadLine();
            switch(type)
            {
                case "int":
                case "Int":
                    Stack<int> stack = new Stack<int>();
                    break;

                case "char":
                case "Char":
                    Stack<char> stack = new Stack<char>();
                    break;
            }

            Console.Clear();

            Console.WriteLine("Options \n P for Push \n F for Flush \n G for Get \n");
            string option = Console.ReadLine();

            

            Console.ReadLine();
        }
    }
}

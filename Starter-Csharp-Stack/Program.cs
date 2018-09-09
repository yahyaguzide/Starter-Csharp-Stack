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
            Stack<string> stack = new Stack<string>();
            string option;

            Console.WriteLine("Welcome to my Little Stack Simulator \n ");
            Console.ReadLine();

            do
            {
                Console.Clear();
                Console.WriteLine("Options \n P for Push \n F for Flush \n Pp for Pull \n E for Exit \n");
                option = Console.ReadLine();
                option.ToLower();

                switch (option)
                {
                    case "p":
                        Console.WriteLine("Please enter a String");
                        stack.Push(Console.ReadLine());
                        break;
                    case "f":
                        stack.Flush();
                        break;
                    case "pp":
                        Console.WriteLine("Last Saved Object in Stack is:");
                        Console.WriteLine(stack.Pop());
                        break;
                }

                Console.WriteLine("Press a Key");
                Console.ReadLine();
            } while (option != "e");
            
        }

    }
}

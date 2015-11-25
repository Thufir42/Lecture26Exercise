using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture26Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            var counter = 1;

            try
            {

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Current stack item count: {0}", stack.GetStackCount());
                    Console.WriteLine("\n1 - Push valid object onto stack");
                    Console.WriteLine("2 - Remove the top object from the stack");
                    Console.WriteLine("3 - Clear the stack");
                    Console.WriteLine("4 - Push a null object onto the stack");
                    Console.Write("\nChoose a menu item number, or press any other key to quit: ");
                    var input = Console.ReadKey();
                    var test = input.KeyChar;
                    Console.Clear();
                    switch (test)
                    {
                        case '1':
                            stack.Push(counter);
                            Console.WriteLine("Object {0} added to stack", counter);
                            counter++;
                            break;
                        case '2':
                            Console.WriteLine(stack.Pop());
                            break;
                        case '3':
                            stack.Clear();
                            Console.WriteLine("Stack cleared.");
                            break;
                        case '4':
                            stack.Push(null);
                            break;
                        default:
                            return;
                    }
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                }
            }
            catch(InvalidOperationException message)
            {
                Console.WriteLine("Invalid Operation Exception Error received: \n\t" + message.Message);
            }

        }
    }
}


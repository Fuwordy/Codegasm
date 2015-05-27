using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace
namespace JerrysCoolAppCode
{
    // Class (contains functionality)
    class Program
    {
        // Function (entry point)
        static void Main(string[] args)
        {
            PrintFooToScreen100000Times();

            Console.WriteLine("Type a number, any number?");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == 'a')
            {
                Console.WriteLine("That is not a number! KNOCK IT OFF NOW!");
            }
            else
            {
                Console.WriteLine("Did you type {0}", keyInfo.KeyChar.ToString());
            }
        }

        /// <summary>
        /// All this function does is print Foo to the screen
        /// </summary>
        static void PrintFooToScreen()
        {
            Console.WriteLine("Foo");
        }

        static void PrintFooToScreen100000Times()
        {
            for(int counter=0; counter <= 100000; counter++)
            {
                PrintFooToScreen();
            }
        }
    }
}

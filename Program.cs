using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 0;
            int selection = 0;
            int menuItem = 0;
            ConsoleKeyInfo input;

            do
            {
                Console.WriteLine("1 - Manual selection\n2 - Auto selection\n");
                Int32.TryParse(Console.ReadLine(), out menuItem);
                switch (menuItem)
                {
                    case 1:
                        Console.WriteLine("Input tree height:");
                        Int32.TryParse(Console.ReadLine(), out height);
                        Console.WriteLine("Select tree:\n 1 - Tree;\n 2 - Apple; \n 3 - Cherry");
                        Int32.TryParse(Console.ReadLine(), out selection);
                        Select(height, selection);
                        break;
                    case 2:
                        Int32.TryParse(args[0], out height);
                        string s = args[1];
                        if (s == "tree")
                        {
                            selection = 1;
                            Select(height, selection);
                        }
                        else if (s == "apple")
                        {
                            selection = 2;
                            Select(height, selection);
                        }
                        else if (s == "cherry")
                        {
                            selection = 3;
                            Select(height, selection);
                        }
                        else
                        {
                            Console.WriteLine("Wrong argument");
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong selection");
                        break;
                }


                Console.WriteLine("\nEscape - exit;\n any key - continue..");
                input = Console.ReadKey();
                Console.Clear();
            } while (input.Key != ConsoleKey.Escape);
        }

        static void Select(int height, int selection)
        {
            switch (selection)
            {
                case 1:
                    //Draw tree
                    Tree tree = new Tree();
                    tree.Draw(height);
                    break;
                case 2:
                    //Draw apple
                    Tree apple = new Apple();
                    apple.Draw(height);
                    break;
                case 3:
                    //Draw cherry
                    Tree cherry = new Cherry();
                    cherry.Draw(height);
                    break;
                default:
                    Console.WriteLine("Wrong selection");
                    break;
            }
        }
    }
}

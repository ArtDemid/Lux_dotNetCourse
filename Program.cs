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
            string u_str = "";
            ConsoleKeyInfo input;

            do
            {
                Console.WriteLine("1 - Manual selection\n2 - Auto selection\n3 - Polindrom\n4 - Is String Valid");
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
                    case 3:
                        Console.WriteLine("Input string for verification:");
                        u_str = Console.ReadLine();
                        char[] u_str_char = new char[u_str.Length];
                        u_str_char = u_str.ToCharArray();
                        string v_str = "";
                        for (int i = u_str_char.Length-1; i >= 0; i--)
                        {
                            v_str = v_str + u_str[i];
                        }
                        if (v_str == u_str)
                        {
                            Console.WriteLine("This line is polindrom");
                        }
                        else
                        {
                            Console.WriteLine("Not polindrom");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Input string for verification:");
                        u_str = Console.ReadLine();
                        if (StringValidator(u_str))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
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

        static bool StringValidator(string input)
        {
            bool result = false;
            result = input.All(Char.IsLetter);
            return result;
        }

    }
}

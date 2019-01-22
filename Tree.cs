using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    class Tree
    {
        public Tree()
        {
            Console.WriteLine("Tree class called");
        }

        public virtual void Draw(int heigth)
        {
            int iteration = 0;
            while (heigth > iteration)
            {
                for (int i = 0; i <= iteration; i++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                iteration++;
            }
        }
    }
}

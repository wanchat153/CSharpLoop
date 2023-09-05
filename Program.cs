using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Loop while
            int i = 1;
            while (i < 5)
            {
                Console.WriteLine(i);

                //i + 1; OR i++;
                i = i + 1;
            }*/

            //Loop for two times table
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine("2 * " + i + " = " + (i*2));
            }
            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}

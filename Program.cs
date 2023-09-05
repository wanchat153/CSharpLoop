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

            //Loop for i = 0; < 3;  i+1;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("M");
            }
            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}

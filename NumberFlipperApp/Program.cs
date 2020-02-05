using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFlipperApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 3 and 9");
            int numInput= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i < (numInput+1); i++)
            {
                Console.Write(i+" ");
                var z = i;
                for (int x = 1; x < numInput ; x++) {
                    z += i;
                    Console.Write(z + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Flip on 1) Horizon, 2) Vertical, 3) Diagonal Left, 4) Diagonal Right, 5) To End: ");
            int choiceSelected = Convert.ToInt32(Console.ReadLine());
            if (choiceSelected == 1)
            {
                for (int i = numInput; i < (numInput + 1)&&i>0; i--)
                {
                    Console.Write(i + " ");
                    var z = i;
                    for (int x = 1; x < numInput; x++)
                    {
                        z += i;
                        Console.Write(z + " ");
                    }
                    Console.WriteLine();
                   
                }
                Console.ReadLine();
            }
            if (choiceSelected == 2)
            {
                for (int i = 1; i < (numInput + 1); i++)
                {
                    Console.Write(i + " ");
                    var z = i;
                    for (int x = 1; x < numInput; x++)
                    {
                        z += i;
                        
                    }
                    for (int x = z; x > numInput; x++)
                    {
                        z -= i;
                        Console.Write(z + " ");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}

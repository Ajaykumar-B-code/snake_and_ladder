using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace snake_and_ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player1 = 0;
            /*List<int> v = new List<int>();
            v.Add(1);
            v.Add(2);
            foreach(int i in v)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();*/

            Random rand = new Random();
            int random_number = rand.Next(6);
            random_number++;
            Console.Write("The number on dice is : ");
            Console.WriteLine(random_number);

            Console.ReadLine();
        }
    }
}

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
            Random rand = new Random();
            int random_number = rand.Next(6);
            random_number++;
            Console.WriteLine($"The number on the dice is {random_number}");
            int option = rand.Next(3);
            switch (option)
            {
                case 0:
                    Console.WriteLine("No move");
                    break;
                case 1:
                    Console.WriteLine("It is a ladder");
                    player1 += random_number;
                    break;
                case 2:
                    Console.WriteLine("It is a snake");
                    if (random_number > player1)
                    {
                        player1 = 0;
                    }
                    else
                    {
                        player1 -= random_number;
                    }
                    break;
            }
            Console.Write("player postiton is : ");
            Console.WriteLine(player1);
            Console.ReadLine();
            
            
      
        }
    }
}

using System;
using System.Collections.Generic;

namespace aoc2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int x = 0, y = 0;
            
            while(true)
            {
                line = Console.ReadLine();
                
                if(line == null)
                    break;

                string[] commands = line.Split(' ');
                string direction = commands[0];
                int amount = Int32.Parse(commands[1]);

                switch(direction)
                {
                    case "forward":
                        x += amount;
                        break;
                    
                    case "down":
                        y += amount;
                        break;

                    case "up":
                        y -= amount;
                        break;
                }
            }

            

            Console.WriteLine(x * y);
        }
    }
}

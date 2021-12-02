using System;
using System.Collections.Generic;

namespace aoc2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            List<int> input = new List<int>();
            int x = 0, y = 0, aim = 0;
            
            while(true)
            {
                line = Console.ReadLine();
                
                if(line == null)
                    break;

                string[] commands = line.Split(' ');
                string direction = commands[0];
                int units = Int32.Parse(commands[1]);

                switch(direction)
                {
                    case "forward":
                        x += units;
                        y += aim * units;
                        break;
                    
                    case "down":
                        aim += units;
                        break;

                    case "up":
                        aim -= units;
                        break;
                }
            }

            Console.WriteLine(x * y);
        }
    }
}

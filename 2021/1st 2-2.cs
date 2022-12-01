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
            int counter = 0;
            
            while(true)
            {
                line = Console.ReadLine();
                int number;
                bool ok = Int32.TryParse(line, out number);

                if(ok)
                    input.Add(number);
                else
                    break;
            }

            for(int i = 0; i < input.Count - 3; i++)
            {
                int windowOne = input[i] + input[i + 1] + input[i + 2];
                int windowTwo = input[i + 1] + input[i + 2] + input[i + 3];

                if(windowTwo > windowOne)
                    counter++;
            }

            Console.WriteLine(counter);
        }
    }
}

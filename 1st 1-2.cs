using System;

namespace aoc2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int prev = 0, current, counter = 0;
            bool firstLine = true;

            while (true)
            {
                line = Console.ReadLine();

                try
                {
                    current = Int32.Parse(line);
                }
                catch (Exception e)
                {
                    break;
                }

                if (firstLine)
                {
                    firstLine = false;
                    prev = current;
                }
                else
                {
                    if (current > prev)
                        counter++;

                    prev = current;
                }
            }

            Console.WriteLine(counter);
        }
    }
}

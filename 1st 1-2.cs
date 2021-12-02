using System;

namespace aoc2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int prev = 0, current, counter = 0;
            bool firstLine = true;

            while (true)
            {
                try
                {
                    current = Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
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

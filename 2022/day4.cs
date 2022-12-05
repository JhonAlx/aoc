using System;
using System.Collections.Generic;
using System.IO;

namespace aoc
{
    public class Program
    {
        static int PartOne()
        {
            var counter = 0;
            
            foreach(var line in File.ReadAllLines("input.txt"))
            {
                var s = line.Split(',');
                var r1 = s[0].Split('-');
                var r2 = s[1].Split('-');
                var start1 = int.Parse(r1[0]);
                var end1 = int.Parse(r1[1]);
                var start2 = int.Parse(r2[0]);
                var end2 = int.Parse(r2[1]);

                if((start1 <= start2 && end1 >= end2) || (start2 <= start1 && end2 >= end1))
                    counter++;
            }

            return counter;
        }

        static int PartTwo()
        {
            var counter = 0;
            
            foreach(var line in File.ReadAllLines("input.txt"))
            {
                var s = line.Split(',');
                var r1 = s[0].Split('-');
                var r2 = s[1].Split('-');
                var start1 = int.Parse(r1[0]);
                var end1 = int.Parse(r1[1]);
                var start2 = int.Parse(r2[0]);
                var end2 = int.Parse(r2[1]);

                if((start1 <= end2 && start2 <= end1) || (start2 <= end1 && start1 <= end2))
                    counter++;
            }

            return counter;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Part 1 > {PartOne()}");
            Console.WriteLine($"Part 2 > {PartTwo()}");
        }
    }
}


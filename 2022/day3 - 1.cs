using System;
using System.Collections.Generic;
using System.IO;

namespace aoc
{
    public class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            
            foreach (string line in File.ReadAllLines("input.txt"))
            {
                var first = line.Substring(0, line.Length / 2).ToCharArray();
                var second = line.Substring(line.Length / 2, line.Length / 2).ToCharArray();
                var intersected = first.Intersect(second).ToList()[0];

                counter += char.IsUpper(intersected) ? (int)intersected - 38 : (int)intersected - 96;
            }

            Console.WriteLine(counter);
        }
    }
}

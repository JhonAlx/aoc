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
            var input = File.ReadAllLines("input.txt");

            for(var i = 0; i < input.Length; i += 3)
            {
                var first = input[i].ToCharArray();
                var second = input[i + 1].ToCharArray();
                var third = input[i + 2].ToCharArray();
                var intersected = first.Intersect(second.Intersect(third)).ToList()[0];

                counter += char.IsUpper(intersected) ? (int)intersected - 38 : (int)intersected - 96;
            }

            Console.WriteLine(counter);
        }
    }
}

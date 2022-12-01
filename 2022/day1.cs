using System;
using System.Collections.Generic;
using System.IO;

namespace aoc
{
    public class Elf
    {
        public List<int> calories { get; set; } = new List<int>();
        public int total { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<Elf> elves = new List<Elf>();
            Elf elf = new Elf();

            foreach (string line in File.ReadAllLines("input.txt"))
            {
                if (string.IsNullOrEmpty(line))
                {
                    elf.total = elf.calories.Sum();
                    elves.Add(elf);
                    elf = new Elf();
                }
                else
                    elf.calories.Add(Int32.Parse(line));
            }

            Console.WriteLine($"Part 1 > {elves.Max(x => x.total)}");
            Console.WriteLine($"Part 2 > {elves.OrderByDescending(x => x.total).Take(3).Sum(x => x.total)}");
        }
    }
}

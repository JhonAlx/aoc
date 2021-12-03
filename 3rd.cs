using System;
using System.Collections.Generic;
using System.Text;

namespace aoc2021
{
    class Program
    {
        static List<char[]> GetCuratedList(List<char[]> input, string type, int pos)
        {
            List<char[]> temp = new List<char[]>();
            int count0 = 0, count1 = 0;

            if (input.Count == 1 || pos == input[0].Length)
                return input;

            for (var j = 0; j < input.Count; j++)
            {
                if (input[j][pos] == '0')
                    count0++;
                else
                    count1++;
            }

            switch (type)
            {
                case "0":

                    if (count0 <= count1)
                    {
                        for (var j = 0; j < input.Count; j++)
                            if (input[j][pos] == '0')
                                temp.Add(input[j]);
                    }
                    else
                    {
                        for (var j = 0; j < input.Count; j++)
                            if (input[j][pos] == '1')
                                temp.Add(input[j]);
                    }

                    break;

                case "1":

                    if (count1 >= count0)
                    {
                        for (var j = 0; j < input.Count; j++)
                            if (input[j][pos] == '1')
                                temp.Add(input[j]);
                    }
                    else
                    {
                        for (var j = 0; j < input.Count; j++)
                            if (input[j][pos] == '0')
                                temp.Add(input[j]);
                    }

                    break;
            }

            input = temp;
            pos++;

            return GetCuratedList(input, type, pos);
        }

        static void PartOne(List<char[]> input)
        {
            int count0, count1, gamma, epsilon;
            StringBuilder gammaSb = new StringBuilder();

            for (var i = 0; i < input[0].Length; i++)
            {
                count0 = 0;
                count1 = 0;

                for (var j = 0; j < input.Count; j++)
                {
                    if (input[j][i] == '0')
                        count0++;
                    else
                        count1++;
                }

                if (count0 > count1)
                    gammaSb.Append('0');
                else
                    gammaSb.Append('1');
            }

            gamma = Convert.ToInt32(gammaSb.ToString(), 2);
            epsilon = ~gamma & 0x000000FFF;
            Console.WriteLine(gamma * epsilon);
        }

        static void PartTwo(List<char[]> input)
        {
            int oxygen, co2;
            
            oxygen = Convert.ToInt32(new string(GetCuratedList(input, "1", 0)[0]), 2);
            co2 = Convert.ToInt32(new string(GetCuratedList(input, "0", 0)[0]), 2);

            Console.WriteLine(oxygen * co2);
        }

        static void Main(string[] args)
        {
            string line;
            List<char[]> input = new List<char[]>();

            while (true)
            {
                line = Console.ReadLine();

                if (line == null)
                    break;

                input.Add(line.ToCharArray());
            }

            PartOne(input);
            PartTwo(input);
        }
    }
}

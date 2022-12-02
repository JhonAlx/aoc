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

                var input = line.Split(" ");
                var shape = ""; // (r)ock/(p)aper/(s)cissors

                switch (input[0])
                {
                    case "A":
                        switch (input[1])
                        {
                            case "X":
                                shape = "s";
                                break;
                            case "Y":
                                shape = "r";
                                break;
                            case "Z":
                                shape = "p";
                                break;
                        }

                        break;
                    case "B":
                        switch (input[1])
                        {
                            case "X":
                                shape = "r";
                                break;
                            case "Y":
                                shape = "p";
                                break;
                            case "Z":
                                shape = "s";
                                break;
                        }

                        break;
                    case "C":
                        switch (input[1])
                        {
                            case "X":
                                shape = "p";
                                break;
                            case "Y":
                                shape = "s";
                                break;
                            case "Z":
                                shape = "r";
                                break;
                        }

                        break;
                }

                switch (shape)
                {
                    case "r":
                        counter += 1;
                        break;
                    case "p":
                        counter += 2;
                        break;
                    case "s":
                        counter += 3;
                        break;
                }

                switch (input[1])
                {
                    case "X":
                        counter += 0;
                        break;
                    case "Y":
                        counter += 3;
                        break;
                    case "Z":
                        counter += 6;
                        break;
                }
            }

            Console.WriteLine(counter);
        }
    }
}

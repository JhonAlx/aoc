//ugly af

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
                var status = ""; // (w)in/(d)raw/(l)oss

                Console.WriteLine($"{input[0]} - {input[1]}");
                switch (input[1])
                {
                    case "X":
                        counter += 1;
                        break;
                    case "Y":
                        counter += 2;
                        break;
                    case "Z":
                        counter += 3;
                        break;
                }

                switch (input[0])
                {
                    case "A":
                        switch (input[1])
                        {
                            case "X":
                                status = "d";
                                break;
                            case "Y":
                                status = "w";
                                break;
                            case "Z":
                                status = "l";
                                break;
                        }

                        break;
                    case "B":
                        switch (input[1])
                        {
                            case "X":
                                status = "l";
                                break;
                            case "Y":
                                status = "d";
                                break;
                            case "Z":
                                status = "w";
                                break;
                        }

                        break;
                    case "C":
                        switch (input[1])
                        {
                            case "X":
                                status = "w";
                                break;
                            case "Y":
                                status = "l";
                                break;
                            case "Z":
                                status = "d";
                                break;
                        }

                        break;
                }
                Console.WriteLine(status);

                switch (status)
                {
                    case "w":
                        counter += 6;
                        break;
                    case "d":
                        counter += 3;
                        break;
                    case "l":
                        counter += 0;
                        break;
                }

                Console.WriteLine(counter);
            }

            Console.WriteLine(counter);
        }
    }
}

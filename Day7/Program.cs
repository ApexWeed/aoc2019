using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new[] {3, 8, 1001, 8, 10, 8, 105, 1, 0, 0, 21, 46, 59, 84, 93, 102, 183, 264, 345, 426, 99999, 3, 9, 1002, 9, 4, 9, 1001, 9, 3, 9, 102, 2, 9, 9, 1001, 9, 5, 9, 102, 3, 9, 9, 4, 9, 99, 3, 9, 1002, 9, 3, 9, 101, 4, 9, 9, 4, 9, 99, 3, 9, 1002, 9, 4, 9, 1001, 9, 4, 9, 102, 2, 9, 9, 1001, 9, 2, 9, 1002, 9, 3, 9, 4, 9, 99, 3, 9, 1001, 9, 5, 9, 4, 9, 99, 3, 9, 1002, 9, 4, 9, 4, 9, 99, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 99, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 99, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 99, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 99, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 99};

            var maximumPower = 0;
            for (var i = 10000; i < 100000; i++)
            {
                var phases = i.ToString().Select(c => c - '0').ToArray();
                if (phases.Distinct().Count() != 5 || new[] {5, 6, 7, 8, 9}.Any(x => phases.Any(p => p == x)))
                    continue;

                var power = CalculatePower(input, phases);

                if (power > maximumPower)
                    maximumPower = power;
            }

            Console.WriteLine(maximumPower);

            maximumPower = 0;
            for (var i = 10000; i < 100000; i++)
            {
                var phases = i.ToString().Select(c => c - '0').ToArray();
                if (phases.Distinct().Count() != 5 || new[] {0, 1, 2, 3, 4}.Any(x => phases.Any(p => p == x)))
                    continue;

                var power = CalculatePower(input, phases);

                if (power > maximumPower)
                    maximumPower = power;

            }

            Console.WriteLine(maximumPower);
        }

        private static int CalculatePower(int[] input, int[] phases)
        {
            var amplifiers = new[]
            {
                new Interpreter(input.ToArray(), new List<int> {phases[0], 0}, true),
                new Interpreter(input.ToArray(), new List<int> {phases[1]}, true),
                new Interpreter(input.ToArray(), new List<int> {phases[2]}, true),
                new Interpreter(input.ToArray(), new List<int> {phases[3]}, true),
                new Interpreter(input.ToArray(), new List<int> {phases[4]}, true)
            };

            var current = 0;
            var output = new List<int>();
            while (current >= 0)
            {
                var currentAmp = amplifiers[current % 5];

                if (currentAmp.Halted || !currentAmp.Input.Any())
                {
                    if (current % 5 == 4)
                        break;

                    current++;
                    continue;
                }

                if (currentAmp.Pointer == 0)
                    currentAmp.Run();
                else
                    currentAmp.Resume();

                if (current % 5 == 4)
                    output.AddRange(currentAmp.Output);

                amplifiers[(current + 1) % 5].Input.AddRange(currentAmp.Output);
                currentAmp.Output.Clear();

                current++;
            }

            return output.Last();
        }

        private static int Run(int[] program, int[] input, out int[] output)
        {
            var interpreter = new Interpreter(program, input.ToList(), false);
            interpreter.Run();

            output = interpreter.Output.ToArray();
            return output[0];
        }

        private class Interpreter
        {
            public int[] Memory { get; set; }
            public List<int> Input { get; set; }
            public List<int> Output { get; set; }
            public List<string> Diagnostics { get; set; }
            public bool Halted { get; set; }
            public bool HaltOnIO { get; set; }

            public int Pointer { get; private set; }

            public Interpreter(int[] memory) : this(memory, new List<int>(), false)
            { }

            public Interpreter(int[] memory, List<int> input, bool haltOnIO)
            {
                Memory = memory;
                Input = input;
                HaltOnIO = haltOnIO;
            }

            public int Run()
            {
                Pointer = 0;
                Output = new List<int>();
                Resume();

                return Memory[0];
            }

            public void Resume()
            {
                Diagnostics = new List<string>();
                Halted = false;
                while (Pointer < Memory.Length)
                {
                    var op = Memory[Pointer] % 100;
                    var modes = (Memory[Pointer] - Memory[Pointer] % 100).ToString().Reverse().Skip(2).Concat(new[] {'0', '0', '0'}).Select(c => c - '0').ToArray();

                    int Arg(int offset) => modes[offset - 1] == 0 ? Memory[Memory[Pointer + offset]] : Memory[Pointer + offset];
                    int Val(int offset) => Memory[Pointer + offset];

                    var start = Pointer;
                    var action = string.Empty;

                    switch (op)
                    {
                        case 01:
                        {
                            var arg1 = Arg(1);
                            var arg2 = Arg(2);
                            var dest = Val(3);

                            Memory[dest] = arg1 + arg2;
                            action = $"{dest:0000} <- {arg1 + arg2}";
                            Pointer += 4;
                            break;
                        }
                        case 02:
                        {
                            var arg1 = Arg(1);
                            var arg2 = Arg(2);
                            var dest = Val(3);

                            Memory[dest] = arg1 * arg2;
                            action = $"{dest:0000} <- {arg1 * arg2}";
                            Pointer += 4;
                            break;
                        }
                        case 03:
                        {
                            if (HaltOnIO && !Input.Any())
                                return;

                            var input = Input.First();
                            var dest = Val(1);

                            Memory[dest] = input;
                            Input = Input.Skip(1).ToList();
                            action = $"{dest:0000} <- {input}";
                            Pointer += 2;
                            break;
                        }
                        case 04:
                        {
                            var src = Val(1);
                            var value = Arg(1);

                            Output.Add(value);
                            action = $"{src:0000} -> {value}";
                            Pointer += 2;
                            break;
                        }
                        case 05:
                        {
                            var arg1 = Arg(1);
                            var dest = Arg(2);

                            if (arg1 != 0)
                            {
                                action = $"! {dest:0000}";
                                Pointer = dest;
                            }
                            else
                            {
                                Pointer += 3;
                            }

                            break;
                        }
                        case 06:
                        {
                            var arg1 = Arg(1);
                            var dest = Arg(2);

                            if (arg1 == 0)
                            {
                                action = $"! {dest:0000}";
                                Pointer = dest;
                            }
                            else
                            {
                                Pointer += 3;
                            }

                            break;
                        }
                        case 07:
                        {
                            var arg1 = Arg(1);
                            var arg2 = Arg(2);
                            var dest = Val(3);

                            if (arg1 < arg2)
                            {
                                action = $"{dest:0000} <- 1";
                                Memory[dest] = 1;
                            }
                            else
                            {
                                action = $"{dest:0000} <- 0";
                                Memory[dest] = 0;
                            }

                            Pointer += 4;
                            break;
                        }
                        case 08:
                        {
                            var arg1 = Arg(1);
                            var arg2 = Arg(2);
                            var dest = Val(3);

                            if (arg1 == arg2)
                            {
                                action = $"{dest:0000} <- 1";
                                Memory[dest] = 1;
                            }
                            else
                            {
                                action = $"{dest:0000} <- 0";
                                Memory[dest] = 0;
                            }

                            Pointer += 4;
                            break;
                        }
                        case 99:
                        {
                            Pointer = Memory.Length;
                            action = "break";
                            Halted = true;
                            break;
                        }
                    }

                    Diagnostics.Add($"{start:0000}:{op:00}:{string.Join("", modes.Take(3))} {action}");
                }
            }
        }
    }
}

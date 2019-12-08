using System;
using System.Collections.Generic;
using System.Linq;

namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new[] {1, 0, 0, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 13, 1, 19, 1, 19, 10, 23, 1, 23, 6, 27, 1, 6, 27, 31, 1, 13, 31, 35, 1, 13, 35, 39, 1, 39, 13, 43, 2, 43, 9, 47, 2, 6, 47, 51, 1, 51, 9, 55, 1, 55, 9, 59, 1, 59, 6, 63, 1, 9, 63, 67, 2, 67, 10, 71, 2, 71, 13, 75, 1, 10, 75, 79, 2, 10, 79, 83, 1, 83, 6, 87, 2, 87, 10, 91, 1, 91, 6, 95, 1, 95, 13, 99, 1, 99, 13, 103, 2, 103, 9, 107, 2, 107, 10, 111, 1, 5, 111, 115, 2, 115, 9, 119, 1, 5, 119, 123, 1, 123, 9, 127, 1, 127, 2, 131, 1, 5, 131, 0, 99, 2, 0, 14, 0};

            Console.WriteLine(Run(input, 12, 2));

            for (int noun = 0; noun <= 99; noun++)
            {
                for (int verb = 0; verb <= 99; verb++)
                {
                    if (Run(input, noun, verb) == 19690720)
                    {
                        Console.WriteLine(100 * noun + verb);
                    }
                }
            }
        }

        private static int Run(int[] input, int noun, int verb)
        {
            var ops = new Dictionary<int, Func<int, int[], (int, int[])>>
            {
                {1, (index, opcodes) => (index + 4, opcodes.Take(opcodes[index + 3]).Concat(new [] {opcodes[opcodes[index + 1]] + opcodes[opcodes[index + 2]]}).Concat(opcodes.Skip(opcodes[index + 3] + 1)).ToArray())},
                {2, (index, opcodes) => (index + 4, opcodes.Take(opcodes[index + 3]).Concat(new [] {opcodes[opcodes[index + 1]] * opcodes[opcodes[index + 2]]}).Concat(opcodes.Skip(opcodes[index + 3] + 1)).ToArray())},
                {99, (index, opcodes) => (opcodes.Length, opcodes)}
            };

            input[1] = noun;
            input[2] = verb;
            for (var i = 0; i < input.Length;)
                (i, input) = ops[input[i]](i, input);

            return input[0];
        }
    }
}

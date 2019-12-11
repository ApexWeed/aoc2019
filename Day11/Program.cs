using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day11
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new[] {3, 8, 1005, 8, 298, 1106, 0, 11, 0, 0, 0, 104, 1, 104, 0, 3, 8, 1002, 8, -1, 10, 1001, 10, 1, 10, 4, 10, 108, 1, 8, 10, 4, 10, 101, 0, 8, 28, 3, 8, 102, -1, 8, 10, 1001, 10, 1, 10, 4, 10, 1008, 8, 1, 10, 4, 10, 1002, 8, 1, 51, 1006, 0, 37, 1006, 0, 65, 1, 4, 9, 10, 3, 8, 1002, 8, -1, 10, 101, 1, 10, 10, 4, 10, 1008, 8, 0, 10, 4, 10, 102, 1, 8, 83, 2, 3, 9, 10, 1006, 0, 39, 1, 1, 0, 10, 1, 104, 11, 10, 3, 8, 102, -1, 8, 10, 1001, 10, 1, 10, 4, 10, 1008, 8, 0, 10, 4, 10, 1002, 8, 1, 120, 2, 104, 13, 10, 1, 1007, 18, 10, 1006, 0, 19, 1, 107, 2, 10, 3, 8, 102, -1, 8, 10, 101, 1, 10, 10, 4, 10, 1008, 8, 0, 10, 4, 10, 1001, 8, 0, 157, 3, 8, 1002, 8, -1, 10, 1001, 10, 1, 10, 4, 10, 1008, 8, 0, 10, 4, 10, 1001, 8, 0, 179, 2, 108, 16, 10, 2, 1108, 14, 10, 1006, 0, 70, 3, 8, 102, -1, 8, 10, 1001, 10, 1, 10, 4, 10, 108, 1, 8, 10, 4, 10, 101, 0, 8, 211, 3, 8, 1002, 8, -1, 10, 1001, 10, 1, 10, 4, 10, 1008, 8, 1, 10, 4, 10, 101, 0, 8, 234, 3, 8, 102, -1, 8, 10, 1001, 10, 1, 10, 4, 10, 1008, 8, 0, 10, 4, 10, 102, 1, 8, 256, 3, 8, 1002, 8, -1, 10, 101, 1, 10, 10, 4, 10, 1008, 8, 1, 10, 4, 10, 1002, 8, 1, 278, 101, 1, 9, 9, 1007, 9, 957, 10, 1005, 10, 15, 99, 109, 620, 104, 0, 104, 1, 21101, 387508441896, 0, 1, 21101, 0, 315, 0, 1105, 1, 419, 21101, 666412880532, 0, 1, 21102, 1, 326, 0, 1106, 0, 419, 3, 10, 104, 0, 104, 1, 3, 10, 104, 0, 104, 0, 3, 10, 104, 0, 104, 1, 3, 10, 104, 0, 104, 1, 3, 10, 104, 0, 104, 0, 3, 10, 104, 0, 104, 1, 21101, 106341436456, 0, 1, 21101, 373, 0, 0, 1106, 0, 419, 21101, 46211886299, 0, 1, 21101, 384, 0, 0, 1106, 0, 419, 3, 10, 104, 0, 104, 0, 3, 10, 104, 0, 104, 0, 21101, 0, 838433923860, 1, 21102, 1, 407, 0, 1105, 1, 419, 21102, 1, 988224946540, 1, 21102, 1, 418, 0, 1106, 0, 419, 99, 109, 2, 21201, -1, 0, 1, 21101, 40, 0, 2, 21102, 1, 450, 3, 21101, 440, 0, 0, 1105, 1, 483, 109, -2, 2106, 0, 0, 0, 1, 0, 0, 1, 109, 2, 3, 10, 204, -1, 1001, 445, 446, 461, 4, 0, 1001, 445, 1, 445, 108, 4, 445, 10, 1006, 10, 477, 1101, 0, 0, 445, 109, -2, 2105, 1, 0, 0, 109, 4, 1201, -1, 0, 482, 1207, -3, 0, 10, 1006, 10, 500, 21101, 0, 0, -3, 21201, -3, 0, 1, 21202, -2, 1, 2, 21101, 1, 0, 3, 21102, 1, 519, 0, 1105, 1, 524, 109, -4, 2106, 0, 0, 109, 5, 1207, -3, 1, 10, 1006, 10, 547, 2207, -4, -2, 10, 1006, 10, 547, 22102, 1, -4, -4, 1106, 0, 615, 21202, -4, 1, 1, 21201, -3, -1, 2, 21202, -2, 2, 3, 21102, 1, 566, 0, 1105, 1, 524, 21201, 1, 0, -4, 21101, 0, 1, -1, 2207, -4, -2, 10, 1006, 10, 585, 21101, 0, 0, -1, 22202, -2, -1, -2, 2107, 0, -3, 10, 1006, 10, 607, 22101, 0, -1, 1, 21102, 1, 607, 0, 105, 1, 482, 21202, -2, -1, -2, 22201, -4, -2, -4, 109, -5, 2105, 1, 0};

            var visited = Paint(input, 0);

            Console.WriteLine(visited.Keys.Count);

            visited = Paint(input, 1);

            Console.WriteLine($"{visited.Select(p => p.Key.X).Min()}-{visited.Select(p => p.Key.X).Max()}x{visited.Select(p => p.Key.Y).Min()}-{visited.Select(p => p.Key.Y).Max()}");

            var width = visited.Select(p => p.Key.X).Max() + 1;
            var height = visited.Select(p => p.Key.Y).Max() + 1;
            var image = new long[height, width];

            Console.WriteLine();

            foreach (var ((x, y), value) in visited)
                image[y, x] = value;

            for (var y = 0; y < height; y++)
            {
                var line = new StringBuilder();
                for (var x = 0; x < width; x++)
                    line.Append(image[y, x] == 0 ? '.' : '#');
                Console.WriteLine(line);
            }
        }

        private static Dictionary<(long X, long Y), long> Paint(long[] input, long startingColour)
        {
            var visited = new Dictionary<(long X, long Y), long> {{(0, 0), startingColour}};

            var bot = new Interpreter(input, new List<long>(), true);
            var x = 0L;
            var y = 0L;
            var direction = 0L;
            var colour = 0L;

            while (!bot.Halted)
            {
                bot.Input.Add(visited.ContainsKey((x, y)) ? visited[(x, y)] : 0);
                bot.Resume();

                if (bot.Halted)
                    continue;

                colour = bot.Output[0];
                var rotation = bot.Output[1];
                direction += rotation * 2 - 1;
                if (direction < 0)
                    direction += 4;

                visited[(x, y)] = colour;

                switch (direction % 4)
                {
                    case 0:
                        y--;
                        break;
                    case 1:
                        x++;
                        break;
                    case 2:
                        y++;
                        break;
                    case 3:
                        x--;
                        break;
                }

                bot.Output.Clear();
            }

            return visited;
        }

        private class Memory
        {
            public long[] Executable { get; }

            private Dictionary<long, long> _extended;

            public Memory(long[] seed)
            {
                Executable = seed;
                _extended = new Dictionary<long, long>();
            }

            public long this[long i]
            {
                get
                {
                    if (i < Executable.LongLength)
                        return Executable[i];

                    if (_extended.ContainsKey(i))
                        return _extended[i];

                    return 0;
                }

                set
                {
                    if (i < Executable.LongLength)
                        Executable[i] = value;

                    _extended[i] = value;
                }
            }
        }

        private class Interpreter
        {
            private Memory _memory;

            public long Pointer { get; private set; }

            public long[] Memory
            {
                get { return _memory.Executable; }
                set { _memory = new Memory(value); }
            }
            public List<long> Input { get; set; }
            public List<long> Output { get; set; }
            public List<string> Diagnostics { get; set; }
            public bool Halted { get; set; }
            public bool HaltOnIO { get; set; }
            public long BaseAddress { get; set; }


            public Interpreter(long[] memory) : this(memory, new List<long>(), false)
            { }

            public Interpreter(long[] memory, List<long> input, bool haltOnIO)
            {
                Memory = memory;
                Input = input;
                HaltOnIO = haltOnIO;
                Output = new List<long>();
            }

            public long Run()
            {
                Pointer = 0;
                Output = new List<long>();
                BaseAddress = 0;
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

                    long Arg(long offset)
                    {
                        switch (modes[offset - 1])
                        {
                            case 1:
                                return _memory[Pointer + offset];
                            case 2:
                                return _memory[BaseAddress + _memory[Pointer + offset]];
                            default:
                                return _memory[_memory[Pointer + offset]];
                        }
                    }

                    long Val(long offset) => modes[offset - 1] == 2 ? _memory[Pointer + offset] + BaseAddress : _memory[Pointer + offset];

                    var start = Pointer;
                    var action = string.Empty;

                    switch (op)
                    {
                        case 01:
                        {
                            var arg1 = Arg(1);
                            var arg2 = Arg(2);
                            var dest = Val(3);

                            _memory[dest] = arg1 + arg2;
                            action = $"{dest:0000} <- {arg1 + arg2}";
                            Pointer += 4;
                            break;
                        }
                        case 02:
                        {
                            var arg1 = Arg(1);
                            var arg2 = Arg(2);
                            var dest = Val(3);

                            _memory[dest] = arg1 * arg2;
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

                            _memory[dest] = input;
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
                                _memory[dest] = 1;
                            }
                            else
                            {
                                action = $"{dest:0000} <- 0";
                                _memory[dest] = 0;
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
                                _memory[dest] = 1;
                            }
                            else
                            {
                                action = $"{dest:0000} <- 0";
                                _memory[dest] = 0;
                            }

                            Pointer += 4;
                            break;
                        }
                        case 09:
                        {
                            var arg1 = Arg(1);

                            BaseAddress += arg1;
                            action = $"B <- {arg1}";

                            Pointer += 2;
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

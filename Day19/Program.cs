using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new long[] {109,424,203,1,21101,0,11,0,1105,1,282,21101,18,0,0,1105,1,259,2101,0,1,221,203,1,21101,31,0,0,1105,1,282,21102,38,1,0,1106,0,259,20101,0,23,2,21201,1,0,3,21101,1,0,1,21101,0,57,0,1105,1,303,2101,0,1,222,21001,221,0,3,21001,221,0,2,21101,259,0,1,21101,0,80,0,1106,0,225,21102,117,1,2,21102,91,1,0,1105,1,303,2101,0,1,223,20102,1,222,4,21102,1,259,3,21101,0,225,2,21102,1,225,1,21101,0,118,0,1105,1,225,21001,222,0,3,21102,1,77,2,21102,133,1,0,1105,1,303,21202,1,-1,1,22001,223,1,1,21102,1,148,0,1105,1,259,2102,1,1,223,21002,221,1,4,20101,0,222,3,21102,20,1,2,1001,132,-2,224,1002,224,2,224,1001,224,3,224,1002,132,-1,132,1,224,132,224,21001,224,1,1,21102,195,1,0,106,0,109,20207,1,223,2,20102,1,23,1,21101,0,-1,3,21101,0,214,0,1106,0,303,22101,1,1,1,204,1,99,0,0,0,0,109,5,1202,-4,1,249,21201,-3,0,1,21201,-2,0,2,22101,0,-1,3,21102,250,1,0,1106,0,225,22101,0,1,-4,109,-5,2105,1,0,109,3,22107,0,-2,-1,21202,-1,2,-1,21201,-1,-1,-1,22202,-1,-2,-2,109,-3,2106,0,0,109,3,21207,-2,0,-1,1206,-1,294,104,0,99,21202,-2,1,-2,109,-3,2105,1,0,109,5,22207,-3,-4,-1,1206,-1,346,22201,-4,-3,-4,21202,-3,-1,-1,22201,-4,-1,2,21202,2,-1,-1,22201,-4,-1,1,21202,-2,1,3,21102,1,343,0,1105,1,303,1106,0,415,22207,-2,-3,-1,1206,-1,387,22201,-3,-2,-3,21202,-2,-1,-1,22201,-3,-1,3,21202,3,-1,-1,22201,-3,-1,2,21202,-4,1,1,21102,384,1,0,1106,0,303,1105,1,415,21202,-4,-1,-4,22201,-4,-3,-4,22202,-3,-2,-2,22202,-2,-4,-4,22202,-3,-2,-3,21202,-4,-1,-2,22201,-3,-2,1,22101,0,1,-4,109,-5,2105,1,0};

            var map = new ConcurrentDictionary<(int X, int Y), char>();
            ExpandMap(input, map, 50);

            Render(map);

            Console.WriteLine(map.Count(p => p.Value == '#' && p.Key.X < 50 && p.Key.Y < 50));

            while (true)
            {
                var points = map.Keys.Where(p => map[p] == '#' && map.ContainsKey((p.X, p.Y + 99)) && map.ContainsKey((p.X + 99, p.Y)) && map[(p.X, p.Y + 99)] == '#' && map[(p.X + 99, p.Y)] == '#').OrderBy(p => p.X + p.Y).ToArray();
                if (points.Any())
                {
                    Console.WriteLine($"{points.First().X},{points.First().Y}: {points.First().X * 10000 + points.First().Y}");
                    break;
                }

                ExpandMap(input, map, 50);
            }
        }

        private static void ExpandMap(long[] input, ConcurrentDictionary<(int X, int Y), char> map, int size)
        {
            var width = map.Any() ? map.Keys.Max(p => p.X) : 0;
            var height = map.Any() ? map.Keys.Max(p => p.Y) : 0;
            foreach (var y in Enumerable.Range(height, height + 50))
            {
                Parallel.ForEach(Enumerable.Range(width, width + 50), x =>
                {
                    //if ((x > 10 || y > 10) && map.Where(p => (p.Key.X == x || p.Key.X == x - 1) && (p.Key.Y == y || p.Key.Y == y - 1)).All(p => p.Value != '#'))
                    if ((x > 10 || y > 10) && (!map.ContainsKey((x, y - 1)) || map[(x, y - 1)] != '#') && (!map.ContainsKey((x - 1, y - 1)) || map[(x - 1, y - 1)] != '#'))
                        return;

                    var drone = new Interpreter(input, new List<long> {x, y}, true);
                    drone.Run();
                    map[(x, y)] = drone.Output.First() == 1 ? '#' : '.';
                    drone.Output.Clear();
                });
            }
        }

        private static void Render(ConcurrentDictionary<(int X, int Y), char> map)
        {
            foreach (var y in Enumerable.Range(0, map.Keys.Max(p => p.Y)))
            {
                var line = new StringBuilder();
                foreach (var x in Enumerable.Range(0, map.Keys.Max(p => p.X)))
                {
                    line.Append(map.ContainsKey((x, y)) ? map[(x, y)] : ' ');
                }
                Console.WriteLine(line.ToString());
            }
        }

        #region Intcode

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

            public Interpreter(IEnumerable<long> memory, List<long> input, bool haltOnIO)
            {
                Memory = memory.ToArray();
                Input = input;
                HaltOnIO = haltOnIO;
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
                            action = $"B += {arg1} ({BaseAddress})";

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

        #endregion
    }
}

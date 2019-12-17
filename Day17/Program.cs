using System;
using System.Collections.Generic;
using System.Linq;

namespace Day17
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new long[] {1, 330, 331, 332, 109, 2650, 1102, 1, 1182, 15, 1102, 1429, 1, 24, 1001, 0, 0, 570, 1006, 570, 36, 102, 1, 571, 0, 1001, 570, -1, 570, 1001, 24, 1, 24, 1105, 1, 18, 1008, 571, 0, 571, 1001, 15, 1, 15, 1008, 15, 1429, 570, 1006, 570, 14, 21102, 58, 1, 0, 1105, 1, 786, 1006, 332, 62, 99, 21101, 333, 0, 1, 21102, 1, 73, 0, 1105, 1, 579, 1102, 0, 1, 572, 1102, 1, 0, 573, 3, 574, 101, 1, 573, 573, 1007, 574, 65, 570, 1005, 570, 151, 107, 67, 574, 570, 1005, 570, 151, 1001, 574, -64, 574, 1002, 574, -1, 574, 1001, 572, 1, 572, 1007, 572, 11, 570, 1006, 570, 165, 101, 1182, 572, 127, 1002, 574, 1, 0, 3, 574, 101, 1, 573, 573, 1008, 574, 10, 570, 1005, 570, 189, 1008, 574, 44, 570, 1006, 570, 158, 1106, 0, 81, 21101, 0, 340, 1, 1105, 1, 177, 21101, 477, 0, 1, 1105, 1, 177, 21102, 1, 514, 1, 21101, 0, 176, 0, 1105, 1, 579, 99, 21101, 184, 0, 0, 1105, 1, 579, 4, 574, 104, 10, 99, 1007, 573, 22, 570, 1006, 570, 165, 1002, 572, 1, 1182, 21102, 1, 375, 1, 21102, 1, 211, 0, 1105, 1, 579, 21101, 1182, 11, 1, 21101, 0, 222, 0, 1106, 0, 979, 21101, 388, 0, 1, 21102, 233, 1, 0, 1106, 0, 579, 21101, 1182, 22, 1, 21102, 244, 1, 0, 1105, 1, 979, 21102, 1, 401, 1, 21101, 255, 0, 0, 1105, 1, 579, 21101, 1182, 33, 1, 21102, 266, 1, 0, 1105, 1, 979, 21102, 414, 1, 1, 21102, 277, 1, 0, 1105, 1, 579, 3, 575, 1008, 575, 89, 570, 1008, 575, 121, 575, 1, 575, 570, 575, 3, 574, 1008, 574, 10, 570, 1006, 570, 291, 104, 10, 21101, 1182, 0, 1, 21101, 0, 313, 0, 1106, 0, 622, 1005, 575, 327, 1102, 1, 1, 575, 21102, 1, 327, 0, 1106, 0, 786, 4, 438, 99, 0, 1, 1, 6, 77, 97, 105, 110, 58, 10, 33, 10, 69, 120, 112, 101, 99, 116, 101, 100, 32, 102, 117, 110, 99, 116, 105, 111, 110, 32, 110, 97, 109, 101, 32, 98, 117, 116, 32, 103, 111, 116, 58, 32, 0, 12, 70, 117, 110, 99, 116, 105, 111, 110, 32, 65, 58, 10, 12, 70, 117, 110, 99, 116, 105, 111, 110, 32, 66, 58, 10, 12, 70, 117, 110, 99, 116, 105, 111, 110, 32, 67, 58, 10, 23, 67, 111, 110, 116, 105, 110, 117, 111, 117, 115, 32, 118, 105, 100, 101, 111, 32, 102, 101, 101, 100, 63, 10, 0, 37, 10, 69, 120, 112, 101, 99, 116, 101, 100, 32, 82, 44, 32, 76, 44, 32, 111, 114, 32, 100, 105, 115, 116, 97, 110, 99, 101, 32, 98, 117, 116, 32, 103, 111, 116, 58, 32, 36, 10, 69, 120, 112, 101, 99, 116, 101, 100, 32, 99, 111, 109, 109, 97, 32, 111, 114, 32, 110, 101, 119, 108, 105, 110, 101, 32, 98, 117, 116, 32, 103, 111, 116, 58, 32, 43, 10, 68, 101, 102, 105, 110, 105, 116, 105, 111, 110, 115, 32, 109, 97, 121, 32, 98, 101, 32, 97, 116, 32, 109, 111, 115, 116, 32, 50, 48, 32, 99, 104, 97, 114, 97, 99, 116, 101, 114, 115, 33, 10, 94, 62, 118, 60, 0, 1, 0, -1, -1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 36, 16, 0, 109, 4, 2102, 1, -3, 587, 20102, 1, 0, -1, 22101, 1, -3, -3, 21102, 0, 1, -2, 2208, -2, -1, 570, 1005, 570, 617, 2201, -3, -2, 609, 4, 0, 21201, -2, 1, -2, 1105, 1, 597, 109, -4, 2105, 1, 0, 109, 5, 2102, 1, -4, 630, 20101, 0, 0, -2, 22101, 1, -4, -4, 21102, 1, 0, -3, 2208, -3, -2, 570, 1005, 570, 781, 2201, -4, -3, 653, 20102, 1, 0, -1, 1208, -1, -4, 570, 1005, 570, 709, 1208, -1, -5, 570, 1005, 570, 734, 1207, -1, 0, 570, 1005, 570, 759, 1206, -1, 774, 1001, 578, 562, 684, 1, 0, 576, 576, 1001, 578, 566, 692, 1, 0, 577, 577, 21101, 0, 702, 0, 1106, 0, 786, 21201, -1, -1, -1, 1106, 0, 676, 1001, 578, 1, 578, 1008, 578, 4, 570, 1006, 570, 724, 1001, 578, -4, 578, 21101, 731, 0, 0, 1105, 1, 786, 1106, 0, 774, 1001, 578, -1, 578, 1008, 578, -1, 570, 1006, 570, 749, 1001, 578, 4, 578, 21101, 756, 0, 0, 1106, 0, 786, 1106, 0, 774, 21202, -1, -11, 1, 22101, 1182, 1, 1, 21102, 1, 774, 0, 1105, 1, 622, 21201, -3, 1, -3, 1105, 1, 640, 109, -5, 2106, 0, 0, 109, 7, 1005, 575, 802, 20101, 0, 576, -6, 20101, 0, 577, -5, 1106, 0, 814, 21102, 0, 1, -1, 21101, 0, 0, -5, 21101, 0, 0, -6, 20208, -6, 576, -2, 208, -5, 577, 570, 22002, 570, -2, -2, 21202, -5, 37, -3, 22201, -6, -3, -3, 22101, 1429, -3, -3, 1202, -3, 1, 843, 1005, 0, 863, 21202, -2, 42, -4, 22101, 46, -4, -4, 1206, -2, 924, 21101, 0, 1, -1, 1106, 0, 924, 1205, -2, 873, 21101, 35, 0, -4, 1105, 1, 924, 2102, 1, -3, 878, 1008, 0, 1, 570, 1006, 570, 916, 1001, 374, 1, 374, 2102, 1, -3, 895, 1102, 1, 2, 0, 2102, 1, -3, 902, 1001, 438, 0, 438, 2202, -6, -5, 570, 1, 570, 374, 570, 1, 570, 438, 438, 1001, 578, 558, 921, 21001, 0, 0, -4, 1006, 575, 959, 204, -4, 22101, 1, -6, -6, 1208, -6, 37, 570, 1006, 570, 814, 104, 10, 22101, 1, -5, -5, 1208, -5, 33, 570, 1006, 570, 810, 104, 10, 1206, -1, 974, 99, 1206, -1, 974, 1101, 0, 1, 575, 21102, 973, 1, 0, 1106, 0, 786, 99, 109, -7, 2106, 0, 0, 109, 6, 21101, 0, 0, -4, 21102, 0, 1, -3, 203, -2, 22101, 1, -3, -3, 21208, -2, 82, -1, 1205, -1, 1030, 21208, -2, 76, -1, 1205, -1, 1037, 21207, -2, 48, -1, 1205, -1, 1124, 22107, 57, -2, -1, 1205, -1, 1124, 21201, -2, -48, -2, 1105, 1, 1041, 21101, 0, -4, -2, 1105, 1, 1041, 21102, -5, 1, -2, 21201, -4, 1, -4, 21207, -4, 11, -1, 1206, -1, 1138, 2201, -5, -4, 1059, 1201, -2, 0, 0, 203, -2, 22101, 1, -3, -3, 21207, -2, 48, -1, 1205, -1, 1107, 22107, 57, -2, -1, 1205, -1, 1107, 21201, -2, -48, -2, 2201, -5, -4, 1090, 20102, 10, 0, -1, 22201, -2, -1, -2, 2201, -5, -4, 1103, 2101, 0, -2, 0, 1105, 1, 1060, 21208, -2, 10, -1, 1205, -1, 1162, 21208, -2, 44, -1, 1206, -1, 1131, 1106, 0, 989, 21101, 0, 439, 1, 1105, 1, 1150, 21101, 0, 477, 1, 1105, 1, 1150, 21101, 0, 514, 1, 21102, 1, 1149, 0, 1106, 0, 579, 99, 21101, 1157, 0, 0, 1106, 0, 579, 204, -2, 104, 10, 99, 21207, -3, 22, -1, 1206, -1, 1138, 1202, -5, 1, 1176, 2102, 1, -4, 0, 109, -6, 2105, 1, 0, 8, 7, 30, 1, 5, 1, 30, 1, 5, 1, 30, 1, 5, 1, 22, 9, 1, 9, 18, 1, 9, 1, 3, 1, 3, 1, 18, 1, 3, 11, 3, 1, 18, 1, 3, 1, 5, 1, 7, 1, 18, 1, 3, 1, 5, 1, 7, 1, 1, 5, 1, 7, 4, 1, 3, 1, 5, 1, 7, 1, 1, 1, 3, 1, 1, 1, 5, 1, 4, 11, 7, 1, 1, 1, 3, 1, 1, 1, 5, 1, 8, 1, 13, 1, 1, 1, 3, 1, 1, 1, 5, 1, 8, 1, 13, 1, 1, 11, 1, 1, 8, 1, 13, 1, 5, 1, 1, 1, 5, 1, 8, 7, 7, 7, 1, 1, 5, 1, 14, 1, 15, 1, 5, 1, 14, 1, 15, 1, 5, 5, 10, 1, 15, 1, 20, 1, 1, 7, 7, 7, 14, 1, 1, 1, 5, 1, 13, 1, 10, 11, 1, 1, 13, 1, 10, 1, 3, 1, 1, 1, 3, 1, 1, 1, 13, 1, 10, 1, 3, 1, 1, 1, 3, 1, 1, 1, 7, 11, 6, 1, 3, 1, 1, 1, 3, 1, 1, 1, 7, 1, 5, 1, 3, 1, 6, 5, 1, 5, 1, 1, 7, 1, 5, 1, 3, 1, 18, 1, 7, 1, 5, 1, 3, 1, 18, 1, 3, 11, 3, 1, 18, 1, 3, 1, 3, 1, 9, 1, 18, 9, 1, 9, 22, 1, 5, 1, 30, 1, 5, 1, 30, 1, 5, 1, 30, 7, 8};

            var robot = new Interpreter(input.ToArray(), new List<long>(), true);
            robot.Run();

            var output = new string(System.Text.Encoding.ASCII.GetChars(robot.Output.Select(o => (byte)o).ToArray()));
            var lines = output.Split('\n').Select(s => s.ToArray()).ToArray();
            var points = new Dictionary<(int X, int Y), char>();

            for (var y = 0; y < lines.Length; y++)
            {
                for (var x = 0; x < lines[y].Length; x++)
                {
                    if (lines[y][x] == '#')
                        points.Add((x, y), '#');
                }
            }

            // Intersections are flanked on 4 sides by paths
            var intersections = points.Keys.Where(p => points.ContainsKey((p.X + 1, p.Y)) && points.ContainsKey((p.X - 1, p.Y)) && points.ContainsKey((p.X, p.Y + 1)) && points.ContainsKey((p.X, p.Y - 1)))
                                      .ToArray();
            // Corners have a path above or below and either left or right.
            var corners = points.Keys.Where(p => points.ContainsKey((p.X + 1, p.Y)) && !points.ContainsKey((p.X - 1, p.Y)) && (points.ContainsKey((p.X, p.Y + 1)) || points.ContainsKey((p.X, p.Y - 1))) ||
                                                points.ContainsKey((p.X - 1, p.Y)) && !points.ContainsKey((p.X + 1, p.Y)) && (points.ContainsKey((p.X, p.Y + 1)) || points.ContainsKey((p.X, p.Y - 1))))
                               .ToArray();

            foreach (var point in corners)
                lines[point.Y][point.X] = 'C';

            foreach (var point in intersections)
            {
                lines[point.Y][point.X] = '+';
                points[point] = '+';
            }

            foreach (var line in lines)
                Console.WriteLine(line);

            Console.WriteLine(intersections.Select(i => i.X * i.Y).Sum());

            var directions = "^>v<";
            var startChar = directions.First(c => output.Any(p => p == c));

            // The start has a unique character
            var start = (X: output.IndexOf(startChar) % (lines.First().Length + 1), Y: output.IndexOf(startChar) / (lines.First().Length + 1));
            // The end (and the tile next to the start) are the only tiles with only one adjacent tile, use the one furthest from the start
            var end = points.Keys.First(p => (points.ContainsKey((p.X + 1, p.Y)) ? 1 : 0) + (points.ContainsKey((p.X - 1, p.Y)) ? 1 : 0) + (points.ContainsKey((p.X, p.Y + 1)) ? 1 : 0) + (points.ContainsKey((p.X, p.Y - 1)) ? 1 : 0) == 1 &&
                                              Math.Abs(start.X - p.X) + Math.Abs(start.Y - p.Y) > 1);

            // Filter found path to just the corners
            var path = Astar(points, start, end, true);
            var orderedCorners = path.Nodes.Where(n => corners.Contains(n.Position)).Select(n => n.Position).Append(end);

            // Generate raw command
            var current = start;
            var direction = directions.IndexOf(startChar);
            var commandItems = new List<string>();
            foreach (var next in orderedCorners)
            {
                var distance = Math.Abs(current.X - next.X) + Math.Abs(current.Y - next.Y);
                var nextDirection = 0;
                if (current.Y > next.Y)
                    nextDirection = 0;
                else if (current.X > next.X)
                    nextDirection = 3;
                else if (current.Y < next.Y)
                    nextDirection = 2;
                else if (current.X < next.X)
                    nextDirection = 1;

                switch (direction, nextDirection)
                {
                    case (0, 3):
                    case (1, 0):
                    case (2, 1):
                    case (3, 2):
                        commandItems.Add($"L,{distance}");
                        break;
                    default:
                        commandItems.Add($"R,{distance}");
                        break;
                }

                direction = nextDirection;
                current = next;
            }

            var command = string.Join(",", commandItems);
            var commands = string.Empty;

            // Generate list of partial commands
            var patterns = new List<(string Pattern, int Occurences)>();
            for (var itemLength = 1; itemLength < commandItems.Count; itemLength++)
            {
                for (var startItem = 0; startItem + itemLength < commandItems.Count; startItem++)
                {
                    var pattern = string.Join(",", commandItems.Skip(startItem).Take(itemLength));
                    if (pattern.Length > 20)
                        continue;
                    patterns.Add((pattern, command.Count(pattern)));
                }
            }

            var candidates = patterns.Where(p => p.Occurences > 1).Distinct().OrderByDescending(p => p.Pattern.Length).Select(p => p.Pattern);

            // Try combinations of 3 patterns until they replace the entire command
            foreach (var permutation in CombinationsRosettaWoRecursion(candidates.ToArray(), 3))
            {
                var result = command.Replace(permutation[0], "").Replace(permutation[1], "").Replace(permutation[2], "").Replace(",", "");
                if (result.Length == 0)
                {
                    var baseCommand = command.Replace(permutation[0], "A").Replace(permutation[1], "B").Replace(permutation[2], "C");
                    commands = $"{baseCommand}\n{permutation[0]}\n{permutation[1]}\n{permutation[2]}\nn\n";
                    break;
                }
            }

            robot = new Interpreter(input.ToArray(), new List<long>(commands.ToArray().Select(c => (long)c)), true);
            robot.Memory[0] = 2;
            robot.Run();
            output = new string(System.Text.Encoding.ASCII.GetChars(robot.Output.Select(o => (byte)o).ToArray()));
            Console.WriteLine(output);
            Console.WriteLine(robot.Output.Last());
        }

        // Enumerate all possible m-size combinations of [0, 1, ..., n-1] array
        // in lexicographic order (first [0, 1, 2, ..., m-1]).
        private static IEnumerable<int[]> CombinationsRosettaWoRecursion(int m, int n)
        {
            int[] result = new int[m];
            Stack<int> stack = new Stack<int>(m);
            stack.Push(0);
            while (stack.Count > 0)
            {
                int index = stack.Count - 1;
                int value = stack.Pop();
                while (value < n)
                {
                    result[index++] = value++;
                    stack.Push(value);
                    if (index != m) continue;
                    yield return (int[])result.Clone(); // thanks to @xanatos
                    //yield return result;
                    break;
                }
            }
        }

        public static IEnumerable<T[]> CombinationsRosettaWoRecursion<T>(T[] array, int m)
        {
            if (array.Length < m)
                throw new ArgumentException("Array length can't be less than number of selected elements");
            if (m < 1)
                throw new ArgumentException("Number of selected elements can't be less than 1");
            T[] result = new T[m];
            foreach (int[] j in CombinationsRosettaWoRecursion(m, array.Length))
            {
                for (int i = 0; i < m; i++)
                {
                    result[i] = array[j[i]];
                }
                yield return result;
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

            public Interpreter(long[] memory, List<long> input, bool haltOnIO)
            {
                Memory = memory;
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

        #endregion

        #region Astar

        private class Path
        {
            public readonly List<Node> Nodes;
            public Node Current { get; private set; }
            public Node End { get; private set; }

            public Path(Node node)
            {
                Nodes = new List<Node>();
                End = node;
                while (node.Parent != null)
                {
                    Nodes.Add(node);
                    node = node.Parent;
                }

                Nodes.Reverse();
                Current = Nodes.First();
            }

            public Node Next()
            {
                Current = Current.Parent?.Position == (0, 0) ? null : Current.Parent;

                return Current;
            }
        }

        private class Node
        {
            protected bool Equals(Node other)
            {
                return Position.Equals(other.Position);
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != GetType()) return false;
                return Equals((Node)obj);
            }

            public override int GetHashCode()
            {
                return Position.GetHashCode();
            }

            public override string ToString()
            {
                return Position.ToString();
            }

            public static bool operator ==(Node left, Node right)
            {
                return Equals(left, right);
            }

            public static bool operator !=(Node left, Node right)
            {
                return !Equals(left, right);
            }

            public readonly (int X, int Y) Position;
            public Node Parent;
            public int G;
            public int H;

            public int F { get => G + H; }

            public Node((int X, int Y) position, Node parent = null)
            {
                Position = position;
                Parent = parent;
            }

            public (int X, int Y) Add((int X, int Y) amount)
                => (Position.X + amount.X, Position.Y + amount.Y);
        }

        private static Path Astar(Dictionary<(int X, int Y), char> points, (int X, int Y) start, (int X, int Y) goal, bool optimal = false)
        {
            var startNode = new Node(start);

            var toVisit = new List<Node> {startNode};
            var visited = new List<Node>();

            var maxIterations = optimal ? short.MaxValue : points.Count + 10;
            var iterations = 0;

            var moves = new[]
            {
                ( 0, -1),
                ( 0, +1),
                (-1,  0),
                (+1,  0)
            };

            while (toVisit.Any())
            {
                iterations++;

                var currentNode = toVisit[0];
                foreach (var node in toVisit)
                {
                    if (node.F < currentNode.F)
                        currentNode = node;
                }

                if (iterations > maxIterations)
                    return new Path(currentNode);

                toVisit.Remove(currentNode);
                if (GetPoint(points, currentNode.Position.X, currentNode.Position.Y) != '+')
                    visited.Add(currentNode);

                if (currentNode.Position == goal)
                    return new Path(currentNode);

                var children = new List<Node>();

                foreach (var position in moves)
                {
                    var newPosition = currentNode.Add(position);

                    if (GetPoint(points, newPosition.X, newPosition.Y) == '.')
                        continue;

                    if (GetPoint(points, currentNode.Position.X, currentNode.Position.Y) == '+')
                    {
                        if (currentNode.Parent == null || currentNode.Parent.Add(position) != currentNode.Position)
                            continue;
                    }

                    var newNode = new Node(newPosition, currentNode);
                    children.Add(newNode);
                }

                foreach (var child in children)
                {
                    if (visited.Any(v => v == child))
                        continue;

                    child.G = currentNode.G + 1;
                    child.H = Math.Abs(child.Position.X - goal.X) + Math.Abs(child.Position.Y - goal.Y);

                    if (toVisit.Any(n => n == child && child.G > n.G))
                        continue;

                    toVisit.Add(child);
                }
            }

            return new Path(new Node(start));
        }

        private static int GetPoint(Dictionary<(int X, int Y), char> points, int x, int y)
            => points.ContainsKey((x, y)) ? points[(x, y)] : '.';

        #endregion
    }

    public static class StringExtensions
    {
        public static int Count(this string s, string needle)
        {
            var count = 0;
            var at = 0;
            while (at != -1)
            {
                at = s.IndexOf(needle, at);
                if (at != -1)
                {
                    count++;
                    at += needle.Length;
                }
            }

            return count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day15
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new long[] {3, 1033, 1008, 1033, 1, 1032, 1005, 1032, 31, 1008, 1033, 2, 1032, 1005, 1032, 58, 1008, 1033, 3, 1032, 1005, 1032, 81, 1008, 1033, 4, 1032, 1005, 1032, 104, 99, 102, 1, 1034, 1039, 1002, 1036, 1, 1041, 1001, 1035, -1, 1040, 1008, 1038, 0, 1043, 102, -1, 1043, 1032, 1, 1037, 1032, 1042, 1105, 1, 124, 102, 1, 1034, 1039, 101, 0, 1036, 1041, 1001, 1035, 1, 1040, 1008, 1038, 0, 1043, 1, 1037, 1038, 1042, 1105, 1, 124, 1001, 1034, -1, 1039, 1008, 1036, 0, 1041, 101, 0, 1035, 1040, 1001, 1038, 0, 1043, 101, 0, 1037, 1042, 1105, 1, 124, 1001, 1034, 1, 1039, 1008, 1036, 0, 1041, 101, 0, 1035, 1040, 101, 0, 1038, 1043, 101, 0, 1037, 1042, 1006, 1039, 217, 1006, 1040, 217, 1008, 1039, 40, 1032, 1005, 1032, 217, 1008, 1040, 40, 1032, 1005, 1032, 217, 1008, 1039, 5, 1032, 1006, 1032, 165, 1008, 1040, 9, 1032, 1006, 1032, 165, 1102, 1, 2, 1044, 1105, 1, 224, 2, 1041, 1043, 1032, 1006, 1032, 179, 1102, 1, 1, 1044, 1105, 1, 224, 1, 1041, 1043, 1032, 1006, 1032, 217, 1, 1042, 1043, 1032, 1001, 1032, -1, 1032, 1002, 1032, 39, 1032, 1, 1032, 1039, 1032, 101, -1, 1032, 1032, 101, 252, 1032, 211, 1007, 0, 73, 1044, 1106, 0, 224, 1101, 0, 0, 1044, 1106, 0, 224, 1006, 1044, 247, 101, 0, 1039, 1034, 1002, 1040, 1, 1035, 1002, 1041, 1, 1036, 1002, 1043, 1, 1038, 101, 0, 1042, 1037, 4, 1044, 1105, 1, 0, 43, 57, 94, 36, 95, 30, 10, 40, 88, 72, 99, 97, 53, 21, 87, 48, 77, 40, 75, 69, 46, 98, 78, 22, 21, 38, 17, 12, 96, 34, 94, 81, 18, 49, 92, 1, 26, 67, 48, 15, 80, 51, 60, 92, 9, 77, 89, 64, 15, 85, 53, 94, 84, 99, 70, 7, 8, 69, 79, 79, 41, 62, 98, 22, 94, 92, 69, 97, 65, 96, 47, 99, 71, 4, 75, 10, 89, 85, 13, 89, 93, 93, 33, 46, 80, 61, 80, 75, 47, 99, 54, 63, 54, 57, 99, 80, 97, 77, 48, 33, 97, 95, 92, 20, 75, 3, 90, 84, 1, 50, 15, 94, 80, 95, 93, 70, 22, 3, 74, 69, 27, 99, 91, 66, 99, 1, 67, 12, 94, 31, 78, 83, 51, 97, 25, 4, 92, 85, 3, 96, 60, 5, 98, 69, 23, 95, 70, 92, 99, 1, 5, 84, 51, 87, 60, 67, 56, 98, 44, 80, 71, 81, 59, 58, 97, 82, 48, 87, 4, 76, 87, 45, 23, 75, 62, 89, 29, 37, 83, 22, 89, 81, 48, 64, 92, 30, 13, 90, 89, 83, 50, 49, 14, 89, 2, 34, 39, 84, 88, 21, 1, 81, 41, 74, 95, 89, 37, 82, 30, 87, 11, 93, 78, 67, 99, 8, 95, 84, 26, 93, 9, 95, 7, 18, 93, 94, 55, 96, 50, 92, 97, 43, 88, 53, 22, 91, 91, 35, 5, 79, 34, 66, 56, 24, 95, 49, 86, 72, 98, 52, 19, 81, 10, 90, 78, 12, 76, 8, 37, 87, 62, 80, 98, 52, 19, 40, 97, 83, 70, 18, 94, 77, 62, 87, 13, 35, 90, 35, 78, 68, 84, 89, 77, 13, 71, 19, 81, 54, 96, 88, 22, 40, 99, 24, 62, 85, 37, 95, 97, 89, 64, 30, 18, 98, 95, 9, 27, 76, 85, 49, 99, 31, 55, 71, 89, 95, 86, 94, 69, 24, 98, 32, 84, 99, 72, 82, 89, 61, 75, 30, 90, 74, 10, 71, 14, 80, 55, 68, 61, 99, 54, 84, 49, 17, 74, 83, 79, 38, 25, 90, 38, 99, 36, 89, 14, 38, 80, 71, 92, 10, 4, 65, 35, 78, 95, 40, 36, 78, 13, 39, 83, 76, 82, 64, 16, 96, 95, 31, 75, 95, 79, 2, 89, 38, 36, 87, 36, 76, 81, 38, 42, 92, 38, 7, 83, 87, 83, 87, 54, 96, 99, 78, 50, 43, 94, 96, 41, 87, 77, 8, 90, 78, 72, 79, 49, 82, 82, 56, 13, 94, 34, 90, 44, 82, 22, 60, 96, 48, 97, 2, 88, 87, 47, 92, 40, 91, 4, 58, 93, 29, 61, 83, 98, 99, 7, 8, 91, 30, 15, 88, 20, 90, 79, 10, 93, 31, 41, 95, 94, 56, 94, 95, 70, 93, 50, 94, 40, 37, 42, 84, 45, 35, 59, 27, 75, 80, 52, 90, 93, 15, 21, 92, 18, 52, 96, 83, 1, 90, 86, 12, 79, 21, 38, 98, 13, 74, 99, 40, 85, 41, 60, 94, 54, 44, 98, 83, 35, 57, 76, 66, 94, 94, 59, 82, 62, 77, 76, 22, 87, 39, 95, 98, 5, 90, 60, 88, 46, 91, 23, 58, 16, 83, 79, 7, 99, 11, 53, 76, 12, 88, 96, 88, 35, 58, 63, 81, 12, 26, 79, 89, 79, 26, 28, 23, 5, 90, 1, 76, 85, 55, 74, 44, 42, 88, 78, 36, 83, 61, 86, 92, 37, 62, 82, 80, 60, 46, 78, 32, 76, 20, 56, 77, 81, 9, 40, 45, 81, 85, 46, 7, 65, 96, 90, 19, 83, 16, 78, 66, 25, 24, 87, 80, 55, 93, 71, 84, 21, 86, 38, 79, 80, 94, 11, 42, 81, 89, 56, 18, 81, 33, 86, 72, 48, 86, 90, 59, 10, 92, 35, 77, 39, 94, 58, 97, 36, 5, 90, 96, 87, 40, 21, 22, 74, 80, 42, 32, 59, 60, 96, 25, 26, 95, 54, 90, 54, 15, 18, 98, 61, 91, 58, 84, 2, 19, 83, 36, 87, 60, 99, 63, 34, 79, 84, 92, 25, 74, 62, 6, 76, 84, 33, 80, 54, 91, 84, 3, 83, 95, 34, 22, 92, 88, 6, 88, 93, 17, 87, 59, 95, 17, 98, 65, 24, 20, 90, 95, 31, 74, 93, 30, 66, 80, 79, 72, 98, 7, 74, 34, 87, 77, 3, 24, 4, 82, 93, 42, 53, 90, 47, 82, 65, 65, 16, 75, 91, 79, 20, 93, 77, 54, 71, 81, 47, 82, 18, 78, 94, 92, 63, 75, 36, 87, 34, 87, 31, 92, 29, 98, 22, 80, 95, 91, 17, 97, 35, 79, 87, 87, 61, 93, 93, 99, 63, 95, 36, 90, 78, 77, 61, 83, 0, 0, 21, 21, 1, 10, 1, 0, 0, 0, 0, 0, 0};

            var drone = new Interpreter(input, new List<long>(), true)
            {
                Output = new List<long>()
            };
            var points = new Dictionary<(long X, long Y), int>
            {
                {(0, 0), 1}
            };

            var x = 0L;
            var y = 0L;
            var history = new Stack<(long X, long Y)>();
            while (true)
            {
                var destination = FindDestination(points, history, x, y);
                if (destination == null)
                    break;
                var path = Astar(points, (x, y), destination.Value);

                var command = 0L;
                if (path.Current.Position.Y < y)
                    command = 1L;
                if (path.Current.Position.Y > y)
                    command = 2L;
                if (path.Current.Position.X < x)
                    command = 3L;
                if (path.Current.Position.X > x)
                    command = 4L;

                if (command == 0)
                {
                    path.Next();
                    continue;
                }

                drone.Input.Add(command);
                drone.Resume();

                path.Next();

                var result = drone.Output.First();
                drone.Output.Clear();
                if (result == 0)
                {
                    switch (command)
                    {
                        case 1:
                            points[(x, y - 1)] = 2;
                            break;
                        case 2:
                            points[(x, y + 1)] = 2;
                            break;
                        case 3:
                            points[(x - 1, y)] = 2;
                            break;
                        case 4:
                            points[(x + 1, y)] = 2;
                            break;
                    }

                    continue;
                }

                switch (command)
                {
                    case 1:
                        y--;
                        break;
                    case 2:
                        y++;
                        break;
                    case 3:
                        x--;
                        break;
                    case 4:
                        x++;
                        break;
                }

                if (result == 1)
                    points[(x, y)] = 1;
                else
                    points[(x, y)] = 3;

                if (!history.Any() || (x, y) != history.Peek())
                    history.Push((x, y));
            }

            var goal = points.First(p => p.Value == 3).Key;
            var o2Path = Astar(points, (0, 0), goal, true);
            RenderPath(points, o2Path, goal);
            Console.WriteLine(o2Path.Nodes.Count);

            Console.WriteLine(FloodArea(points));

            // Also valid!
            //Console.WriteLine(points.Where(p => p.Value == 1).Select(p => Astar(points, p.Key, goal, true)).Select(p => p.Nodes.Count).Max());
        }

        private static int FloodArea(Dictionary<(long X, long Y), int> points)
        {
            var generator = points.First(p => p.Value == 3).Key;
            var seconds = 0;
            points[generator] = 4;

            var moves = new (long X, long Y)[]
            {
                ( 0, -1),
                ( 0, +1),
                (-1,  0),
                (+1,  0)
            };

            while (points.Values.Any(p => p == 1))
            {
                var oxygen = points.Where(p => p.Value == 4).Select(p => p.Key).ToArray();
                foreach (var point in oxygen)
                {
                    foreach (var move in moves)
                    {
                        var newPoint = (point.X + move.X, point.Y + move.Y);
                        if (points.ContainsKey(newPoint) && points[newPoint] == 1)
                            points[newPoint] = 4;
                    }
                }

                seconds++;
            }

            return seconds;
        }

        private static Path Astar(Dictionary<(long X, long Y), int> points, (long X, long Y) start, (long X, long Y) goal, bool optimal = false)
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
                visited.Add(currentNode);

                if (currentNode.Position == goal)
                    return new Path(currentNode);

                var children = new List<Node>();

                foreach (var position in moves)
                {
                    var newPosition = currentNode.Add(position);

                    if (GetPoint(points, newPosition.X, newPosition.Y) == 2)
                        continue;

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

        private static (long X, long Y)? FindDestination(Dictionary<(long X, long Y), int> points, Stack<(long X, long Y)> history, long x, long y)
        {
            var newPoints = FindNewPoints(points);

            var bestMatch = newPoints.OrderBy(p => Math.Abs(x - p.X) + Math.Abs(y - p.Y)).FirstOrDefault(p => !history.Any() || p != history.Peek());

            return bestMatch == default ? null : ((long X, long Y)?)bestMatch;
        }

        private static List<(long X, long Y)> FindNewPoints(Dictionary<(long X, long Y), int> points)
        {
            var valid = new List<(long X, long Y)>();
            foreach (var ((x, y), _) in points.Where(p => p.Value != 2))
            {
                if (GetPoint(points, x, y - 1) == 0)
                    valid.Add((x, y - 1));
                if (GetPoint(points, x, y + 1) == 0)
                    valid.Add((x, y + 1));
                if (GetPoint(points, x - 1, y) == 0)
                    valid.Add((x - 1, y));
                if (GetPoint(points, x + 1, y) == 0)
                    valid.Add((x + 1, y));
            }

            return valid.Distinct().ToList();
        }

        private static long GetPoint(Dictionary<(long X, long Y), int> points, long x, long y)
            => points.ContainsKey((x, y)) ? points[(x, y)] : 0;

        private static void Render(Dictionary<(long X, long Y), int> points, (long X, long Y) rover, (long X, long Y) target)
        {
            var xOffset = points.Keys.Min(p => p.X) - 1;
            var yOffset = points.Keys.Min(p => p.Y) - 1;
            var width = points.Keys.Max(p => p.X) + 1;
            var height = points.Keys.Max(p => p.Y) + 1;

            var characters = new Dictionary<long, char>
            {
                {0L, ' '},
                {1L, '.'},
                {2L, '#'},
                {3L, 'D'},
                {4L, 'O'},
                {5L, 'T'}
            };

            for (var y = yOffset; y < height; y++)
            {
                var line = new StringBuilder();
                for (var x = xOffset; x < width; x++)
                {
                    if ((x, y) == rover)
                        line.Append(characters[3]);
                    else if ((x, y) == target)
                        line.Append(characters[5]);
                    else
                        line.Append(characters[points.ContainsKey((x, y)) ? points[(x, y)] : 0]);
                }
                Console.WriteLine(line.ToString());
            }
            Console.WriteLine();
        }

        private static void RenderPath(Dictionary<(long X, long Y), int> points, Path path, (long X, long Y) target)
        {
            var xOffset = points.Keys.Min(p => p.X) - 1;
            var yOffset = points.Keys.Min(p => p.Y) - 1;
            var width = points.Keys.Max(p => p.X) + 1;
            var height = points.Keys.Max(p => p.Y) + 1;

            for (var y = yOffset; y < height; y++)
            {
                var line = new StringBuilder();
                for (var x = xOffset; x < width; x++)
                {
                    if ((x, y) == target)
                        line.Append('O');
                    else if (path.Nodes.Any(n => n.Position == (x, y)))
                        line.Append('o');
                    else if (GetPoint(points, x, y) == 2)
                        line.Append('#');
                    else
                        line.Append(' ');
                }
                Console.WriteLine(line.ToString());
            }
            Console.WriteLine();
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

        private class Path
        {
            public readonly List<Node> Nodes;
            public Node Current { get; private set; }

            public Path(Node node)
            {
                Nodes = new List<Node>();
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

            public readonly (long X, long Y) Position;
            public Node Parent;
            public int G;
            public long H;

            public long F { get => G + H; }

            public Node((long X, long Y) position, Node parent = null)
            {
                Position = position;
                Parent = parent;
            }

            public (long X, long Y) Add((long X, long Y) amount)
                => (Position.X + amount.X, Position.Y + amount.Y);
        }
    }
}

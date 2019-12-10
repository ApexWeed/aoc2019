using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new[]
            {
                "##.###.#.......#.#....#....#..........#.",
                "....#..#..#.....#.##.............#......",
                "...#.#..###..#..#.....#........#......#.",
                "#......#.....#.##.#.##.##...#...#......#",
                ".............#....#.....#.#......#.#....",
                "..##.....#..#..#.#.#....##.......#.....#",
                ".#........#...#...#.#.....#.....#.#..#.#",
                "...#...........#....#..#.#..#...##.#.#..",
                "#.##.#.#...#..#...........#..........#..",
                "........#.#..#..##.#.##......##.........",
                "................#.##.#....##.......#....",
                "#............#.........###...#...#.....#",
                "#....#..#....##.#....#...#.....#......#.",
                ".........#...#.#....#.#.....#...#...#...",
                ".............###.....#.#...##...........",
                "...#...#.......#....#.#...#....#...#....",
                ".....#..#...#.#.........##....#...#.....",
                "....##.........#......#...#...#....#..#.",
                "#...#..#..#.#...##.#..#.............#.##",
                ".....#...##..#....#.#.##..##.....#....#.",
                "..#....#..#........#.#.......#.##..###..",
                "...#....#..#.#.#........##..#..#..##....",
                ".......#.##.....#.#.....#...#...........",
                "........#.......#.#...........#..###..##",
                "...#.....#..#.#.......##.###.###...#....",
                "...............#..#....#.#....#....#.#..",
                "#......#...#.....#.#........##.##.#.....",
                "###.......#............#....#..#.#......",
                "..###.#.#....##..#.......#.............#",
                "##.#.#...#.#..........##.#..#...##......",
                "..#......#..........#.#..#....##........",
                "......##.##.#....#....#..........#...#..",
                "#.#..#..#.#...........#..#.......#..#.#.",
                "#.....#.#.........#............#.#..##.#",
                ".....##....#.##....#.....#..##....#..#..",
                ".#.......#......#.......#....#....#..#..",
                "...#........#.#.##..#.#..#..#........#..",
                "#........#.#......#..###....##..#......#",
                "...#....#...#.....#.....#.##.#..#...#...",
                "#.#.....##....#...........#.....#...#..."
            };

            var asteroids = FindAsteroids(input);
            var visible = FindVisible(asteroids);

            foreach (var asteroid in visible.OrderBy(a => a.Count))
                Console.WriteLine($"{asteroid.X},{asteroid.Y}: {asteroid.Count}");

            var target200 = FindNth(visible.OrderByDescending(a => a.Count).Select(a => (a.X, a.Y)).First(), asteroids, 200);
            Console.WriteLine($"{target200.X},{target200.Y}");
        }

        private static (int X, int Y) FindNth((int X, int Y) station, List<(int X, int Y)> asteroids, int n)
        {
            var hits = new Dictionary<double, int>();
            var targets = asteroids.Where(a => a.X != station.X || a.Y != station.Y)
                                   .Select(a => (a.X, a.Y, Angle: Math.Atan2(a.X - station.X, a.Y - station.Y)))
                                   .GroupBy(a => a.Angle)
                                   .OrderByDescending(a => a.Key)
                                   .ToList();
            var last = (X: 0, Y: 0);
            var rot = Math.PI + 0.01;
            while (hits.Values.Sum() < n)
            {
                var target = targets.FirstOrDefault(t => t.Key < rot && t.Count() > (hits.ContainsKey(t.Key) ? hits[t.Key] : 0));

                if (target == null)
                {
                    rot = Math.PI;
                    continue;
                }

                var angleHits = hits.ContainsKey(target.Key) ? hits[target.Key] : 0;
                last = (target.OrderBy(a => Math.Abs(a.X - station.X) + Math.Abs(a.Y - station.Y)).Skip(angleHits).First().X, target.OrderBy(a => Math.Abs(a.X - station.X) + Math.Abs(a.Y - station.Y)).Skip(angleHits).First().Y);

                rot -= rot - target.Key;
                if (rot < -Math.PI)
                    rot = Math.PI;

                hits[target.Key] = angleHits + 1;

                Console.WriteLine($"{last.X},{last.Y}");
            }

            return last;
        }

        private static List<(int X, int Y, int Count)> FindVisible(List<(int X, int Y)> asteroids)
            => asteroids.Select(asteroid => (asteroid.X, asteroid.Y, asteroids.Select(a => Math.Atan2(a.Y - asteroid.Y, a.X - asteroid.X)).Distinct().Count())).ToList();

        private static List<(int X, int Y)> FindAsteroids(string[] input)
        {
            var asteroids = new List<(int X, int Y)>();
            for (var y = 0; y < input.Length; y++)
            {
                for (var x = 0; x < input[y].Length; x++)
                {
                    if (input[y][x] == '#')
                        asteroids.Add((x, y));
                }
            }

            return asteroids;
        }
    }
}

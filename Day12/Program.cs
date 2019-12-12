using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day12
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = new[]
            {
                "<x=-7, y=-1, z=6>",
                "<x=6, y=-9, z=-9>",
                "<x=-12, y=2, z=-7>",
                "<x=4, y=-17, z=-12>"
            };

            Console.WriteLine(CalculateEnergy(input, 1000));
            Console.WriteLine(FindRepeat(input));
        }

        private enum Dimension
        {
            X,
            Y,
            Z,
            All
        }

        private class Moon
        {
            private int X { get; set; }
            private int Vx { get; set; }
            private int Y { get; set; }
            private int Vy { get; set; }
            private int Z { get; set; }
            private int Vz { get; set; }

            public (int P, int V) GetDimension(Dimension dimension)
            {
                switch (dimension)
                {
                    case Dimension.X:
                        return (X, Vx);
                    case Dimension.Y:
                        return (Y, Vy);
                    case Dimension.Z:
                        return (Z, Vz);
                    default:
                        throw new ArgumentException("what");
                }
            }

            public int Energy
            {
                get { return (Math.Abs(X) + Math.Abs(Y) + Math.Abs(Z)) * (Math.Abs(Vx) + Math.Abs(Vy) + Math.Abs(Vz)); }
            }

            public Moon(string position)
            {
                var parts = Regex.Match(position, "<x=(-?\\d+), y=(-?\\d+), z=(-?\\d+)>");
                X = int.Parse(parts.Groups[1].Value);
                Y = int.Parse(parts.Groups[2].Value);
                Z = int.Parse(parts.Groups[3].Value);
            }

            public void ApplyGravity(IEnumerable<Moon> moons, Dimension dimension = Dimension.All)
            {
                foreach (var moon in moons)
                {
                    if (moon == this)
                        continue;

                    if (dimension == Dimension.X || dimension == Dimension.All)
                        Vx -= X.CompareTo(moon.X);
                    if (dimension == Dimension.Y || dimension == Dimension.All)
                        Vy -= Y.CompareTo(moon.Y);
                    if (dimension == Dimension.Z || dimension == Dimension.All)
                        Vz -= Z.CompareTo(moon.Z);
                }
            }

            public void Move(Dimension dimension = Dimension.All)
            {
                if (dimension == Dimension.X || dimension == Dimension.All)
                    X += Vx;
                if (dimension == Dimension.Y || dimension == Dimension.All)
                    Y += Vy;
                if (dimension == Dimension.Z || dimension == Dimension.All)
                    Z += Vz;
            }
        }

        private static int CalculateEnergy(IEnumerable<string> input, int steps)
        {
            var moons = input.Select(s => new Moon(s)).ToList();
            for (var i = 0; i < steps; i++)
            {
                foreach (var moon in moons)
                    moon.ApplyGravity(moons);

                foreach (var moon in moons)
                    moon.Move();
            }

            return moons.Sum(m => m.Energy);
        }

        private static long FindRepeat(IEnumerable<string> input)
        {
            var dimensions = new[]
            {
                FindRepeat(input, Dimension.X),
                FindRepeat(input, Dimension.Y),
                FindRepeat(input, Dimension.Z)
            };

            return LowestCommonMultiplier(dimensions);
        }

        private static long FindRepeat(IEnumerable<string> input, Dimension dimension)
        {
            var start = input.Select(s => new Moon(s)).ToList();
            var moons = input.Select(s => new Moon(s)).ToList();
            var loops = 1L;
            do
            {
                for (var j = 0; j < start.Count; j++)
                    moons[j].ApplyGravity(moons, dimension);

                for (var j = 0; j < start.Count; j++)
                    moons[j].Move(dimension);

                var equal = !start.Where((t, i) => moons[i].GetDimension(dimension) != t.GetDimension(dimension)).Any();

                if (equal)
                    return loops;

                loops++;
            } while (true);
        }

        private static long GreatestCommonDenominator(long a, long b)
        {
            return b == 0 ? a : GreatestCommonDenominator(b, a % b);
        }

        private static long LowestCommonMultiplier(long[] values)
        {
            switch (values.Length)
            {
                case 0:
                    return 0;
                case 1:
                    return values[0];
                case 2:
                    return values[0] / GreatestCommonDenominator(values[0], values[1]) * values[1];
                default:
                    return LowestCommonMultiplier(new[] {values[0], LowestCommonMultiplier(values.Skip(1).ToArray())});
            }
        }
    }
}

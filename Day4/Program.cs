using System;
using System.Linq;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = 146810;
            var end = 612564;

            var criteria1 = new Func<string, bool>[]
            {
                s => s.Length == 6,
                s => int.TryParse(s, out _),
                s => s.Select((c, i) => i == 0 || c >= s[i - 1]).All(b => b),
                s => s.Select((c, i) => i != 0 && c == s[i - 1]).Any(b => b)
            };

            var criteria2 = new Func<string, bool>[]
            {
                s => s.Length == 6,
                s => int.TryParse(s, out _),
                s => s.Select((c, i) => i == 0 || c >= s[i - 1]).All(b => b),
                s => string.Join("", s.Select((v, i) => (i > 0 && s[i - 1] != v) ? $"|{v}" : $"{v}")).Split('|').Any(x => x.Length == 2)
            };

            Console.WriteLine(Enumerable.Range(start, end - start).Select(i => criteria1.All(c => c(i.ToString()))).Count(i => i));
            Console.WriteLine(Enumerable.Range(start, end - start).Select(i => criteria2.All(c => c(i.ToString()))).Count(i => i));
        }
    }
}

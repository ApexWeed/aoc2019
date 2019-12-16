using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day16
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "59709275180991144553584971145772909665510077889137728108418335914621187722143499835763391833539113913245874471724316543318206687063884235599476032241946131415288903315838365933464260961288979081653450180693829228376307468452214424448363604272171578101049695177870848804768766855959460302410160410252817677019061157656381257631671141130695064999297225192441065878259341014746742840736304437968599872885714729499069286593698777113907879332554209736653679474028316464493192062972874319626623316763537266681767610340623614648701699868901159785995894014509520642548386447251984766543776759949169049134947575625384064448900019906754502662096668908517457172";

            var transformed = input.Select(c => int.Parse(c.ToString())).ToArray();
            transformed = Wtfft(transformed, 100);

            Console.WriteLine(string.Join("", transformed.Take(8).Select(b => b.ToString())));

            var offset = int.Parse(input.Substring(0, 7));
            transformed = input.Repeat(10000).Select(c => int.Parse(c.ToString())).ToArray();
            transformed = WtfftOffset(transformed, offset, 100);

            Console.WriteLine(string.Join("", transformed.Take(8).Select(b => b.ToString())));
        }

        private static int[] Wtfft(int[] input, int iterations)
        {
            var output = new int[input.Length];

            foreach (var _ in Enumerable.Range(0, iterations))
            {
                Parallel.For(0, input.Length, i =>
                {
                    var j = i;
                    var step = i + 1;
                    var accum = 0;

                    while (j < input.Length)
                    {
                        var max = Math.Min(j + step, input.Length);
                        for (var k = j; k < max; k++)
                            accum += input[k];
                        j += 2 * step;

                        max = Math.Min(j + step, input.Length);
                        for (var k = j; k < max; k++)
                            accum -= input[k];
                        j += 2 * step;
                    }

                    output[i] = Math.Abs(accum % 10);
                });
            }

            return output;
        }

        private static int[] WtfftOffset(int[] input, int offset, int iterations)
        {
            var output = new int[input.Length - offset];
            Array.Copy(input, offset, output, 0, output.Length);

            foreach (var _ in Enumerable.Range(0, iterations))
            {
                for (var i = output.Length - 2; i > -1; i--)
                {
                    output[i] += output[i + 1];
                    output[i] %= 10;
                }
            }

            return output;
        }
    }

    public static class StringExtensions
    {
        public static string Repeat(this string s, int n)
            => new StringBuilder(s.Length * n).Insert(0, s, n).ToString();
    }
}

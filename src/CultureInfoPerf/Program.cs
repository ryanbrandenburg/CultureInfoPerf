using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace CultureInfoPerf
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cultureCache = new List<CultureInfo>();

            var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            foreach (var culture in cultures)
            {
                cultureCache.Add(new CultureInfo(culture.Name));
            }
            stopwatch.Stop();

            var average = stopwatch.ElapsedTicks / cultures.Length;
            Console.WriteLine($"There were {cultures.Length} cultures");
            Console.WriteLine($"Took {stopwatch.ElapsedTicks} ticks");
            Console.WriteLine($"Took {average} ticks per culture");
        }
    }
}

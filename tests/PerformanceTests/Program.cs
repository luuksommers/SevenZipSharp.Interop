using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using SevenZip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTests
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Extracting using 9.38...");
            var sz = new SevenZip9_38();
            sz.Setup();
            sz.Extract();
            Console.WriteLine("OK");

            Console.Write("Extracting using 18.05...");
            var sz2 = new SevenZip18_05();
            sz2.Setup();
            sz2.Extract();
            Console.WriteLine("OK");

            var summary = BenchmarkRunner.Run<OldVsNew>();

            Console.ReadLine();
        }
    }
}

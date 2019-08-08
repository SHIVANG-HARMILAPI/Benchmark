using System;
using System.Collections;
using System.Collections.Generic;
//using System.Linq;
using System.Reflection;
using System.Threading;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Threading.Tasks;
using System.Text;

namespace Practise
{

    [MemoryDiagnoser]
    [CoreJob,RPlotExporter,RankColumn]
    public class Program
    {
        static void Main(string[] args)
        {
             var summary = BenchmarkRunner.Run<Program>();
        }

        [Benchmark]
        public void UsingString()
        {
            String s = new String("SHIVANG HARMILAPI");
            for (int i = 0; i < 10; i++)
                s += i.ToString();
        }
         [Benchmark]
        public void UsingStringBuilder()
        {
            StringBuilder sb = new StringBuilder("SHIVANG HARMILAPI");
            for (int i = 0; i < 10; i++)
                sb.Append(i.ToString());
        }



    }

}






























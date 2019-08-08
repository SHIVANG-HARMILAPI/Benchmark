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
        public void UsingForLoop()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 100000; i++)
                list.Add(i);

        }
         [Benchmark]
        public void UsingWhileLoop()
        {
            List<int> list = new List<int>();
            int i = 0;
            while (i < 100000)
            {
                list.Add(i);
                i++;
            }
        }



    }


}

}






























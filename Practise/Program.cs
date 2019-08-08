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
        public void RunningCodeUsingForLoop()
        {
            List<int> l = new List<int>();
            int a = 0;
            for (int i = 0; i < 100000; i++)
                l.Add(i);

            for (int i = 0; i < 100000; i++)
                a = l[i];


        }
         [Benchmark]
        public void RunningCodeUsingForEachLoop()
        {
            List<int> l = new List<int>();
            int a = 0;
            for (int i = 0; i < 100000; i++)
                l.Add(i);

            foreach (int i in l)
                a = i;
        }





    }

}






























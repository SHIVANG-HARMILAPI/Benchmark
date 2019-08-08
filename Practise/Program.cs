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
        public void UsingThread()
        {
            int sum = 0;
            Thread t = new Thread(() => {
                for (int i = 0; i < 10000; i++)
                    sum += i;
            });
            t.Start();
        }
        [Benchmark]
        public void UsingTask()
        {
            int sum = 0;
            Task t = new Task(()=> {
                for (int i = 0; i < 10000; i++)
                    sum += i;
            });

        }


    }

}






























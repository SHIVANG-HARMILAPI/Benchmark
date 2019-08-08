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
        public void UsingIfCase()
        {
            string day = "Saturday";
            if (day == "Monday")
                Console.WriteLine(1);
            else if (day == "Tuesday")
                Console.WriteLine(2);
            else if (day == "Wednesday")
                Console.WriteLine(2);
            else if (day == "Thursday")
                Console.WriteLine(2);
            else if (day == "Friday")
                Console.WriteLine(2);
            else if (day == "Saturday")
                Console.WriteLine(2);

        }
          [Benchmark]
        public void UsingSwitchCase()
        {
            String day = "Saturday";
            switch (day)
            {
                case "Monday":
                    Console.WriteLine(1);
                    break;
                case "Tuesday":
                    Console.WriteLine(2);
                    break;
                case "Wednesday":
                    Console.WriteLine(3);
                    break;
                case "Thursday":
                    Console.WriteLine(4);
                    break;
                case "Friday":
                    Console.WriteLine(5);
                    break;
                case "Saturday":
                    Console.WriteLine(6);
                    break;

            }


        }


    }

}






























using EntityFramework.Performance.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Linq;

namespace EntityFramework.Performance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QueryPerformance.TooManyQueries();
            Console.WriteLine("End!");
            Console.ReadKey();
        }
    }
}
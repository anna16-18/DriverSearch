using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using DriverSearch;

namespace DriverSearch.Benchmark
{
    [MemoryDiagnoser]
    public class SearchBenchmark
    {
        private List<Driver> drivers;
        private SortSearch sortSearch;
        private ManualSearch manualSearch;
        private QueueSearch queueSearch;

        [GlobalSetup]
        public void Setup()
        {
            drivers = new List<Driver>();
            var random = new Random(1);

            for (int i = 0; i < 50_000; i++)
            {
                drivers.Add(new Driver(
                    i,
                    random.Next(0, 1000),
                    random.Next(0, 1000)));
            }

            sortSearch = new SortSearch();
            manualSearch = new ManualSearch();
            queueSearch = new QueueSearch();
        }

        [Benchmark]
        public void SortAlgorithm() => sortSearch.Find(drivers, 500, 500);

        [Benchmark]
        public void ManualAlgorithm() => manualSearch.Find(drivers, 500, 500);

        [Benchmark]
        public void QueueAlgorithm() => queueSearch.Find(drivers, 500, 500);
    }
}
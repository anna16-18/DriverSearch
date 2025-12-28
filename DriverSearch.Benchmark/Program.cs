using BenchmarkDotNet.Running;


namespace DriverSearch.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SearchBenchmark>();
        }
    }
}

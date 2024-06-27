using BenchmarkDotNet.Running;

namespace BenchmarkLocks
{
    internal class Program
    {
        static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);

    }
}

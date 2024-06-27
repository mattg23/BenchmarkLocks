using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkLocks
{
    [SimpleJob]
    [DisassemblyDiagnoser(printSource: true)]
    [ThreadingDiagnoser]
    public class LockingParallel
    {

        [Params(25, 100, 250)]
        public int max_runs_per_invoke { get; set; }

        private double value = 0;
        object mutex = new object();

        [Benchmark(Baseline = true)]
        public void NoLock()
        {
            Parallel.For(0, max_runs_per_invoke, (_) =>
            {
                unchecked { value += 1; }
            });
        }

        [Benchmark]
        public void Parallel_UseLock()
        {
            Parallel.For(0, max_runs_per_invoke, (_) =>
            {
                UseLock();
            });
        }

        [Benchmark]
        public void Parallel_UseInterLock()
        {
            Parallel.For(0, max_runs_per_invoke, (_) =>
            {
                UseInterLockSpin();
            });
        }


        private void UseLock()
        {
            lock (mutex)
            {
                unchecked { value += 1; }
            }
        }

        private const int LOCKED = 1;
        private const int UNLOCKED = 0;
        private int atomicMutex = 0;

        private double UseInterLockSpin()
        {

            var s = new SpinWait();

            bool isDone = false;

            do
            {
                if (System.Threading.Interlocked.CompareExchange(ref atomicMutex, LOCKED, UNLOCKED) == UNLOCKED)
                {
                    // CompareExchange returned "UNLOCKED" as the original value, which means the value is NOW locked, since the
                    // operation is atomic, hence we took the lock.
                    // check https://learn.microsoft.com/en-us/dotnet/api/system.threading.interlocked.compareexchange?view=net-8.0


                    unchecked { value += 1; }

                    isDone = true;
                    // unlock after work:
                    System.Threading.Interlocked.Exchange(ref atomicMutex, UNLOCKED);                    
                }
                else
                {
                    s.SpinOnce();
                }
            } while (!isDone);

            return value;
        }
    }
}

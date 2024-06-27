using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BenchmarkLocks
{

    [SimpleJob]
    [DisassemblyDiagnoser(printSource: true)]
    [ThreadingDiagnoser]
    public class LockingDontWait
    {
        private double value = 0;
        object mutex = new object();


        [Benchmark(Baseline = true)]
        public void NoLock()
        {
            unchecked { value += 1; }
        }


        [Benchmark]
        public double UseLock()
        {
            bool lockTaken = false;
            try
            {
                lockTaken = Monitor.TryEnter(mutex);
                if (lockTaken)
                {
                    unchecked { value += 1; }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (lockTaken)
                    Monitor.Exit(mutex);
            }

            return value;
        }

        private const int LOCKED = 1;
        private const int UNLOCKED = 0;
        private int atomicMutex = 0;

        [Benchmark]
        public double UseInterLockSpin()
        {


            if (System.Threading.Interlocked.CompareExchange(ref atomicMutex, LOCKED, UNLOCKED) == UNLOCKED)
            {
                // CompareExchange returned "UNLOCKED" as the original value, which means the value is NOW locked, since the
                // operation is atomic, hence we took the lock.
                // check https://learn.microsoft.com/en-us/dotnet/api/system.threading.interlocked.compareexchange?view=net-8.0


                unchecked { value += 1; }

                // unlock after work:
                System.Threading.Interlocked.Exchange(ref atomicMutex, UNLOCKED);
            }

            return value;
        }

    }
}

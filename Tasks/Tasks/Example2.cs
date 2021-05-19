using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Example2
    {
        private static Random rand = new Random();

        private static void Teste2()
        {
            // Wait on a single task with no timeout specified.
            Task taskA = Task.Run(() => Thread.Sleep(2000));
            Console.WriteLine("taskA Status: {0}", taskA.Status);
            try
            {
                taskA.Wait();
                Console.WriteLine("taskA Status: {0}", taskA.Status);
            }
            catch (AggregateException)
            {
                Console.WriteLine("Exception in taskA.");
            }
        }
    }
}

// The example displays output like the following:
//     taskA Status: WaitingToRun
//     taskA Status: RanToCompletion
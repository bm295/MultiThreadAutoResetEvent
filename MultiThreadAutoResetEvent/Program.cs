using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadAutoResetEvent
{
    class Program
    {
        static AutoResetEvent autoEvent = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            Task.Factory.StartNew(() => CalculateSum(50));
            Thread.Sleep(3000);
            autoEvent.Set();
            Console.ReadLine();
        }

        public static void CalculateSum(int maxNumber)
        {
            int sum = 0;
            for (int i = 0; i <= maxNumber; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum Calculated. Waiting for Main thread to send signal to unblock me");
            autoEvent.WaitOne();
            Console.WriteLine("Sum: " + sum);
        }
    }
}

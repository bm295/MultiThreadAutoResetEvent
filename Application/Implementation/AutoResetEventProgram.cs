using Application.Interface;

namespace Application.Implementation
{
    internal class AutoResetEventProgram : IProgram
    {
        readonly AutoResetEvent autoEvent = new(false);

        public void Run()
        {
            Task.Factory.StartNew(() => CalculateSum(50));
            Thread.Sleep(3000);
            autoEvent.Set();
        }

        private void CalculateSum(int maxNumber)
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

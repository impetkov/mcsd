using System;
using System.Threading.Tasks;

namespace LambdaExercise
{
    public class AsyncLambdas : EventArgs
    {
        private int TrialCount;
        public event EventHandler SomeEventHandler;

        public void RunSomething()
        {
            SomeEventHandler += async (sender, args) =>
            {
                var trials = ++TrialCount;
                Console.WriteLine($"Started trial: {trials}");
                await DoSomethingSlow();
                Console.WriteLine($"Done with trial {trials}");
            };

            SomeEventHandler?.Invoke(this, new EventArgs());
        }

        private async Task DoSomethingSlow()
        {
            await Task.Delay(3000);
        }
    }
}

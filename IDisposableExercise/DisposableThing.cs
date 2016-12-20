using System;

namespace IDisposableExercise
{
    class DisposableThing : IDisposable
    {
        public string Name = string.Empty;

        private bool ResourcesAreFreed = false;

        public void Dispose()
        {
            FreeResources(true);
        }

        private void FreeResources(bool freeManagedResources)
        {
            Console.WriteLine($"{Name}: FreeResources");

            if (!freeManagedResources)
            {
                Console.WriteLine($"{Name}: Dispose of managed resources");
            }

            Console.WriteLine($"{Name}: Dispose of unmanaged resources");

            ResourcesAreFreed = true;

            GC.SuppressFinalize(this);
        }

        ~DisposableThing()
        {
            FreeResources(false);
        }
    }
}

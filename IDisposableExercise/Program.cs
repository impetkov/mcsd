using System;

namespace IDisposableExercise
{
    public class Program
    {
        private static int ObjectNumber = 1;
        static void Main(string[] args)
        {
            CreateAndDispose();
            Create("Create");
            Create("Create");
            CreateAndDispose();
            Console.ReadLine();
            CollectGarbage();
            Console.ReadLine();
        }

        private static void CreateAndDispose()
        {
            var disposableThing = Create("CreateAndDispose");
            disposableThing.Dispose();
        }

        private static DisposableThing Create(string name)
        {
            var disposableThing = new DisposableThing
            {
                Name = $"{name} {ObjectNumber}"
            };

            ObjectNumber++;

            return disposableThing;
        }

        private static void CollectGarbage()
        {
            GC.Collect();
        }
    }
}

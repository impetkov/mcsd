using System;

namespace IComparableExample
{
    public static class Program
    {
        static void Main()
        {
            var comparableCars = new[]
            {
                new ComparableCar
                {
                    Horsepower = 12,
                    Name = "z",
                    Price = 21,
                    MaxMph = 2436
                },
                new ComparableCar
                {
                    Horsepower = 21312,
                    Name = "s",
                    Price = 2112,
                    MaxMph = 26
                },
                new ComparableCar
                {
                    Horsepower = 1,
                    Name = "u",
                    Price = 3,
                    MaxMph = 333
                }
            };

            DisplayComparableCars(comparableCars);
            Console.WriteLine();
            Array.Sort(comparableCars);
            DisplayComparableCars(comparableCars);
            Console.WriteLine();
            CompareUsingComparer(comparableCars);
        }

        private static void CompareUsingComparer(ComparableCar[] comparableCars)
        {
            var comparer = new CarComparer
            {
                SortField = CompareField.Horsepower
            };

            Array.Sort(comparableCars, comparer);
            DisplayComparableCars(comparableCars);

            comparer.SortField = CompareField.MaxMph;
            Array.Sort(comparableCars, comparer);
            DisplayComparableCars(comparableCars);

            comparer.SortField = CompareField.Price;
            Array.Sort(comparableCars, comparer);
            DisplayComparableCars(comparableCars);
        }

        private static void DisplayComparableCars(ComparableCar[] cars)
        {
            foreach (var comparableCar in cars)
            {
                Console.WriteLine($"{comparableCar.Name}; {comparableCar.Horsepower}; {comparableCar.MaxMph}; {comparableCar.Price}");
            }

            Console.ReadLine();
        }
    }
}

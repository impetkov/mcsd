using System;
using System.Collections.Generic;

namespace IComparableExample
{
    public class CarComparer : IComparer<ComparableCar>
    {
        public CompareField SortField = CompareField.Name;
        public int Compare(ComparableCar firstCar, ComparableCar secondCar)
        {
            switch (SortField)
            {
                case CompareField.Name:
                    return String.Compare(firstCar.Name, secondCar.Name, StringComparison.OrdinalIgnoreCase);
                case CompareField.MaxMph:
                    return firstCar.MaxMph.CompareTo(secondCar.MaxMph);
                case CompareField.Price:
                    return firstCar.Price.CompareTo(secondCar.Price);
                case CompareField.Horsepower:
                    return firstCar.Horsepower.CompareTo(secondCar.Horsepower);               
            }

            return string.Compare(firstCar.Name, secondCar.Name, StringComparison.OrdinalIgnoreCase);
        }
    }

    public enum CompareField
    {
        Name,
        MaxMph,
        Price,
        Horsepower
    }
}

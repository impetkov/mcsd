using System;
using static System.String;

namespace IComparableExample
{
    public class ComparableCar : IComparable<ComparableCar>
    {
        public string Name { get; set; }
        public int MaxMph { get; set; }
        public int Horsepower { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(ComparableCar other)
        {
            return Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
}

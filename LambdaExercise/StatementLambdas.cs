using System;

namespace LambdaExercise
{
    public class StatementLambdas
    {
        public Func<int, bool> OddityDeterminer;
        public bool IsOdd(int number)
        {
            OddityDeterminer = n =>
            {
                if (n%2 != 0)
                {
                    return true;
                }

                return false;
            };

            return OddityDeterminer(number);
        }
    }
}

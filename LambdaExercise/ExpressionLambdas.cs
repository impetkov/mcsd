using System;

namespace LambdaExercise
{    
    public class ExpressionLambdas
    {
        public Action SayHi;
        public Action<string> SaySomething;
        public Action<string, string, string, int> SayManyThings;
        public Func<int, int, int> AddTwoThings;

        public void DoSayHi()
        {
            SayHi = () => Console.WriteLine("Hi");             

            SayHi();
        }

        public void DoSaySomething(string somethingToSay)
        {
            SaySomething = whatToSay => Console.WriteLine(whatToSay);

            SaySomething(somethingToSay);
        }

        public void DoSayManyThings(string name, string surname, string randomTidBit, int age)
        {
            SayManyThings = (n, s, r, a) => Console.WriteLine($"Name: {n} \nSurname{s} \nRandomTidBit:{r} \nAge:{a}");

            SayManyThings(name, surname, randomTidBit, age);
        }

        public int DoAddTwoThings(int x, int y)
        {
            AddTwoThings = (one, two) => one + two;

            return AddTwoThings(x, y);
        }
    }
}

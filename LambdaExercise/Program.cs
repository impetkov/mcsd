using System;

namespace LambdaExercise
{
    public class Program
    {
        static void Main()
        {
            DoExpressionLambdas();
            DoStatementLambdas();
            DoAsyncLambdas();
            Console.ReadLine();
        }

        private static void DoAsyncLambdas()
        {
            var asyncLambdas = new AsyncLambdas();
            asyncLambdas.RunSomething();
        }

        private static void DoExpressionLambdas()
        {
            var expressionLambdas = new ExpressionLambdas();

            expressionLambdas.DoSayHi();
            Console.WriteLine();

            expressionLambdas.DoSaySomething("Something");
            Console.WriteLine();

            expressionLambdas.DoSayManyThings("Ivan", "Petkov", "Whatever", 26);
            Console.WriteLine();

            Console.WriteLine(expressionLambdas.DoAddTwoThings(12, 23));
            Console.WriteLine();
        }

        private static void DoStatementLambdas()
        {
            var statementLambdas = new StatementLambdas();

            Console.WriteLine(statementLambdas.IsOdd(14));
            Console.WriteLine();
        }
    }
}

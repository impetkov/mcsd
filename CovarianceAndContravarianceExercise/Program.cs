using System;
using System.Runtime.InteropServices;

namespace CovarianceAndContravarianceExercise
{
    public class Program
    {
        private delegate Person ReturnPersonDelegate();
        private static ReturnPersonDelegate ReturnPersonMethod;

        private delegate void EmployeeParameterDelegate(Employee employee);
        private static EmployeeParameterDelegate EmployeeParameterMethod;

        private delegate Person ReturnsPersonTakesEmployeeDelegate(Employee employee);
        private static ReturnsPersonTakesEmployeeDelegate ReturnsPersonTakesEmployeeMethod;

        private static Action<Employee> EmployeeParameterAction;
        private static Func<Person> ReturnPersonFunc;

        private static Func<int, int, int> SomeFunction = delegate(int x, int y) { return x + y; };

        static void Main()
        {
            //Covariance
            Console.WriteLine("Vanilla Covariance");
            ReturnPersonMethod = ReturnEmployee;
            ReturnPersonMethod();
            Console.WriteLine();

            //Func Covariance
            Console.WriteLine("Func Covariance");
            ReturnPersonFunc = ReturnEmployee;
            ReturnPersonFunc();
            Console.WriteLine();

            //Contravariance
            Console.WriteLine("Vanilla Contravariance");
            EmployeeParameterMethod = SomethingThatTakesAPerson;
            EmployeeParameterMethod(new Employee());
            Console.WriteLine();

            //Action contravariance
            Console.WriteLine("Action Contravariance");
            EmployeeParameterAction = SomethingThatTakesAPerson;
            EmployeeParameterAction(new Employee());
            Console.WriteLine();

            //ContraCovariance
            Console.WriteLine("Vanilla ContraCovariance");
            ReturnsPersonTakesEmployeeMethod = ReturnsEmployeeTakesPerson;
            ReturnsPersonTakesEmployeeMethod(new Employee());
            Console.WriteLine();

            //Anonymous Method
            Console.WriteLine("Anonymous Method");
            Console.WriteLine(SomeFunction(2, 3));

            Console.ReadLine();
        }

        private static Employee ReturnEmployee()
        {
            Console.WriteLine("This returns an Employee");
            return new Employee();
        }

        private static void SomethingThatTakesAPerson(Person person)
        {
            Console.WriteLine("This takes a Person as input");
        }

        private static Employee ReturnsEmployeeTakesPerson(Person person)
        {
            Console.WriteLine("This returns an employee and takes a person");
            return new Employee();
        }
    }

    internal class Person
    {
    }

    internal class Employee : Person
    {        
    }
}

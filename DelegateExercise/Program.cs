using System;

namespace DelegateExercise
{
    public static class Program
    {
        private delegate int ConversionDelegate(string stringToConvert);

        private static ConversionDelegate theDelegate;

        static void Main()
        {
            var delegatedDude = new DelegatedPerson { Name = "DelegatedDude" };
            var delegatedLass = new DelegatedPerson { Name = "DelegatedLass" };

            delegatedDude.InstanceDelegate = delegatedDude.GetName;
            delegatedDude.StaticDelegate = DelegatedPerson.GetStaticName;

            delegatedLass.InstanceDelegate = delegatedDude.GetName;
            delegatedLass.StaticDelegate = DelegatedPerson.GetStaticName;

            var result = $"DelegatedDude's instance method returns: {delegatedDude.InstanceDelegate()} \n" + 
                         $"DelegatedLass's instance method returns: {delegatedLass.InstanceDelegate()} \n" +
                         "\n" +
                         $"DelegatedDude's static method returns: {delegatedDude.StaticDelegate()} \n" +
                         $"DelegateLass's static method returns: {delegatedLass.StaticDelegate()}";

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int SomeRandomFunction(string someRandomstring)
        {
            return int.Parse(someRandomstring);
        }
    }
}

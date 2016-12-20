namespace DelegateExercise
{
    public class DelegatedPerson
    {
        public string Name { get; set; }

        public delegate string GetStringDelegate();

        public static string GetStaticName()
        {
            return "Static Name";
        }

        public string GetName()
        {
            return Name;
        }

        public GetStringDelegate InstanceDelegate;
        public GetStringDelegate StaticDelegate;
    }
}

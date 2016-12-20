using System;

namespace IEnumerableExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var president = new TreeNode("President");

            var sales = president.AddChild("Sales");
            sales.AddChild("Sale1");
            sales.AddChild("Sale2");

            var otherThings = president.AddChild("other things");
            otherThings.AddChild("other1");
            otherThings.AddChild("other2");

            var text = string.Empty;
            
            using (var enumerator = president.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    text += new string(' ', 4 * enumerator.Current.Depth)
                            + enumerator.Current.Text
                            + Environment.NewLine;
                }
            }

            text += Environment.NewLine;

            foreach (var node in president.GetTraversal())
            {
                text += new string(' ', 4 * node.Depth)
                    + node.Text
                    + Environment.NewLine;
            }

            text = text.Substring(0, text.Length - Environment.NewLine.Length);

            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}

namespace _03.Attributes.Models
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            var startUp = typeof(StartUp);
            var methods = startUp.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

            foreach (MethodInfo methodInfo in methods)
            {
                if (methodInfo.CustomAttributes.Any(a => a.AttributeType == typeof(SoftUniAttribute)))
                {
                    foreach (SoftUniAttribute customAttribute in methodInfo.GetCustomAttributes(false))
                    {
                        Console.WriteLine($"{methodInfo.Name} is written by {customAttribute.Name}");
                    }
                }
            }
        }
    }
}
using System;
using System.Reflection;

namespace _02BlackBoxInteger.Core
{
    public class Interpreter
    {
        public void PrintResult(string input)
        {
            string[] parameters = input.Split('_');
            string methodName = parameters[0];
            int value = int.Parse(parameters[1]);

            Console.WriteLine(this.MethodResult(methodName, value));
        }

        private int MethodResult(string methodName, int value)
        {
            MethodInfo method = typeof(BlackBoxInt).GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
            ConstructorInfo construct =
                typeof(BlackBoxInt).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null,
                    new[] {typeof(int)}, null);
            BlackBoxInt blBoxInstance = (BlackBoxInt) construct.Invoke(new object[] {0});
            //method.Invoke(blBoxInstance, new object[] {value});
            FieldInfo field = typeof(BlackBoxInt).GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic);
            field.SetValue(blBoxInstance, method.Invoke(blBoxInstance, new object[] { value }) );
            return (int) field.GetValue(blBoxInstance);
        }
    }
}

using System;
using System.Reflection;

namespace _02BlackBoxInteger.Core
{
    public class Interpreter
    {
        private ConstructorInfo construct;
        private BlackBoxInt blBoxInstance;

        public Interpreter()
        {
            this.construct = typeof(BlackBoxInt).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null,
                    Type.EmptyTypes, null);
            this.blBoxInstance = (BlackBoxInt)construct.Invoke(new object[] { });
        }

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
            method.Invoke(this.blBoxInstance, new object[] { value });
            FieldInfo field = typeof(BlackBoxInt).GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic);
            return (int)field.GetValue(this.blBoxInstance);
        }
    }
}

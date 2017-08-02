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
            ConstructorInfo construct = typeof(BlackBoxInt).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, typeof(BlackBoxInt));
            BlackBoxInt blBoxInstance = (BlackBoxInt)construct.Invoke(new object[] {});
            method.Invoke(blBoxInstance, new object[] { value });
            FieldInfo field = typeof(BlackBoxInt).GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic);
            return (int)field.GetValue(blBoxInstance);
        }
        


        //MethodInfo dynMethod = this.GetType().GetMethod("Draw_" + itemType,
        //    BindingFlags.NonPublic | BindingFlags.Instance);
        //        dynMethod.Invoke(this, new object[] { methodParams
        //    });
    }
}

using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string insvestigatedClass, params string[] investigatedFields)
    {
        StringBuilder sb = new StringBuilder();
        Type myType = Type.GetType(insvestigatedClass);
        FieldInfo[] fields = myType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

        sb.AppendLine($"Class under investigation: {insvestigatedClass}");
        Object investigatedClassInstance = Activator.CreateInstance(myType, new object[] { });

        foreach (FieldInfo field in fields)
        {
            if (investigatedFields.Contains(field.Name))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(investigatedClassInstance)}");
            }
        }

        return sb.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        
        Type myType = Type.GetType(className);

        FieldInfo[] fields = myType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        StringBuilder sb = new StringBuilder();

        foreach (FieldInfo field in fields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }

        MethodInfo[] nonPublicGetMethods = myType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
            .Where(m => m.Name.StartsWith("get"))
            .ToArray();

        foreach (MethodInfo method in nonPublicGetMethods)
        {
            sb.AppendLine($"{method.Name} have to be public!");
        }

        MethodInfo[] publicSetMethods = myType.GetMethods(BindingFlags.Instance | BindingFlags.Public)
            .Where(m => m.Name.StartsWith("set"))
            .ToArray();

        foreach (MethodInfo method in publicSetMethods)
        {
            sb.AppendLine($"{method.Name} have to be private!");
        }

        return sb.ToString().Trim();
    }

    public string RevealPrivateMethods(string className)
    {
        Type myType = Type.GetType(className);

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"All Private Methods of Class: {className}");
        sb.AppendLine($"Base Class: {myType.BaseType.Name}");
        MethodInfo[] methods = myType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (MethodInfo method in methods)
        {
            sb.AppendLine(method.Name);
        }

        return sb.ToString().Trim();
    }

    public string CollectGettersAndSetters(string className)
    {
        Type myType = Type.GetType(className);

        MethodInfo[] methods = myType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        StringBuilder sb = new StringBuilder();

        foreach (MethodInfo method in methods.Where(m => m.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} will return {method.ReturnType}");
        }

        foreach (MethodInfo method in methods.Where(m => m.Name.StartsWith("set")))
        {
            sb.AppendLine($"{method.Name} will set field of {method.GetParameters().FirstOrDefault().ParameterType}");
        }
        return sb.ToString().Trim();
    }
}
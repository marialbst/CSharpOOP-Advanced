using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _01HarestingFields.Core
{
    public class Interpreter
    {
        public void Print(string command)
        {
            switch (command)
            {
                case "private": Console.WriteLine(this.PrintFields(this.GetPrivateFields()));break;
                case "public": Console.WriteLine(this.PrintFields(this.GetPublicFields()));break;
                case "protected": Console.WriteLine(this.PrintFields(this.GetProtectedFields())); break;
                case "all": Console.WriteLine(this.PrintFields(this.GetAllFields()));break;
            }
        }

        private string PrintFields(FieldInfo[] fields)
        {
            StringBuilder sb = new StringBuilder();

            foreach (FieldInfo field in fields)
            {
                sb.AppendLine($"{(field.Attributes.ToString() == "Family" ? "protected" : field.Attributes.ToString().ToLower())} {field.FieldType.Name} {field.Name}");
            }

            return sb.ToString().Trim();
        }

        private FieldInfo[] GetPublicFields()
        {
            return this.GetAllFields().Where(f => f.IsPublic).ToArray();
        }

        private FieldInfo[] GetAllFields()
        {
            Type classType = typeof(HarvestingFields);
            return classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        }

        private FieldInfo[] GetProtectedFields()
        {
            
            return this.GetAllFields().Where(f => f.IsFamily).ToArray();
        }

        private FieldInfo[] GetPrivateFields()
        {
            return this.GetAllFields().Where(f => f.IsPrivate).ToArray();
        }
    }
}

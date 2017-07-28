namespace _07.EqualityLogic.Models
{
    using System;

    public class Person : IComparable<Person>
    {

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; }
        public int Age { get; }

        public override bool Equals(object obj)
        {
            var person = obj as Person;

            return (person != null) && (this.Name == person.Name) && (this.Age == person.Age);
        }

        public override int GetHashCode()
        {
            return ($"{this.Name} {this.Age}").GetHashCode();
        }

        public int CompareTo(Person other)
        {
            if(this.Name == other.Name)
            {
                return this.Age.CompareTo(other.Age);
            }

            return this.Name.CompareTo(other.Name);
        }
    }
}

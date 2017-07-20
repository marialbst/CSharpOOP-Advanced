namespace _08.MilitaryElite.Models
{
    using Interfaces;
    using System;

    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int code) 
            : base(id, firstName, lastName)
        {
            this.Code = code;
        }

        public int Code { get; private set; }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Code Number: {this.Code}";
        }
    }
}

namespace _10_11.InfernoInfinity.Attribute
{
    using System;
    using System.Collections.Generic;

    [AttributeUsage(AttributeTargets.Class)]
    public class CustomClassAttribute : Attribute
    {
        public CustomClassAttribute(string author, int revision, string description, params string[] reviewers)
        {
            this.Author = author;
            this.Revision = revision;
            this.Description = description;
            this.Reviewers = new List<string>(reviewers);
        }

        public string Author { get; set; }
        public int Revision { get; set; }
        public string Description { get; set; }
        public IList<string> Reviewers { get; set; }
    }
}

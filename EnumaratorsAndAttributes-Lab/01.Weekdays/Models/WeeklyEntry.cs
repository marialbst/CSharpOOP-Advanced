namespace _01.Weekdays.Models
{
    using System;
    using Enumerators;

    public class WeeklyEntry : IComparable<WeeklyEntry>
    {
        public WeeklyEntry(string weekDay, string notes)
        {
            this.WeekDay = (WeekDay)Enum.Parse(typeof(WeekDay),weekDay);
            this.Notes = notes;
        }

        public WeekDay WeekDay { get; private set; }
        public string Notes { get; private set; }
        public int CompareTo(WeeklyEntry other)
        {
            if (ReferenceEquals(this,other))
            {
                return 0;
            }
            if (ReferenceEquals(null,other))
            {
                return 1;
            }
            int result = this.WeekDay.CompareTo(other.WeekDay);
            if (result != 0)
            {
                return result;
            }

            return this.Notes.CompareTo(other.Notes);
        }

        public override string ToString()
        {
            return $"{this.WeekDay} - {this.Notes}";
        }
    }
}
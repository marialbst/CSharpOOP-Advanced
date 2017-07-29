namespace _01.Weekdays.Models
{
    using System.Collections.Generic;

    public class WeeklyCalendar
    {
        private IList<WeeklyEntry> data;

        public WeeklyCalendar()
        {
            this.data = new List<WeeklyEntry>();
        }

        public IEnumerable<WeeklyEntry> WeeklySchedule { get { return this.data; }}

        public void AddEntry(string weekDay,string notes)
        {
            this.data.Add(new WeeklyEntry(weekDay,notes));
        }
    }
}
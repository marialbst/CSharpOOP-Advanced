namespace _04.Froggy.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;


    public class Lake : IEnumerable<int>
    {
        public Lake(params int[] stones)
        {
            this.Stones = new List<int>(stones);
        }

        public IList<int> Stones { get; set; }

        internal void ForEach()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.Stones.Count; i+=2)
            {
                yield return this.Stones[i];
            }

            int startIndex = this.Stones.Count - 1;

            if (this.Stones.Count % 2 == 1)
            {
                startIndex--;
            }

            for (int i = startIndex; i > 0; i-=2)
            {
                yield return this.Stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

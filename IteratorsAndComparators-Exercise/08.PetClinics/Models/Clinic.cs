namespace _08.PetClinics.Models
{
    using System;
    using System.Linq;

    public class Clinic
    {
        public Clinic(string name, int roomsCount)
        {
            if (roomsCount % 2 == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            this.Rooms = new Room[roomsCount];

            for (int i = 0; i < roomsCount; i++)
            {
                this.Rooms[i] = new Room();
            }

            this.Name = name;
        }

        public string Name { get; private set; }
        public Room[] Rooms { get; set; }

        public bool Add(Pet pet)
        {
            if(!this.HasEmptyRooms())
            {
                return false;
            }

            int startIndex = this.Rooms.Length/2;
            int count = 1;

            for (int i = 0; i < this.Rooms.Length; i++)
            {
                if(this.Rooms[startIndex].Patient == null)
                {
                    this.Rooms[startIndex].Patient = pet;
                    return true;
                }

                if (startIndex < this.Rooms.Length / 2)
                {
                    startIndex = this.Rooms.Length / 2 + count;
                    count++;
                }
                else
                {
                    startIndex = this.Rooms.Length / 2 - count;
                }
            }
            return false;
        }

        public bool Release()
        {
            for (int i = this.Rooms.Length / 2; i < this.Rooms.Length; i++)
            {
                if (this.Rooms[i].Patient != null)
                {
                    this.Rooms[i].Patient = null;
                    return true;
                }
            }

            for (int i = 0; i < this.Rooms.Length / 2; i++)
            {
                if (this.Rooms[i].Patient != null)
                {
                    this.Rooms[i].Patient = null;
                    return true;
                }
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            return this.Rooms.Any(r => r.Patient == null);
        }

        public void Print()
        {
            Console.WriteLine(string.Join(Environment.NewLine, this.Rooms.ToList()));
        }

        public void Print(int id)
        {
            Console.WriteLine(this.Rooms[id-1]);
        }
    }
}

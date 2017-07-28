namespace _08.PetClinics.Models
{
    public class Room
    {
        public Room()
        {
            this.Patient = null;
        }

        public Pet Patient { get; set; }

        public override string ToString()
        {
            if (this.Patient == null)
            {
                return "Room empty";
            }

            return this.Patient.ToString();
        }
    }
}

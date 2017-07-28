namespace _08.PetClinics.Core
{
    using Models;
    using System.Collections.Generic;
    using System;
    using System.Linq;

    public class CommandInterpreter
    {
        private IList<Clinic> clinics;
        private IList<Pet> pets;

        public CommandInterpreter()
        {
            this.clinics = new List<Clinic>();
            this.pets = new List<Pet>();
        }

        public void Create(string[] input)
        {
            switch(input[0])
            {
                case "Pet": this.CreatePet(input[1], int.Parse(input[2]), input[3]); break;
                case "Clinic": this.CreateClinic(input[1], int.Parse(input[2])); break;
                default:
                    throw new InvalidOperationException("Invalid Operation!");
            }
        }

        private void CreateClinic(string name, int roomsCount)
        {
            this.clinics.Add(new Clinic(name, roomsCount));
        }

        private void CreatePet(string name, int age, string kind)
        {
            this.pets.Add(new Pet(name, age, kind));
        }

        public bool HasEmptyRooms(string[] input)
        {
            string name = input[0];
            return this.GetClinicByName(name).HasEmptyRooms();
        }

        private Clinic GetClinicByName(string name)
        {
            return this.clinics.First(c => c.Name == name);
        }

        public bool AddPet(string[] input)
        {
            string petName = input[0];
            string clinicName = input[1];

            Pet pet = this.pets.First(p => p.Name == petName);
            return this.GetClinicByName(clinicName).Add(pet);
        }

        public bool ReleasePet(string[] input)
        {
            string clinicName = input[0];
            return this.GetClinicByName(clinicName).Release();
        }

        public void Print(string[] arguments)
        {
            Clinic clinic = this.GetClinicByName(arguments[0]);
            if (arguments.Length == 1)
            {
                clinic.Print();
            }
            else if(arguments.Length == 2)
            {
                clinic.Print(int.Parse(arguments[1]));
            }
            else
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
        }
    }
}

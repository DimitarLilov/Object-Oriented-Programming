using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    public enum Gender
    {
        Male,
        Female
    }
    abstract class Animal : ISound
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Animal(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");

                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("Age cannot be a negative number"); 
                }
                this.age = value;
            }
        }
        public Gender Gender { get; set; }

        public abstract void ProduceSound();
    }
}

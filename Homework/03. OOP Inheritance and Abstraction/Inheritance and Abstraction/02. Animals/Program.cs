using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog("Rex", 7, Gender.Male),
                new Dog("Sara", 9, Gender.Female),
                new Dog("Lucky", 17, Gender.Male),
                new Dog("Lara", 1, Gender.Female)
            };

            List<Kitten> kittens = new List<Kitten>()
            {
                new Kitten("Pisana", 5),
                new Kitten("Roshla", 8),
                new Kitten("Kotka", 2),
                new Kitten("Kotka2", 3)
            };

            List<Tomcat> tomcats = new List<Tomcat>()
            {
                new Tomcat("Pisan", 7),
                new Tomcat("Pisan2", 7),
                new Tomcat("Tom", 7),
                new Tomcat("Pesho", 9)
            };

            List<Frog> frogs = new List<Frog>()
            {
                new Frog("Princ", 3, Gender.Male),
                new Frog("Razvrigor", 6, Gender.Male),
                new Frog("Gosho", 2, Gender.Male),
                new Frog("Razvrigorka", 4, Gender.Female)
            };

            CalculateAverageAge(dogs, "dog");
            CalculateAverageAge(kittens, "kitten");
            CalculateAverageAge(tomcats, "tomcat");
            CalculateAverageAge(frogs, "frog");
        }

        public static void CalculateAverageAge<T>(List<T> animals, string species)
        {
            var animalList = animals.Cast<Animal>().ToList();
            double averageAge =
                animalList
                .Average(animal => animal.Age);

            Console.WriteLine("Average {0}s age: {1:F1}", species, averageAge);
        }
    }
}


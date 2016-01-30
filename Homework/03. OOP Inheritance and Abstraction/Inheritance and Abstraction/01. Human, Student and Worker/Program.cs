using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Human__Student_and_Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Pesho" , "Peshkov", "1257g"),
                new Student("Gosho" , "Goshev", "5981s"),
                new Student("Razvrigor" , "Popov", "4837h"),
                new Student("Stamat" , "Stamatov", "2814k"),
                new Student("Petkan" , "Nedelchev", "1111f"),
                new Student("Zlatko" , "Srebrinov", "9966l"),
                new Student("Ina" , "Ivanova", "7735r"),
                new Student("Delqn" , "Peevski", "6205t"),
                new Student("Baharii" , "Zaharov", "3905o"),
                new Student("Veselin" , "Marinov", "9456u")
            };
            List<Worker> workers = new List<Worker>(){
                new Worker("Ivan", "Ivanov", 4000, 4),
                new Worker("Georgi", "Georgiev", 6669, 7),
                new Worker("Mitko", "Mitkov", 200000,6),
                new Worker("Geri", "Nikol", 696969, 1),
                new Worker("Manol", "Manolov", 90000, 4),
                new Worker("Slavi", "Slavkov", 600000, 9),
                new Worker("Cvetan", "Vasilev", 5243534, 5),
                new Worker("Vasil", "Vasilev", 32625, 6),
                new Worker("Dancho", "Danchev", 75674, 3),
                new Worker("Stanko", "Zlatev", 234647, 7)
            };
            var sortedStudents =
                students
                .OrderBy(student => student.FacultyNumber);

            foreach (Student student in sortedStudents)
            {
                Console.WriteLine("Name: {0} {1}, Faculty Number: {2}",
                    student.FirstName, student.LastName, student.FacultyNumber);
            }
            Console.WriteLine();

            var sortedWorkers =
                workers
                .OrderByDescending(worker => worker.MoneyPerHour());

            foreach (Worker worker in sortedWorkers)
            {
                Console.WriteLine("Name: {0} {1}, Week Salary: {2}, Work Hours Per Day: {3}",
                    worker.FirstName, worker.LastName, worker.WeekSalary, worker.WorkHoursPerDay);
            }
            Console.WriteLine();
            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            var sortedHumans =
                humans
                .OrderBy(human => human.FirstName)
                .ThenBy(human => human.LastName);

            foreach (Human human in sortedHumans)
            {
                Console.WriteLine("Name: {0} {1}", human.FirstName, human.LastName);
            }
            Console.WriteLine();
        }
    }
}

using _03.Company_Hierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy
{
    class Program
    {
        static void Main()
        {
            Sale phone = new Sale("Apple", new DateTime(2014, 12, 02), 850);
            Sale laptop = new Sale("Asus", new DateTime(2013, 03, 04), 1250);
            Sale graphicsCard = new Sale("Nvidia", new DateTime(2014, 11, 11), 450);
            Sale bike = new Sale("BMX", new DateTime(2014, 12, 12), 650);
            Sale dumbbells = new Sale("Smart bells", new DateTime(2011, 05, 27), 50);

            List<Sale> electronics = new List<Sale>();
            electronics.Add(phone);
            electronics.Add(laptop);
            electronics.Add(graphicsCard);

            List<Sale> sports = new List<Sale>();
            sports.Add(bike);
            sports.Add(dumbbells);

            SalesEmployee maria = new SalesEmployee("014", "Pesho", "Peshkov", 9400, Department.Accounting, electronics);
            SalesEmployee david = new SalesEmployee("015", "Gosho", "Goshev", 6900, Department.Sales, sports);

            List<Employee> salesExperts = new List<Employee>();
            salesExperts.Add(maria);
            salesExperts.Add(david);

            Manager george = new Manager("005", "Baharii", "Zaharov", 4300, Department.Marketing, salesExperts);

            Project companyMobileApp = new Project("Company Mobile App", new DateTime(2014, 04, 03), State.Closed);
            Project antiHackingTool = new Project("Anti Hacking Tool", new DateTime(2014, 12, 03), State.Open);

            List<Project> importantProjects = new List<Project>();
            importantProjects.Add(antiHackingTool);
            importantProjects.Add(companyMobileApp);


            Developer mikey = new Developer("004", "Razvrigor", "Razvrigorov", 5000, Department.Production, importantProjects);

            List<Employee> employees = new List<Employee>();
            employees.Add(maria);
            employees.Add(david);
            employees.Add(george);
            employees.Add(mikey);

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
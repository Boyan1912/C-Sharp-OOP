/*
   Problem 2. Students and workers

    Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
    Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
    Initialize a list of 10 workers and sort them by money per hour in descending order.
    Merge the lists and sort them by first name and last name.
*/
namespace _02_StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            List<Student> students = new List<Student>()
            {
                new Student("Autumn", "George",rnd.Next(1, 6)),
                new Student("Sondra", "Striplin",rnd.Next(1, 6)),
                new Student("Winona", "Kimmell",rnd.Next(1, 6)),
                new Student("Afton", "Stecher",rnd.Next(1, 6)),
                new Student("Minna", "Krahn",rnd.Next(1, 6)),
                new Student("Sharie", "Becnel",rnd.Next(1, 6)),
                new Student("Leif", "Haubert",rnd.Next(1, 6)),
                new Student("Maryellen", "Garson",rnd.Next(1, 6)),
                new Student("Rich", "Mccune",rnd.Next(1, 6)),
                new Student("Dayle", "Wixon",rnd.Next(1, 6)),
            };

            var sorted = from st in students
                         orderby st.Grade
                         select st;
            foreach (var st in sorted)
            {
                Console.WriteLine("{0} {1} Grade: {2, 5}", st.FirstName, st.LastName, st.Grade);
            }

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Dayle", "Bolenbaugh", rnd.Next(1000), rnd.Next(10, 50), rnd.Next(2, 30)),
                new Worker("Erich", "Platter", rnd.Next(1000), rnd.Next(10, 50), rnd.Next(2, 30)),
                new Worker("Myrna", "Mcnatt", rnd.Next(1000), rnd.Next(10, 50), rnd.Next(2, 30)),
                new Worker("Eboni", "Juares", rnd.Next(1000), rnd.Next(10, 50), rnd.Next(2, 30)),
                new Worker("Fredrick", "Hamada", rnd.Next(1000), rnd.Next(10, 50), rnd.Next(2, 30)),
                new Worker("Cornelius", "Laffoon", rnd.Next(1000), rnd.Next(10, 50), rnd.Next(2, 30)),
                new Worker("Earle", "Dodrill", rnd.Next(1000), rnd.Next(10, 50), rnd.Next(2, 30)),
                new Worker("Epifania", "Laycock", rnd.Next(1000), rnd.Next(10, 50), rnd.Next(2, 30)),
                new Worker("Karlyn", "Ebert", rnd.Next(1000), rnd.Next(10, 50), rnd.Next(2, 30)),
                new Worker("Maybell", "Nathanson", rnd.Next(1000), rnd.Next(10, 50), rnd.Next(2, 30)),

            };

            Console.WriteLine(new string('-', 30));

            var sortedWorkers = workers.OrderBy(x => x.MoneyPerHour());

            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine("{0} {1} - Money per Hour: {2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }

            Console.WriteLine(new string('-', 30));

            List<Human> people = new List<Human>();

            people.AddRange(students);
            people.AddRange(workers);

            var peopleByName = people.OrderBy(x => x.FirstName)
                                     .ThenBy(x => x.LastName);

            foreach (var person in peopleByName)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }

        }
    }
}

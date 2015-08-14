using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    class Program
    {

        static void Main(string[] args)
        {
            // Problem 1
            var builder = new StringBuilder("this is extension");
            Console.WriteLine(builder.SubString(1, 9));

            // Problem 2
            var array = new int[] { 1, 2, 5, 12, 10, 5 };
            Console.WriteLine(IEnumerableExtensions.Sum(array));

            var arrDouble = new double[] { 6.7, 5.2, 1.55 };
            Console.WriteLine(IEnumerableExtensions.Product(arrDouble));

            var arr = new string[] { "Pesho", "Sasho", "Bobo" };
            Console.WriteLine(IEnumerableExtensions.Max(arr));

            var average = new double[] { 3.1, 1.5, 1.5, 0.8 };
            Console.WriteLine(average.Average());

            Console.WriteLine(new string('-', 20));

            // Problem 3
            var students = new Student[] 
            {
            new Student("Pesho", "Mladenov"), 
            new Student("Gonzo", "Bonev"), 
            new Student("Wolf", "Balkanski"),
            new Student("Boiko", "Kirov"),
            new Student("Hristo", "Danchev"), 
            new Student("Ana", "Petrova"), 
            new Student("Boiko", "Borisov"), 
            new Student("Alexander", "Ivanov") 
            };

            var firstNamebeforeLast = from st in students 
                                      where st.FirstName.CompareTo(st.LastName) < 0 
                                      select st;

            foreach (var st in firstNamebeforeLast)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }

            // Problem 4
            Console.WriteLine(new string('-', 20));

            int age = 15;
            for (int i = 0; i < students.Length; i++)
            {
                students[i].Age = age;
                age += 4;
            }

            var youngStudents = from st in students 
                                where st.Age >= 18 && st.Age <= 24 
                                select st;

            foreach (var st in youngStudents)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }

            Console.WriteLine(new string('-', 20));
        
            // Problem 5  
            // lambda
            var orderedStudents = students
                .OrderByDescending(x => x.FirstName)
                .ThenByDescending(x => x.LastName);
         
            foreach (var st in orderedStudents)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }

            Console.WriteLine(new string('-', 20));

            // LINQ
            var orderedStudentsLINQ = from st in students
                                      orderby st.FirstName descending,
                                      st.LastName descending
                                      select st;
                                      
            foreach (var st in orderedStudentsLINQ)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }

            Console.WriteLine(new string('-', 20));

            // Problem 6
            // lambda
            var intArray = new int[100];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i;
            }

            var result = intArray.Where(x => x % 7 == 0 && x % 3 == 0 && x != 0);
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }

            // LINQ
            Console.WriteLine(new string('-', 20));

            var resultLINQ = from number in intArray
                             where number % 7 == 0 && number % 3 == 0 && number != 0
                             select number;

            foreach (var number in resultLINQ)
            {
                Console.WriteLine(number);
            }

            // Problem 7

            Console.WriteLine(new string('-', 20));

            var timer = new Timer(DateTime.Now, 10, Timer.PrintTime);

            // Problem 9
            Console.WriteLine(new string('-', 20));

            Random rnd = new Random();
            var listStudents = new List<Student>();
            for (int i = 0; i < students.Length; i++)
            {
                students[i].FN = rnd.Next(9999999).ToString();
                students[i].Telephone = "0" + rnd.Next(2, 5).ToString() + rnd.Next(9999999).ToString();
                students[i].GroupNumber = rnd.Next(1, 4);
                students[i].Marks.Add(rnd.Next(2, 7));
                students[i].Marks.Add(rnd.Next(2, 7));
                students[i].Marks.Add(rnd.Next(2, 7));
                students[i].Marks.Add(rnd.Next(2, 7));
                students[i].Email = students[i].FirstName + "@" + "abv.bg";
                listStudents.Add(students[i]);

            }
            var groupTwoStudents = from st in listStudents
                                   orderby st.FirstName
                                   where st.GroupNumber == 2
                                   select st;
                                   
            foreach (var student in groupTwoStudents)
            {
                Console.WriteLine("Group {2}: {0} {1}", student.FirstName, student.LastName, student.GroupNumber);
            }
            
            // Problem 10

            Console.WriteLine(new string('-', 20));

            var groupTwoStudentsWithMethod = listStudents.ExtractOrderedStudents(2);

            foreach (var st in groupTwoStudentsWithMethod)
            {
                Console.WriteLine("Group {2}: {0} {1}", st.FirstName, st.LastName, st.GroupNumber);
            }
      
            // Problem 11

            Console.WriteLine(new string('-', 20));

            students[2].Email = @"othermail@gmail.com";
            students[5].Email = @"somethingDifferent@gyuvetch.com";

            var studentsByEmail = from st in listStudents
                                  where st.Email.Substring(st.Email.IndexOf('@') + 1, st.Email.Length - st.Email.IndexOf('@') - 1) == "abv.bg"
                                  select st;
        
            foreach (var st in studentsByEmail)
            {
                Console.WriteLine("{0}: {1} {2}", st.Email, st.FirstName, st.LastName);
            }
     
            // Problem 12

            Console.WriteLine(new string('-', 20));

            var studentsByPhone = from st in listStudents
                                  where st.Telephone.StartsWith("02")
                                  select st;
            foreach (var st in studentsByPhone)
            {
                Console.WriteLine("Telephone: {0} - {1} {2}", st.Telephone, st.FirstName, st.LastName);
            }

            // Problem 13

            Console.WriteLine(new string('-', 20));

            var anonymous = from st in listStudents
                            where st.Marks.Any(x => x == 6)
                            select new { Name = st.FirstName + " " + st.LastName, Marks = st.Marks };


            Console.WriteLine("Students who have at least one excellent mark:");
            foreach (var st in anonymous)
            {
                Console.WriteLine("{0} ; Marks: {1}", st.Name, string.Join(", ", st.Marks));
            }

            // Problem 14

            Console.WriteLine(new string('-', 20));

            foreach (var student in listStudents)
            {
                for (int i = 0; i < rnd.Next(0, student.Marks.Count); i++)
                {
                    student.Marks.RemoveAt(i);      // removes randomn number of marks
                }

            }

            var studentsWithTwoMarks = from st in listStudents
                                       where st.Marks.Count == 2
                                       select st;

            foreach (var st in studentsWithTwoMarks)
            {
                Console.WriteLine("{0} {1} ; Marks: {2}", st.FirstName, st.LastName, string.Join(", ", st.Marks));
            }

            // Problem 15
            Console.WriteLine(new string('-', 20));

            listStudents[5].FN = "7024068";
            listStudents[1].FN = "6470068";

            var marksStudents2006 = from st in listStudents
                                    where st.FN[4] == '0' && st.FN[5] == '6'
                                    select st;

            foreach (var st in marksStudents2006)
            {
                Console.WriteLine("{0} {1} : {2} FN: {3}", st.FirstName, st.LastName, string.Join(", ", st.Marks), st.FN);
            }

            // Problem 17
            Console.WriteLine(new string('-', 20));

            string[] words = "Write a program to return the string with maximumLength from an array of strings.Use LINQ.".Split(' ', '.', ',', '!', '-', '?', ':', '(', ')', '"');

            var maxLength = words.OrderBy(x => x.Length).Last();

            Console.WriteLine(maxLength);

            // Problem 18
            Console.WriteLine(new string('-', 20));

            var groupedStudents = listStudents.GroupBy(x => x.GroupNumber).OrderBy(x => x.Key);

            foreach (var group in groupedStudents)
            {
                Console.WriteLine("Group Number: {0}", group.Key);
                foreach (var st in group)
                {
                    Console.WriteLine("{0} {1} - age: {2}, marks: {3}, FN: {4}, telephone: {5}, E-mail: {6}", st.FirstName, st.LastName, st.Age, string.Join(", ", st.Marks), st.FN, st.Telephone, st.Email);

                }
                Console.WriteLine();
            }

            Console.WriteLine(new string('-', 20));
            // Problem 19

            var groups = listStudents.Group();

            for (int i = 0; i < groups.Length; i++)
            {
                Console.WriteLine("Group # {0}", i + 1);
                foreach (var st in groups[i])
                {
                    Console.WriteLine("{0} {1} - age: {2}, marks: {3}, FN: {4}, telephone: {5}, E-mail: {6}", st.FirstName, st.LastName, st.Age, string.Join(", ", st.Marks), st.FN, st.Telephone, st.Email);
                }

                Console.WriteLine();
            }
        }

      

    }
}

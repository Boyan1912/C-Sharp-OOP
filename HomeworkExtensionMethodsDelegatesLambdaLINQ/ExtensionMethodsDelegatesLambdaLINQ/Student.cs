using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    /*
    Problem 3. First before last

    Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
    Use LINQ query operators.

     * Problem 4. Age range

    Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
     
     * Problem 5. Order students

    Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
    Rewrite the same with LINQ.

     * Problem 9. Student groups

    Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
    Create a List<Student> with sample students. Select only the students that are from group number 2.
    Use LINQ query. Order the students by FirstName.

     * Problem 10. Student groups extensions

    Implement the previous using the same query expressed with extension methods.

*/

    public class Student 
    {
        private string firstName;
        private string lastName;
        private int age;
        private List<int> marks = new List<int>();

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Student(string firstName, string lastName, int age)
            : this(firstName, lastName)
        {
            this.age = age;
        }

        public string FirstName 
        { 
            get
            {
                return this.firstName;
            }
                
                set
            {
                this.firstName = value;
            }
                
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = value;
            }

        }
        public int Age 
        { 
            get
            { return this.age; }

            set
            {
                this.age = value;
            }
        
        }
        public string FN { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }

        public List<int> Marks 
        { 
            get
            {
                return this.marks;
            }
            
            set
            {
                this.marks.AddRange(Marks);
            }    
        }

        public int GroupNumber { get; set; }

        // Problem 10
      



    }

}

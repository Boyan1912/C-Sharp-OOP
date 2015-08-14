using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_03_StudentClass
{
    class Student : ICloneable, IComparable<Student>
    {




        public string FirstName { get; set; }

        public string SecondName { get; set; }
        public string LastName { get; set; }

        public ulong SSN { get; set; }

        public string Address { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public string Course { get; set; }

        public University University { get; set; }

        public Specialty Language { get; set; }

        public Faculty Faculty { get; set; }

        public override bool Equals(object obj)
        {
            
            Student comparer = obj as Student;

            if (this.FirstName == comparer.FirstName && this.SecondName == comparer.SecondName && this.LastName == comparer.LastName
                && this.SSN == comparer.SSN && this.University == comparer.University && this.Faculty == comparer.Faculty &&
                this.Course == comparer.Course)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {

            return string.Format("{0} {1} {2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}\n{10}", this.FirstName, this.SecondName, this.LastName,
                this.Address, this.Email, this.MobilePhone, this.SSN, this.University, this.Faculty, this.Language);
            
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.SecondName.GetHashCode() ^ this.LastName.GetHashCode();
        }

        public static bool operator ==(Student one, Student two)
        {
            if (one.Equals(two))
            {
                return true;
            }
            return false;

        }
        
        public static bool operator !=(Student one, Student two)
        {
            return !one.Equals(two);

        }


        public object Clone()
        {
            Student result = new Student();

            result.FirstName = this.FirstName;
            result.SecondName = this.SecondName;
            result.LastName = this.LastName;
            result.Address = this.Address;
            result.Course = this.Course;
            result.Email = this.Email;
            result.Faculty = this.Faculty;
            result.Language = this.Language;
            result.MobilePhone = this.MobilePhone;
            result.SSN = this.SSN;
            result.University = this.University;

            return result;

        }

        
        public int CompareTo(Student other)
        {
            int result = this.FirstName.CompareTo(other.FirstName);

            if (result == 0)
            {
                result = this.SecondName.CompareTo(other.SecondName);

                if (result == 0)
                {
                    result = this.LastName.CompareTo(other.LastName);

                    if (result == 0)
                    {

                        if (this.SSN < other.SSN)
                        {
                            result = -1;
                        }
                        else if (this.SSN > other.SSN)
                        {
                            result = 1;
                        }
                        else
                        {
                            result = 0;
                        }
                    }

                }
            }

            return result;
        }
    }
}

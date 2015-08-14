using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SchoolClasses
{
    public class SchoolClass : ICommentary
    {
        private List<Teacher> teachers;
        private string identity;
        private static List<string> uniqueIDs = new List<string>();
        private List<Student> students;

        public SchoolClass(string id)
        {
            if (uniqueIDs.Contains(id))
            {
                throw new ArgumentException("Each School Class must have a unique text identifier!");
            }

            this.identity = id;
            uniqueIDs.Add(id);
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
        
        }
        public string ID
        {
            get
            {
                return this.identity;
            }
        
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
        }


        public string Comment { get; set; }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
            teacher.Teach(this);
        }
     
        public void AddStudent(Student st)
        {
            this.students.Add(st);
        }

        public void AddComment(string text)
        {
            this.Comment = text;
        }
    }
}

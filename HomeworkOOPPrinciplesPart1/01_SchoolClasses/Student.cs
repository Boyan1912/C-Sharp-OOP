using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SchoolClasses
{
    public class Student : Person, ICommentary
    {
        
        private static int classNumber = 0;
        private int studentNumber;

        public Student(string name) : base(name)
        {
            
            classNumber++;  // for uniqueness
            this.studentNumber = classNumber;
        }
       
        public int StudentNumber
        {
            get
            {
                return this.studentNumber;
            }
        }

        public string Comment { get; set; }

        public void AddComment(string text)
        {
            this.Comment = text;
        }
    }
}

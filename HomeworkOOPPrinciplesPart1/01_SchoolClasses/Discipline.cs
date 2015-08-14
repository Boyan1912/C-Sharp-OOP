using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_SchoolClasses
{
   public class Discipline : ICommentary
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private List<Teacher> teachers;


        public Discipline(string name)
        {
            this.name = name;
            this.teachers = new List<Teacher>();
        }

        public int NumberOfLectures 
        {
            get
            {
                return this.numberOfLectures;
            }    
            set
            {
                this.numberOfLectures = value;
            }
        
        }
        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                this.numberOfExercises = value;
            }
        }
        
       public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }

        }

        public string Comment { get; set; }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
            teacher.Teach(this);
        }

        public void AddComment(string text)
        {
            this.Comment = text;
        } 
   
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_SchoolClasses
{
    class Teacher : Person, ICommentary
    {
        private List<Discipline> disciplines = new List<Discipline>();

        public Teacher(string name) : base(name)
        {
            this.disciplines = new List<Discipline>();
        }


        public string Name
        {
            get
            {
                return this.name;
            }
        set
            {
                this.name = Name;
            }
        
        }
        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }

        }

        public string Comment { get; set; }

        public void Teach(Discipline discip)
        {
            disciplines.Add(discip);
            discip.AddTeacher(this);
        }
        public void Teach(SchoolClass clas)
        {
            clas.AddTeacher(this);

        }

        public void AddComment(string text)
        {
            this.Comment = text;
        }
    
    
    }
}

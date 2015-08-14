using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SchoolClasses
{
   public class School
    {
        private string name;
        private List<SchoolClass> schoolClasses;

        public School(string name, params SchoolClass[] classes)
        {
            this.name = name;
            this.schoolClasses = new List<SchoolClass>();
            this.schoolClasses.AddRange(classes);
        }


        public List<SchoolClass> SchoolClasses
        {
            get
            {
                return this.schoolClasses;
            }
        }

        public void AddSchoolClass(SchoolClass clas)
        {
            schoolClasses.Add(clas);
        }


    }
}

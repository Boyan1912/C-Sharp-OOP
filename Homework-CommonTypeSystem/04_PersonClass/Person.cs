using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PersonClass
{
    class Person
    {
        private string name;
        private int? age;



        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }



        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }

                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }

        }


        public override string ToString()
        {
            if (this.Age == null)
            {
                return string.Format("Name: {0}\nAge: {1}", this.Name, "Age not specified");
            }

            return string.Format("Name: {0}\nAge: {1}", this.Name, this.Age);

        }


    }
}

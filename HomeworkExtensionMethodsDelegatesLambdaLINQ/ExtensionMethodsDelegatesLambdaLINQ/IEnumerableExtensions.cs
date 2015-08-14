using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDelegatesLambdaLINQ
{/*
    Problem 2. IEnumerable extensions

    Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
*/
    public static class IEnumerableExtensions
        
    {

        public static T Sum<T>(this IEnumerable<T> collection)
        {
            dynamic sum = default(T);

            try
            {
                foreach (T item in collection)
                {
                    sum += item;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid operation for this type of data!");
            }
            return (T)sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            dynamic product = default(T);

            try
            {
                product += 1;
                foreach (T item in collection)
                {
                    product *= item;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid operation for this type of data!");
            }
            return (T)product;
        }
        public static T Min<T>(this IEnumerable<T> collection)
        {
            dynamic min = default(T);

            try
            {

                foreach (var item in collection)
                {
                    if (item < min)
                    {
                        min = item;
                    }
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid operation for this type of data!");
            }

            return (T)min;
        }
        public static T Max<T>(this IEnumerable<T> collection)
        {
            dynamic max = default(T);

            try
            {
                foreach (var item in collection)
                {
                    if (item > max)
                    {
                        max = item;
                    }
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid operation for this type of data!");
            }

            return (T)max;
        }
    
        public static T Average<T>(this IEnumerable<T> collection)
        {
            dynamic sum = default(T);
            T result = default(T);
            int count = 0;
            try
            {
                foreach (var item in collection)
                {
                    sum += item;
                    count++;

                }
                result = sum / count;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid operation for this type of data!");
            }

            return result;

        }
        // Problem 10
        public static IEnumerable<Student> ExtractOrderedStudents(this IEnumerable<Student> students, int n)
        {
            var listGroup = new List<Student>();
            foreach (var student in students)
            {
                if (student.GroupNumber == n)
                {
                    listGroup.Add(student);

                }
            }

            for (int i = 0; i < listGroup.Count - 1; i++)
            {
                if (listGroup[i].FirstName.CompareTo(listGroup[i + 1].FirstName) > 0)
                {
                    listGroup.Add(listGroup[i]);
                    listGroup.Remove(listGroup[i]);
                }

            }
            return listGroup;

        }

        // Problem 19
        public static List<Student>[] Group(this IEnumerable<Student> students)
        {
            int maxGroup = 0;
            foreach (Student st in students)
            {
                if (st.GroupNumber > maxGroup)
                {
                    maxGroup = st.GroupNumber;
                }
            }

            List<Student>[] groups = new List<Student>[maxGroup];

            for (int i = 0; i < groups.Length; i++)
            {
                groups[i] = new List<Student>();  // initialising objects or else it throws a Null reference exceprion
            }

            foreach (Student st in students)
            {
                groups[st.GroupNumber - 1].Add(st);    
            }
            return groups;
        
        }
    
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    class GenericList<T>
        where T : IComparable
    {

        private T[] listElements;
        private const int defaultCapacity = 4;

        public GenericList()
        {
            this.Capacity = defaultCapacity;
            this.listElements = new T[Capacity];

        }


        public int Count { get; set; }
        public int Capacity { get; set; }

        public T this[int index]
        {
            get 
            {
                if (index >= Count || index < 0)
                {
                   throw new IndexOutOfRangeException();
                }

                return this.listElements[index]; 
            }

            set 
            { 
                if (index >= Count || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                this.listElements[index] = value;
            }

        }

      
    
        public void AddElement(T element)
        {

            if (this.Count == this.Capacity)
            {
                this.Capacity *= 2;
                T[] oldList = this.listElements;
                this.listElements = new T[Capacity];
                Array.Copy(oldList, this.listElements, Count);

            }

            this.listElements[Count] = element;
            this.Count++;


        }
    
        public T AccessElement(int index)
        {
            return this.listElements[index];

        }
    
        public void RemoveElementAt(int index)
        {
            
            for (int i = index; i < this.Count; i++)
            {
                this.listElements[i] = default(T);
                this.listElements[i] = listElements[i + 1];
                listElements[i + 1] = default(T);
            }

            this.Count--;
            

        }
    
        public void InsertElementAt(int index, T element)
        {
            this.AddElement(element);
            T temp = default(T);

            for (int i = this.Count - 1; i > index; i--)
            {
                temp = this.listElements[i];
                this.listElements[i] = this.listElements[i - 1];
                this.listElements[i - 1] = temp;
            }


        }

        public void ClearList()
        {
            for (int i = 0; i < this.Count; i++)
            {
                this.listElements[i] = default(T);

            }

            this.Count = 0;
            this.Capacity = defaultCapacity;
        }
   
        public int FindElementByValue(T value)
            
        {
     
            for (int i = 0; i < this.Count; i++)
            {
                if (value.Equals(this.listElements[i]))
                {
                    return i;
                    
                }
     
            }
     
            return -1;
        }

        public T Min()
        {
            T bestValue = this.listElements[0];

            for (int i = 1; i < Count; i++)
            {
                if (this.listElements[i].CompareTo(bestValue) < 0)
                {
                    bestValue = this.listElements[i];

                }
            }
            return bestValue;
        }


        public T Max()
        {
            T bestValue = default(T);
            for (int i = 0; i < Count; i++)
            {
                if (this.listElements[i].CompareTo(bestValue) > 0)
                {
                    bestValue = this.listElements[i];

                }
            }
            return bestValue;
        }




        public override string ToString()
        {
            var builder = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                builder.Append(this.listElements[i] + ", ");
            }
            return builder.ToString().Trim(' ', ',');
        }


      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_64BitArray
{
    class BitArray64 : IEnumerable<int>
    {

        private ulong number;


        public BitArray64(ulong number)
        {
            this.Number = number;
        }


        public ulong Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;    
            }
        }

        public byte this[int index]
        {
            get
            {
                if (index < 0 || index > 64)
                {
                    throw new IndexOutOfRangeException("Index must be within the 64 bit array!");
                }
                ulong mask = 1;
                mask <<= index;
                mask &= this.Number;
                mask >>= index;
                return (byte)mask;
            }
            set
            {
                if (value != 0 && value != 1)
                {
                    throw new ArgumentException("A bit value can only be 0 or 1 !");
                }

                if (value == 1)
                {
                    ulong mask = 1;
                    mask <<= index;
                    this.Number |= mask;

                }
                else if (value == 0)
                {
                    ulong mask = 1;
                    mask <<= index;
                    this.Number &= ~mask;
                }
            }
        }


        public IEnumerator<int> GetEnumerator()
        {
            
            for (int i = 64; i > 0; i--)
            {
                ulong mask = 1;
                mask <<= i - 1;
                mask &= this.Number;
                mask >>= i - 1;
                yield return (int)mask;
            }

        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


        public override bool Equals(object obj)
        {
            var other = obj as BitArray64;
            if (this.Number == other.Number)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {

            return this.Number.GetHashCode();
        }

       public static bool operator ==(BitArray64 one, BitArray64 another)
       {
           if (one.Number == another.Number)
           {
               return true;
           }

           return false;
       }
    
     public static bool operator !=(BitArray64 one, BitArray64 another)
       {
           return !(one == another);
       }


    }
}

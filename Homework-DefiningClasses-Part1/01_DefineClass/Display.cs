
namespace DefineClasses
{
    using System;
    public class Display
    {
        private float size;
        private long numberOfColours;
        private const float minSize = 2;

        public Display(float sizeInInches, long couloursNumber)
        {
            this.Size = sizeInInches;
            this.NumberOfColours = couloursNumber;

        }

        public Display()
        {
        }

        public float Size 
        { get
            { return this.size; }
            
          set
            {
                if (value < minSize)
              {
                  throw new ArgumentOutOfRangeException("The display cannot be that small!");

              }
              this.size = value;
          
            }
        }
        public long NumberOfColours { get; set; }

    }
}
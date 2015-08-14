using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    class Matrix<T>
    {
        private T[,] listNumbers;

        public Matrix (int rows, int colls)
        {
            this.Count0 = rows;
            this.Count1 = colls;
            this.listNumbers = new T[rows, colls];
        }

        public int Count0 { get; set; }

        public int Count1 { get; set; }

        public T this[int row, int coll]
        {
            get
            {
                if (row < 0 || row > this.Count0 || coll < 0 || coll > Count1)
                {
                    throw new IndexOutOfRangeException("Index must be within reach!");

                }
                return this.listNumbers[row, coll];
            }
            set
            {
                if (row < 0 || row >= this.Count0 || coll < 0 || coll >= Count1)
                {
                    throw new IndexOutOfRangeException("Index must be within reach!");

                }

                this.listNumbers[row, coll] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            if (a.Count0 != b.Count0 || a.Count1 != b.Count1)
            {
                throw new ArithmeticException("Matrixes must have the same sizes in order to calculate their sum!");
            }

            var resultMatrix = new Matrix<T>(a.Count0, a.Count1);
            
            for (int i = 0; i < a.Count0; i++)
            {
                for (int j = 0; j < a.Count1; j++)
                {
                    resultMatrix[i, j] = (dynamic)a[i, j] + (dynamic)b[i, j]; // applying dynamic because we know "T" will be some sort of a number
                    
                }
                
            }
            return resultMatrix;
        }
    
        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
        {
            if (a.Count0 != b.Count0 || a.Count1 != b.Count1)
            {
                throw new ArithmeticException("Matrixes must have the same sizes in order to calculate their subtraction!");
            }

            var resultMatrix = new Matrix<T>(a.Count0, a.Count1);

            for (int i = 0; i < a.Count0; i++)
            {
                for (int j = 0; j < a.Count1; j++)
                {
                    resultMatrix[i, j] = Math.Abs((dynamic)(a[i, j])) - Math.Abs((dynamic)b[i, j]); // If it's not Math.Abs returns '-' minus '-' = '+'

                }

            }
            return resultMatrix;

        }
         public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
             if ((a.Count0 != b.Count0 && a.Count0 != b.Count1) || (a.Count1 != b.Count1 && a.Count1 != b.Count0))
             {
                throw new ArithmeticException("Matrixes must have equal dimension in order to be multiplied!");
             }

             int smallerDimension0 = 0;
             int biggerDimension1 = 0;
             bool aHasMoreRows = false;

             if (a.Count0 > b.Count0)
             {
                 aHasMoreRows = true;
                 smallerDimension0 = b.Count0;
             }
             else
             {
                 smallerDimension0 = a.Count0;
             }

             if (a.Count1 > b.Count1)
             {
                 biggerDimension1 = a.Count1;
                 
             }
             else
             {
                 biggerDimension1 = b.Count1;
                 
             }

             var resultMatrix = new Matrix<T>(smallerDimension0, biggerDimension1);

             for (int i = 0; i < smallerDimension0; i++)
             {

                 for (int j = 0; j < biggerDimension1; j++)
                 {

                     if (aHasMoreRows)
                     {

                         resultMatrix[i, j] = (dynamic)a[j, i] * (dynamic)b[i, j];
                     }

                     else
                     {
                         resultMatrix[i, j] = (dynamic)a[i, j] * (dynamic)b[j, i];
                     }

                 }
                 
             }
             return resultMatrix;
         
         }

         public static bool operator true(Matrix<T> matrix)
         {
             for (int i = 0; i < matrix.Count0; i++)
             {
                 for (int j = 0; j < matrix.Count1; j++)
                 {
                     if ((dynamic)matrix[i, j] == 0)
                     {
                         return false;
                     }

                 }
                 
             }
             return true;
         }

         public static bool operator false(Matrix<T> matrix)
         {
             for (int i = 0; i < matrix.Count0; i++)
             {
                 for (int j = 0; j < matrix.Count1; j++)
                 {
                     if ((dynamic)matrix[i, j] != 0)
                     {
                         return true;
                     }

                 }

             }
             return false;
         }
    
    }
}

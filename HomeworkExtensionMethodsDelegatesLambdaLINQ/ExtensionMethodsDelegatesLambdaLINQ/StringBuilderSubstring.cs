using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    /*
    Problem 1. StringBuilder.Substring

    Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
*/
    static class StringBuilderSubstring
    {

        public static StringBuilder SubString(this StringBuilder builder, int index, int length )
        {
            if (index + length >= builder.Length || index < 0)
            {
                throw new IndexOutOfRangeException("Index must be within reach!");
            }


            var result = new StringBuilder();
            for (int i = index; i <= length; i++)
            {
                result.Append(builder[i]);
                
            }
            return result;
        }



    }
}

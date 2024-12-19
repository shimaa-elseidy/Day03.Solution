using System.ComponentModel;
using System.Threading.Channels;

namespace Assign_04
{
    internal class Program
    {

        #region Q1 Value & Ref Functions
        /////////////By Ref//////////
        //static void GetPassingByRef(ref int X)
        //{
        //    X = 10;
        //}

        //static void GetPassingByValue( int X)
        //{
        //    X = 10;
        //} 
        #endregion
        #region Q2 Value & Ref Functions
        //static void GetPassingByRefByValue(int[] nums)
        //{
        //    nums[0] = 5;
        //    nums = new int[] { 7, 8, 9 };
        //    Console.WriteLine(string.Join(", ", nums));
        //}
        //static void GetPassingByRefByref(ref int[] nums)
        //{
        //    nums[0] = 5;
        //    nums = new int[] { 7, 8, 9 };
        //    Console.WriteLine(string.Join(", ", nums));
        //} 
        #endregion


        static void Main(string[] args)
        {
            #region Q1
            // 1 - Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example.
            /*
             When passing by value, a copy of the actual data is passed to the method or function. 
             This means that any changes made to the parameter inside the method do not affect the original data. 
            */
            /*
             passing by reference means that a reference to 
             the actual data is passed, allowing the method to modify 
             the original data.
            */
            //By Ref
            //int nums = 30;
            //GetPassingByRef(ref nums);
            //Console.WriteLine(nums);// output = 10 (original value of nums changed)
            //=============================================================================================================================
            //By Value
            //int nums = 30;
            //GetPassingByValue(nums);
            //Console.WriteLine(nums);// output = 30 (original value of nums does't change) 
            #endregion
            #region Q2
            // 2 - Explain the difference between passing(Reference type parameters) by value and by reference then write a suitable c# example.
            /*
             When passing by reference, the method receives a reference (memory address) to the original data.
             Changes made inside the method affect the original variable or object.
            */

            //int[] numbers = { 1, 2, 3 };

            // Passing reference type by value
            //GetPassingByRefByValue(numbers);
            //Console.WriteLine(string.Join(",",numbers));output 5,2,3

            // Passing reference type by Ref
            //GetPassingByRefByref(ref numbers);
            //Console.WriteLine(string.Join(",", numbers));
            #endregion

        }
    }
}
using System.ComponentModel;
using System.Security.Principal;
using System.Threading.Channels;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        #region Q3 Fn
        //static (int, int) sumsub(int a, int b, int c, int d)
        //{
        //    int sum = a + b;
        //    int sub = Math.Abs(d - c); //Math.Abs()=====>for Positive Value
        //    return (sum, sub);
        //}
        #endregion
        #region Q4 Fn
        //static int CalcSumOfDigit(int number)
        //{
        //    int sum = 0;
        //    number=Math.Abs(number);//For Positive Value
        //    while (number > 0)
        //    {
        //        sum += number % 10;   //hint =====%10 For Get The Last Digit === 25 % 10 = 5 ,  123 % 10 = 3.
        //        number /= 10;        //Hint ======For Remove The Last Digit  === 25 / 10 = 2   ,123 / 10 = 12.
        //    }
        //    return sum;
        //}


        //================================== Another Function By Two Inputs================================
        //static int Sum(int X, int Y, out int InputNumber)
        //{
        //    InputNumber = X + Y;
        //    return InputNumber;
        //}
        #endregion
        #region Q5 fn
        //static bool IsPrime(int num)
        //{   
        //    if (num <2)
        //    {
        //        return false;
        //    }
        //    for (int i = 2; i < Math.Sqrt(num); i++)
        //    {
        //        if (num % 2 == 0 )
        //        {
        //            return false;// kda even number
        //        }
        //    }
        //    return true;
        //}
        #endregion
        #region Q6 fn
        //static void MinMaxArray( int[] arr , ref int min ,ref int max)
        //{
        //     min = arr[0]; 
        //     max = arr[0]; 
        //    for (int i = 0; i < arr.Length; i++)
        //    {   
        //        if (arr[i] < min  )
        //        {
        //             min = arr[i] ;
        //        }
        //        if ( arr[i] > max)
        //        {
        //            max = arr[i];
        //        }
        //    }
        // Or==============================
        //foreach (var num in arr)
        //{
        //    if (num>max)
        //    {
        //        max = num;
        //    }
        //    else if (num>min)
        //    {
        //        min = num;
        //    }
        //}
        //}
        #endregion
        #region Q7 fn
        //static long CalcFactorial(int num)
        //{
        //    if (num == 0) return 1;//// If the number is 0, return 1 (because 0! = 1)
        //    long result = 1;
        //    for (int i = 1; i <= num; i++)
        //    {
        //        result *= i; 
        //    }
        //    return result;
        //}
        #endregion
        #region Q8 fn
        //static string ChangeChar(string input, int position, char newChar)
        //{   // Convert the string to a character array
        //    char[] charArray = input.ToCharArray();
        //    if (position==0)
        //    {
        //        charArray[position] = newChar;
        //    }

        //    else if
        //       ( position < 0 || position >= input.Length)
        //    {
        //        Console.WriteLine("Position is out of range.");
        //    }

        //    // Convert the character array back to a string
        //    return new string(charArray);//new as strin is immutable so i use new string
        //}
        #endregion
        #region Q10 fn
        //static void GetSumOfArray(int[] Arr,out int sum)
        //{
        //    sum=0;
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        sum += Arr[i];
        //    }
        //}
        #endregion
        #region Q11 fn
        //static void MergeArrays(int[] arr1, int[] arr2, out int[] result)
        //{

        //    if (arr1.Length == arr2.Length)
        //    {

        //        result = new int[arr1.Length + arr2.Length];
        //        arr1.CopyTo(result, 0);
        //        arr2.CopyTo(result, arr1.Length);
        //        Array.Sort(result);
        //    }
        //    else
        // { 
        //        Console.WriteLine("Error: Arrays must have the same size.");
        //        result = null;
        //}

        //}
        #endregion
        #region Q12 fn
        //static void FrequencyOfItemsInArray(int[] arr )
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {

        //        if (arr[i] == -1)
        //        {
        //            continue;
        //        }
        //        int count = 1;
        //        for (int j= i+1; j < arr.Length; j++)
        //        {
        //            if (arr[i] == arr[j])
        //            {
        //                count++; arr[j] = -1;
        //            }
        //        }
        //        Console.WriteLine($"Element {arr[i]} appears {count} times.");
        //    }

        //}
        #endregion
        #region Q13 fn
        //static void MaxMin(int[] arr)
        //{
        //    int max = arr[0];
        //    int min = arr[0];
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i]>max)
        //        {
        //            max = arr[i];
        //        }
        //        else if (arr[i]<min)
        //        {
        //            min = arr[i];
        //        }
        //    }
        //    Console.WriteLine("The maximum value is: " + max);
        //    Console.WriteLine("The minimum value is: " + min);
        //}

        //==========Another Solution========
        //static void MaxMin(int[] arr)
        //{
        //    Array.Sort(arr);
        //    int min = arr[0];
        //    int max = arr[arr.Length - 1];
        //    Console.WriteLine("The maximum value is: " + max);
        //    Console.WriteLine("The minimum value is: " + min);
        //}


        #endregion
        #region Q14 fn
        //static void SecMaxElement(int[] arr)
        //{
        //    Array.Sort(arr);
        //    int secMax = arr[arr.Length - 2];
        //    Console.WriteLine($"The second largest element is: {secMax}");
        //}
        #endregion
        #region Q17 fn 
        //static string[] GetReverse(string[] arr)
        //{
        //    Array.Reverse(arr);
        //    return arr;
        //}

        #endregion
        #region Q18 fn
        //static void CopyArray(int[,] Arr, int[,] SecArr)
        //{
        //    Array.Copy(Arr, SecArr, Arr.Length);
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
            #region Q3
            // 3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            // Taking input from the user  
            //Console.Write("Enter first number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter third number: ");
            //int num3 = int.Parse(Console.ReadLine());

            //Console.Write("Enter fourth number: ");
            //int num4 = int.Parse(Console.ReadLine());

            //(int sum, int Sub) = sumsub(num1, num2, num3, num4);

            //Console.WriteLine($"Sum of first two numbers: {sum}");
            //Console.WriteLine($"Difference of last two numbers: {Sub}");

            #endregion
            #region Q4
            /* 4 - Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
                   Output should be like
                   Enter a number: 25
                  The sum of the digits of the number 25 is: 7
            */
            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();
            //if (int.TryParse(input ,out int num))
            //{

            //    int digitSum = CalcSumOfDigit(num);

            //    // Display the result  
            //    Console.WriteLine($"The sum of the digits of the number {num} is: {digitSum}");
            //}
            //else
            //{ 
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}



            //================================== Another Solution By Two Inputs================================
            //int X = int.Parse(Console.ReadLine()), Y = int.Parse(Console.ReadLine()), InputNumber;
            //Sum(X, Y, out InputNumber);
            //Console.WriteLine($"Enter a number:{InputNumber}");
            #endregion
            #region Q5
            // 5-	Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.WriteLine("Enter An Number : ");
            //int number;
            //while (!int.TryParse(Console.ReadLine(), out number))
            //{
            //    Console.Write("Invalid input. Please enter a valid number: ");
            //}
            //if (IsPrime(number) == true)
            //{
            //    Console.WriteLine($"{number} is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not a prime number.");
            //}
            #endregion
            #region Q6
            //6 - Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //int min =0, max=0;
            //MinMaxArray( arr, ref min, ref max);
            //Console.WriteLine($" Min Value : {min}");
            //Console.WriteLine($" Max Value : {max}");
            #endregion
            #region Q7
            //7-	Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //Console.WriteLine("Enter A Number To Calculate The Factorial ");
            //int InputNum = int.Parse(Console.ReadLine());
            //if (InputNum < 0)
            //{
            //    Console.WriteLine("Factorial of negative numbers cannot be calculated.");
            //}
            //else
            //{
            //    long factorial = CalcFactorial(InputNum);
            //    Console.WriteLine($"The factorial of {InputNum} is: {factorial}");
            //}
            #endregion
            #region Q8
            /*
            8-	Create a function named "ChangeChar" to modify a letter in 
                a certain position (0 based) of a string, replacing it with a different letter
            */
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //Console.Write("Enter the position to modify (0-based): ");
            //int position = int.Parse(Console.ReadLine());

            //Console.Write("Enter the new character: ");
            //char newChar = Console.ReadLine()[0];

            //string modifiedString = ChangeChar(input, position, newChar);
            //Console.WriteLine($"Modified string: {modifiedString}");
            #endregion
            #region Q9
            /*
             9-	 Write a program that prints an identity matrix using for loop, 
                 in other words takes a value n from the user and shows the identity table of size n * n.
             */
            //  ****          Identity Matrix           ****
            //An identity matrix is a square matrix where:
            //All diagonal elements are 1.
            //All non-diagonal elements are 0.

            //Console.Write("Enter the size of the identity matrix (n): ");
            //int n;

            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.Write("Invalid input. Please enter a positive integer: ");
            //}

            //Console.WriteLine($"Identity Matrix of size {n} x {n}:\n");

            //// Generate and print the identity matrix
            //for (int i = 0; i < n; i++) 
            //{
            //    for (int j = 0; j < n; j++) 
            //    {
            //        if (i == j) 
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine(); 

            //}

            #endregion
            #region Q10
            // 10 - Write a program in C# Sharp to find the sum of all elements of the array.

            //int[] array = { 1, 2, 3, 4 };
            //int sum;
            //GetSumOfArray(array, out sum);
            //Console.WriteLine($"The Sum Of All Elements Of The Array: {sum}"); 
            #endregion
            #region 11
            // 11-	- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            // int[] arr1 = { 1, 2, 3 }, arr2 = { 4, 5, 6 }, result;
            //MergeArrays(arr1, arr2, out result);
            // Console.WriteLine("Merged and Sorted Array:");
            // foreach (var item in result)
            // {
            //     Console.Write(item + " ");
            // }
            #endregion
            #region Q12
            // 12-	 Write a program in C# Sharp to count the frequency of each element of an array
            //int[] arr = { 1, 2, 1, 7 };;

            //FrequencyOfItemsInArray(arr);

            #endregion
            #region Q13
            // 13-	 Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] nums = { 100, 22, 33, 99 };

            //MaxMin(nums);


            #endregion
            #region Q14
            //14 - Write a program in C# Sharp to find the second largest element in an array.
            //int[] nums = { 100, 28, 30, 44, 55, 99 };
            //SecMaxElement(nums);
            #endregion
            #region Q15,16
            //        Console.Write("Enter the number of elements: ");
            //        int n = int.Parse(Console.ReadLine());

            //        int[] array = new int[n];
            //        Console.WriteLine("Enter the elements (e.g., 1 2 3 1):");
            //        string[] inputs = Console.ReadLine().Split(' ');

            //        for (int i = 0; i < n; i++)
            //        {
            //            array[i] = int.Parse(inputs[i]);
            //        }

            //        int maxDistance = -1; // Start with a minimum value  

            //        // Look for pairs of equal elements  
            //        for (int i = 0; i < n; i++)
            //        {
            //            for (int j = i + 1; j < n; j++)
            //            {
            //                if (array[i] == array[j])
            //                {
            //                    int distance = j - i - 1; // Calculate the distance between the two equal elements  
            //                    if (distance > maxDistance)
            //                    {
            //                        maxDistance = distance; // Update if we found a larger distance  
            //                    }
            //                }
            //            }
            //        }

            //        Console.WriteLine("The longest distance between equal elements is: " + maxDistance);
            #endregion
            #region Q17
            // 17-	Given a list of space separated words, reverse the order of the words.

            //Console.WriteLine("Enter Text : ");
            //string input = Console.ReadLine();
            //string[] words = input.Split(' ');
            //string[] reversedWords = GetReverse(words);

            //Console.WriteLine("Reversed Text: " + string.Join(" ", reversedWords));
            #endregion
            #region Q18
            /* 18- Write a program to create two multidimensional arrays of same size.
                   Accept values from the user and store them in first array.
                   Now copy all the elements of the first array on second array and print second array.
            */
            //Console.WriteLine("Please, Enter the size of the arrays (rows and columns separated by space): ");
            //string[] sizeInput = Console.ReadLine().Split(' ');
            //int rows = int.Parse(sizeInput[0]);
            //int cols = int.Parse(sizeInput[1]);


            //int[,] firstArray = new int[rows, cols];
            //int[,] secondArray = new int[rows, cols];

            //Console.WriteLine("Enter values for the first array (space-separated): ");
            //for (int i = 0; i < rows; i++)
            //{
            //    string[] lineInput = Console.ReadLine().Split(' ');
            //    for (int j = 0; j < cols; j++)
            //    {
            //        firstArray[i, j] = int.Parse(lineInput[j]);
            //    }
            //}


            //CopyArray(firstArray, secondArray);


            //    Console.WriteLine("The second array is:");
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            Console.Write(secondArray[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}


            #endregion
        }  
    }
    }


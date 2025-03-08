//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;

//namespace _2ndPractice
//{
//    class ArraypractBice
//    {
//        //ArrayList vara = new ArrayList();

//        public int FindMinimum(int[] numbers)
//        {
//            if (numbers == null || numbers.Length == 0)
//                throw new ArgumentException("Array cannot be null or empty");

//            int min = numbers[0];
//            for (int i = 1; i < numbers.Length; i++)
//            {
//                if (numbers[i] < min)
//                {
//                    min = numbers[i];
//                }
//            }
//            return min;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Arraypractice arrayPractice = new Arraypractice();
//            int[] numbers = { 5, 3, 9, 1, 6 };
//            int min = arrayPractice.FindMinimum(numbers);
//            Console.WriteLine("The minimum number in the array is: " + min);
//        }
//    }
//}

using System;

namespace basic_thirteen
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (short i = 1; i <= 255; i++)
            // {
            //     Console.WriteLine(i);
            // }
            // for(short i = 1; i <= 255; i++)
            // {
            //     if(i%2 != 0)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }
            // short sum = 0;
            // for(short i = 1; i <=255; i++)
            // {
            //     Console.WriteLine(i);
            //     sum += i;
            // }
            // Console.WriteLine(sum);
            int[] nums = {1,-2,3,4,5};
            // numArr(nums);
            // printMax(nums);
            // avrg(nums);
            // arrOdd();
            // squareVal(nums);
            // greaterThanY(nums, 2);
            // zeroNegs(nums);
            // maxMinAvg(nums);
            // shiftArr(nums);
            shiftForreal(nums);
        }
        public static void numArr(int[] arr)
            {
                for(int i = 0; i<=arr.Length; i++)
                {
                    Console.WriteLine(i);
                }
            }
        public static void printMax(int[] arr)
        {
            int max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }
        public static void avrg(int[] arr)
        {
            int sum = 0;
            for(int i = 0 ; i<arr.Length; i++)
            {
                sum += arr[i];
            }
            int average = sum/arr.Length;
            Console.WriteLine(average);
        }
        public static void arrOdd()
        {
            int[] newarr = new int[128];
            int h = 0;
            for (int i = 1; i<256; i++)
            {
                if (i % 2 != 0)
                {
                    newarr[h] = i;
                    h++;
                } 
                
            }
            foreach(int x in newarr)
            {
                Console.WriteLine(x);
            }
        }   
        public static void squareVal(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i*i);
            }
        }
        public static void greaterThanY(int[] arr, int y)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > y)
                {
                    count ++;
                    Console.WriteLine(i);
                    Console.WriteLine(count);
                }
            }
        }
        public static int[] zeroNegs(int [] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = 0;
                }
            }return arr;
        }
        public static void maxMinAvg(int [] arr)
        {
            int min = arr[0];
            int max = arr[0];
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                sum += arr[i];
            }
            int avg = sum/arr.Length;
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(avg);
        }
        public static void shiftArr(int [] arr)
        {
            object [] newarr = new object [5];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                  newarr[i] = "dojo"; 

                }
                else {
                    newarr[i] = arr[i];
                }
            } 
            foreach(object x in newarr)
            {
                Console.WriteLine(x);
            }
        }
        public static int shiftForreal(int[] arr)
        {
            int[] newarr = new int[arr.Length];
            for(int i = arr.Length-2; i>=0; i--)
            {
                newarr[i] = arr[i+1];
            }
            foreach(int x in newarr)
            {
                Console.WriteLine(x);
            }
            return 5;
        }
    }   
}

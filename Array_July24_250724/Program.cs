using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Array_July24_250724
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //1 tech
            //int[] MyArray1 = new int[5];// 5 int array created
            //                            //  2nd              1st                   

            ////int x;
            ////x = 5;

            ////int y = 6;


            //////2 nd tech
            ////int[] MyArray2;
            ////int size1;
            ////Console.WriteLine("Enter size of Array:");
            ////size1 = int.Parse(Console.ReadLine());

            ////MyArray2 = new int[size1];//2000


            //Console.WriteLine("length= "+MyArray1.Length);
            //////print all elements from myArray1

            ////for (int i = 0; i < MyArray1.Length; i++)
            ////{
            ////    Console.WriteLine(MyArray1[i]);
            ////}

            ////how to access array elements

            ////1 randomaly
            //int x = 100;
            //MyArray1[2] = 999;

            //MyArray1[4] = -45;
            //Console.WriteLine(MyArray1[4]);

            //int ans = x + MyArray1[2];
            ////ans   = 1099;
            //Console.WriteLine(ans);//1099


            ////2 sequencially
            //Console.WriteLine("-------------------------");
            //int no;
            //for (int i = 0; i < 5; i++)//0  1   2    3   4   
            //{
            //    Console.WriteLine("Enter number");
            //    no = int.Parse(Console.ReadLine());
            //    MyArray1[i] = no;
            //}

            //Console.WriteLine("====All Array Elements are ====");
            //for (int i = 0;i<5;i++)
            //{
            //    Console.WriteLine(MyArray1[i]);
            //}

            #endregion

            // WAP to enter the five elements in array and calculate the sum of all elements

            int[] ArraySum = new int[5];
            int sum;
            int i;
            sum = 897;
            for (i = 0; i < ArraySum.Length; i++)
            {
                Console.WriteLine("Enter Array Element...");
                int n = int.Parse(Console.ReadLine());
                ArraySum[i] = n;
            }
            Console.WriteLine("All Array Elements are :");
            for (i = 0; i < ArraySum.Length; i++)
            {
                Console.WriteLine(ArraySum[i]);
            }

            sum = 0;
            for ( i = 0; i < ArraySum.Length; i++)
            {
                sum = sum + ArraySum[i];
            }

            Console.WriteLine("Sum ="+sum);
            Console.ReadKey();
        }
    }
}


//https://www.geeksforgeeks.org/c-sharp-arrays/
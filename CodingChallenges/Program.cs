using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    class Program
    {
        private static string i;

        /// <summary>
        /// Here goes your information: NAME, GITHUB LINK, ANY OTHER PROGILE PAGE SUCH AS LINKEDIN
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            // Here we will run our code
            ChallengeDay1();
            ChallengeDay2();

        }
        // Here we will create our static methods

        /// <summary>
        /// Task
        /// Given an integer, n, print its first 10 multiples.Each multiple n x i(where 1 <= i <= 10) 
        /// should be printed on a new line in the form: n x i = result.
        /// 
        /// a Single integer, n
        /// 
        /// Print 10 lines of output; each line i (where 1 <= i <= 10) contains the result of n x i 
        /// the form:
        /// n x i = result
        /// </summary>

        static void ChallengeDay1()

        {
            // write solution here - Wednesday
            // step 1 request mumber from user
            // step 2 iterate using for 1 <= i <= 10
            // (inside for) step 3 multiply n * 1
            // (inside for) step 4 print output " 2 x 1 = 2" (n x i = result)

            int num = 11;

            Console.WriteLine("Enter a Number: ");
            num = Convert.ToInt16(Console.ReadLine());

            if (num < 2 || num > 10)
            {
                Console.WriteLine("This number not Value.");
                ChallengeDay1();
            }


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " X " + i + " = " + (num * i));
            }

            ChallengeDay1();
            Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        static void ChallengeDay2()
        {
            int[] arr = { 2, 4, 6, 2, 5 };
            int i;
            int j;


            for (i = 0; i < arr.Length; i++)
            {

                int value = arr[i];

                for (j = i + 2; j < arr.Length; j = j + 2)
                {
                    value = value + arr[j];

                }

                Console.WriteLine(value.ToString());

            }
            Console.ReadKey();
        }


    }
}

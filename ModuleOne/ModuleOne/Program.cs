using System;

namespace ModuleOne
{
    /// <summary>
    /// classOne.
    /// </summary>
    internal class Program
    {
#pragma warning disable SA1614 // Element parameter documentation should have text
        /// <summary>
        /// main.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
#pragma warning restore SA1614 // Element parameter documentation should have text
        {
            int countEven = 0;
            int countOdd = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            int[] vs = new int[n];
            for (int i = 0; i < vs.Length; i++)
            {
                vs[i] = new Random().Next(1, 26);
                if (vs[i] % 2 == 0)
                {
                    countEven++;
                }

                if (vs[i] % 2 != 0)
                {
                    countOdd++;
                }
            }

            Console.WriteLine(countOdd);
            Console.WriteLine(countEven);

            int[] evenArr = new int[countEven]; // заполняем чётными
            int[] oddArr = new int[countOdd]; 

            // for (int i = 0; i < vs.Length; i++)
            // {
            //    int j = 0;
            //    while (j < evenArr.Length)
            //    {
            //        if (vs[i] % 2 == 0)
            //        {
            //            evenArr[j] = vs[i];
            //            j++;
            //        }
            //    }
            // }
            for (int i = 0; i < vs.Length; i++)
            {
                if (vs[i] % 2 == 0)
                {
                    evenArr[i] = vs[i];
                }

                if (vs[i] % 2 != 0)
                {
                    oddArr[i] = vs[i];
                }
            }

            for (int i = 0; i < vs.Length; i++)
            {
                int j = 0;
                while (j < oddArr.Length)
                {
                    if (vs[i] % 2 != 0)
                    {
                        oddArr[j] = vs[i];
                        j++;
                    }
                }
            }

            string[] alp = { "A", "b", "c", "D", "E", "f", "g", "H", "I", "J", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            int[] nums = new int[26];
            for (int i = 1; i <= 26; i++)
            {
                nums[i - 1] = i;
            }

            string[] NumbersToLetters(int[] arr)
            {
                string[] res = new string[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (arr[i] == nums[j])
                        {
                            res[i] = alp[j];
                        }
                    }
                }

                return res;
            }

            string[] resEven = NumbersToLetters(evenArr);
            for (int i = 0; i < resEven.Length; i++)
            {
                Console.Write(resEven[i] + " ");
            }

            string[] resOdd = NumbersToLetters(oddArr);
            for (int i = 0; i < resOdd.Length; i++)
            {
                Console.Write(resOdd[i] + " ");
            }
        }
    }
}

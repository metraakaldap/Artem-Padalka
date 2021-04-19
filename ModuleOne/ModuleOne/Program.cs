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

            // Console.WriteLine(countOdd);
            // Console.WriteLine(countEven);
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
            for (int i = 0, k = 0, j = 0; i < vs.Length; i++)
            {
                if (vs[i] % 2 == 0)
                {
                    evenArr[k] = vs[i];
                    k++;
                }

                if (vs[i] % 2 != 0)
                {
                    oddArr[j] = vs[i];
                    j++;
                }
            }

            // for (int i = 0; i < vs.Length; i++)
            // {
            //    int j = 0;
            //    while (j < oddArr.Length)
            //    {
            //        if (vs[i] % 2 != 0)
            //        {
            //            oddArr[j] = vs[i];
            //            j++;
            //        }
            //    }
            // }
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
            string[] resOdd = NumbersToLetters(oddArr);
            string[] letters = { "A", "D", "E", "H", "I", "J" };
            int countEvenNew = 0;
            int countOddNew = 0;
            for (int i = 0; i < resEven.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (resEven[i] == letters[j])
                    {
                        countEvenNew++;
                    }
                }
            }

            for (int i = 0; i < resOdd.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (resOdd[i] == letters[j])
                    {
                        countOddNew++;
                    }
                }
            }

            if (countEvenNew > countOddNew)
            {
                Console.WriteLine("В чётном массиве больше искомых букв");
            }
            else
            {
                Console.WriteLine("В нечётном массиве больше искомых букв");
            }

            for (int i = 0; i < resEven.Length; i++)
            {
                Console.Write(resEven[i] + " ");
            }

            Console.WriteLine(" ");

            for (int i = 0; i < resOdd.Length; i++)
            {
                Console.Write(resOdd[i] + " ");
            }
        }
    }
}

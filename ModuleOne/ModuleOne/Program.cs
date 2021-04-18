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

            int[] evenArr = new int[countEven]; // заполняем чётными
            for (int i = 0; i < vs.Length; i++)
            {
                int j = 0;
                while (j < evenArr.Length)
                {
                    if (vs[i] % 2 == 0)
                    {
                        vs[i] = evenArr[j];
                        j++;
                    }
                }
            }

            int[] oddArr = new int[countOdd]; // заполняем нечётными
            for (int i = 0; i < vs.Length; i++)
            {
                int j = 0;
                while (j < oddArr.Length)
                {
                    if (vs[i] % 2 != 0)
                    {
                        vs[i] = oddArr[j];
                        j++;
                    }
                }
            }
        }
    }
}

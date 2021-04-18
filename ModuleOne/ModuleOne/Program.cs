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
            int count1 = 0;
            int count = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            int[] vs = new int[n];
            for (int i = 0; i < vs.Length; i++)
            {
                vs[i] = new Random().Next(1, 26);
                if (vs[i] % 2 == 0)
                {
                    count++;
                }

                if (vs[i] % 2 != 0)
                {
                    count1++;
                }
            }

            int[] evenArr = new int[count];
            for (int i = 0; i < evenArr.Length; i++)
            {
                if (vs[i] % 2 == 0)
                {
                    count++;
                }
            }

            int[] oddArr = new int[count1];
        }
    }
}

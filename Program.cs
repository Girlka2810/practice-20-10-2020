using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[] a = new int[n];//array for 5 elements
            for (int i=0; i<n;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
               // a[i] *= a[i];
            }
            int max=a[0];
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(max - a[i]);
            }



        }
    }
}

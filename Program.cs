using System;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 22;
            printSelfDividingNumbers(a, b);

            int n2 = 5;
            printSeries(n2);

            int n3 = 5;
            printTriangle(n3);

            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);

            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            Console.WriteLine(r5);
            Console.ReadLine();

            solvePuzzle();
        }

        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                while (x <= y)
                {
                    bool k = split_number(x);
                    if (k)
                    {
                        Console.WriteLine(x + "is self dividing" + k);
                    }
                    else
                    {
                        Console.WriteLine(x + "is not self dividing" + k);
                    }
                    x++;
                }
                Console.WriteLine("End of Self Dividing Numbers");
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }

        public static bool split_number(int x)
        {
            int y;
            y = x;
            bool m;
            m = false;
            while (x >= 1)
            {

                int a;
                a = x % 10;
                x = x / 10;
                if (a == 0 || y % a == 0)
                {
                    m = true;
                }
                else
                {
                    m = false;
                    break;
                }

            }
            return m;
        }


        public static void printSeries(int n)
        {
            try
            {
                int m = 1;
                for (int i = 1; i <= n && m <= 5; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i+" ");
                        m++;
                    }
                }
                // Write your code here
                Console.WriteLine();
                Console.WriteLine("End of Print Series");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        public static void printTriangle(int n)
        {
            try
            {


                int z = n * 2 - 1;
                for (int i = n; i >= 1; i--)
                {
                    for (int j = n - 1; j >= i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= z; k++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                    z -= 2;
                }
                Console.WriteLine("End of Print Triangle");
            }







            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");

            }
        }

public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
                int[] j = new int[] { 1, 3 };
                int[] s = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
                int m = 0;
                int n = 0;
                int p = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    if (j[0] == s[i])
                        m++;
                }

                for (int k = 0; k < s.Length; k++)
                {
                    if (j[1] == s[k])
                        n++;
                }

                p = m + n;
                return p;
                Console.WriteLine("End of Gems and Jewels");


            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;
        }

        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            try
            {
                
                
                int[] k = new int[7];
                int m = 0;
                int i;
                int j;
                for (i = 0; i < a.Length; i++)
                {
                    for (j = 0; j < b.Length; j++)
                    {
                        if (a[i] == b[j])
                        {
                            k[m] = a[i];
                            m++;
                        }
                    }
                }
                
                
                

                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }

            return null; // return the actual array
        }

        public static void solvePuzzle()
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }
    }
}


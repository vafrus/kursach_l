using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach_l
{
    static class Sort
    {
        public static void shell(int[] A)
        {
            int i, j, k;
            int d, n1, p;
            int n = A.Length;
            bool T;
            d = n / 2;
            while (d >= 1)
            {
                i = 0;
                T = true;
                n1 = n / d;
                while (i < n1 && T)
                {
                    k = 1;
                    T = false;
                    for (j = 1; j != n1 - i; j++)
                    {
                        if (A[k - 1] > A[k + d - 1])
                        {
                            p = A[k - 1];
                            A[k - 1] = A[k + d - 1];
                            A[k + d - 1] = p;
                            T = true;
                        }
                        k = k + d;
                    }
                    i++;
                }
                d = d / 2;
            }
        }

        public static void insert(int[] A)
        {
            int i, j, k, b;
            int n = A.Length;
            for (i = 1; i < n; i++)
            {
                b = A[i];
                j = 0;
                while (b > A[j] && j <= i)
                {
                    j++;
                }
                for (k = i; k > j + 1; k--)
                {
                    A[k] = A[k - 1];
                }
                A[j] = b;
            }
        }
    }
}

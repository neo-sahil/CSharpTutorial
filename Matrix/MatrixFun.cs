using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MatrixFun
    {
        public void Transpose()
        {
            int[,] a = new int[4,4] { { 9, 13, 5, 2 }, { 1, 11, 7, 6 }, { 3, 7, 4, 1 }, { 6, 0, 7, 10 } };

            int[,] b = new int[4, 4];

            var timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    b[j, i] = a[i, j];
                }
            }
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;

            Console.WriteLine("Time taken: " + timeTaken.ToString());


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i<4; i++)
            {
                for(int j = 0; j<4; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            
        }

        public void TrasposeRec()
        {
            int[,] a = new int[4, 4] { { 9, 13, 5, 2 }, { 1, 11, 7, 6 }, { 3, 7, 4, 1 }, { 6, 0, 7, 10 } };

            int[,] b = new int[4, 4];

            fun(0, ref a, ref b);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        public void fun(int i, ref int[,] a, ref int[,]b)
        {
            if(i < a.GetLength(0))
            {
                fun2(i, 0, ref a, ref b);
                fun(i++, ref a, ref b);
            }
        }


        public void fun2(int i, int j, ref int[,] a, ref int[,] b)
        {
            if(j < a.GetLength(1))
            {
                b[j, i] = a[i, j];
                fun2(i, j++, ref a, ref b);
            }
        }
    }
}

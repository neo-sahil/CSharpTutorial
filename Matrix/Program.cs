using System;

namespace Matrix
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MatrixFun mf = new MatrixFun();
            //mf.Transpose();
            mf.TrasposeRec();
        }
    }
}

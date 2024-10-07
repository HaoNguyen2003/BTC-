using System;
namespace generic
{
    class Program
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp=a; a=b; b=temp;
        }
        static void Main(string[] args)
        {
            //cach su dung
            int a=5; int b=6;
            double d=7, e=8;
            Swap<int>(ref a, ref b);
            Swap<double>(ref d, ref e);
            System.Console.WriteLine("a= {0}" + "b={1}" +"d={2}"+"e={3}", a, b,d,e);

        }
    }
}
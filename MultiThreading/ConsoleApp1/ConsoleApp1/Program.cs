using System;
namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args) {
            //cho phep chay da luong
            for(int i = 0; i < 5; i++) {
                var tempValue = i;
                Thread t = new Thread(() =>
                demo(""+tempValue)
            );
                t.IsBackground = true;//tat chung trinh thi no se het luon
                t.Start();
            }
        }
        static void demo(string s)
        {
            for (int i = 0; i < 5; i++)
            {
                //Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine("threadIndex"+s+": "+i);
            }
        }
    }

}
using System;
namespace Tuplenew 
{
    class Program
    {
        static void Main(string[] args)
        {
            //c1
            var tuple1 = Tuple.Create<int, string>(1, "NTH");
            //c2
            var tuple2 =  new Tuple<int, string,bool>(2,"NQH",true);
            Console.WriteLine("ID={0} name={1}",tuple1.Item1,tuple1.Item2);
            var tuple3 = getDatennow();
            Console.WriteLine(tuple3.Item1+""+tuple3.Item2+""+tuple3.Item3);
            Console.WriteLine(tuple3.ToString());
        }
        static Tuple<int, int, int>getDatennow()
        {
            DateTime dt = DateTime.Now;
            return new Tuple<int, int, int>(dt.Day, dt.Month, dt.Year);
        }
    }
}
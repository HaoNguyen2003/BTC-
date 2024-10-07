using System;
namespace delege
{
    class Program
    {
        delegate int Mydelege(string x);
        static void Main(string[] args)
        {
            Mydelege conver = new Mydelege(CoverToInt);
            Mydelege show= new Mydelege(showstring);
            Mydelege muti = show+conver;
            string v = "12345";
            int value = muti(v);
            Console.WriteLine(value);
            NhapVaShowten(show);
            //muticat delege goi nhieu ham de delegate thuc hien tuan tu khong phai lay keet qua th trc do de goi cho thang kia;
            //truyeenf delegate vao ham
        }
        static int NhapVaShowten(Mydelege showTen) {
            Console.WriteLine("Nhap ten cua ban");
            string s=Console.ReadLine();
            showTen(s);
            return 0;
         }
        static  int CoverToInt(string x)
        {
            int value = 0;
            int.TryParse(x, out value);
            return value;
        }
        static int showstring(string x)
        {
            int value = 0;
            Console.WriteLine("tao in ra nhe"+x);
            return value;
        }
    }
}
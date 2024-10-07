using System;
using System.Text;

namespace eventCsharp
{
    delegate void Updatename(string name);
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            hs hocsinh=new hs();
            hocsinh.NameChange += Hocsinh_NameChange;
            hocsinh.name = "Kteam";
            hocsinh.name = "TITV";
        }

        private static void Hocsinh_NameChange(string name)
        {
            Console.WriteLine("Tên mới là: " + name);
        }
    }
     class hs
    {
        public event Updatename NameChange;
        private string Name;
        public string name
        {
            get { return this.Name; }
            set { this.Name = value; 
                if(NameChange!= null)
                {
                    NameChange(name);
                }
            }
        }
    }

}

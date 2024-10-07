using System;
using System.Text;

namespace eventheodonet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            student hs=new student();
            hs.NameChanged += Hs_NameChanged;
            hs.valname = "123";
            hs.valname = "456";
            hs.valname = "789";
        }

        private static void Hs_NameChanged(object? sender,nameChangeEventArgs e)
        {
            Console.WriteLine("Tên có sự thay đổi là: "+e.name);
        }
    }
    public class student {
        private string Name;
        public student() { }
        public student(string name)
        {
            Name = name;
        }
        public string valname{
            get => Name;
            set { Name = value;
                onNameChanged(value);

            }
         }
        //luu value
        private event EventHandler<nameChangeEventArgs> _nameChange;

        public event EventHandler<nameChangeEventArgs> NameChanged
        {
            add { _nameChange += value;}
            remove { _nameChange -= value;}
        }
        void onNameChanged(string name)
        {
            if(_nameChange != null)
            {
                _nameChange(this,new nameChangeEventArgs(name));
            }
        }
    }
    public class nameChangeEventArgs : EventArgs
    {
        public string name { get; set; }    
        public nameChangeEventArgs(string name)
        {
            this.name = name;
        }

    }

}
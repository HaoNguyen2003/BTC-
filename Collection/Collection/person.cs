using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class person
    {
        private int age;
        private string name;
        public person(int age, string name)
        {
            this.age=age;
            this.name=name;
        }
        public person() { }
        public int ValAge {  
            get { return age; } 
            set { age = value; }
        }
        public string valName
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()
        {
            return "Name: "+this.valName+" Age: "+this.ValAge;
        }
    }
}

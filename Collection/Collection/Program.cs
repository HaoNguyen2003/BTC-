using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace Collection
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList arrPerson= new ArrayList();
            arrPerson.Add(new person(12, "NguyenVanA"));
            arrPerson.Add(new person(13, "NguyenVanB"));
            arrPerson.Add(new person(15, "NguyenVanC"));
            arrPerson.Add(new person(12, "NguyenVanD"));
            foreach(person person in arrPerson)
            {
                Console.WriteLine(person.ToString());
            }
            arrPerson.Sort(new sortPerson());

            foreach (person person in arrPerson)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
    public class sortPerson:IComparer
    {
        public int Compare(object x, object y)
        {
            person a= (person)x;
            person b= (person)y;
            if(a.ValAge<b.ValAge)
            {
                return -1;
            }
            else if (a.ValAge>b.ValAge)
            {
                return 1;
            }
            return 0;
        }
    }
}
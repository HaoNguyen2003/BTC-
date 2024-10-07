using System;
using System.Collections;

namespace Icolecttion
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyCollection : ICollection
    {
        private List<object> items = new List<object>();

        // Phương thức Add cần phải được triển khai
        public void Add(object item)
        {
            items.Add(item);
        }

        // Phương thức Clear cần phải được triển khai
        public void Clear()
        {
            items.Clear();
        }

        // Phương thức Contains cần phải được triển khai
        public bool Contains(object item)
        {
            return items.Contains(item);
        }

        // Phương thức CopyTo cần phải được triển khai
        public void CopyTo(Array array, int index)
        {
            items.CopyTo((object[])array, index);
        }

        // Thuộc tính Count cần phải được triển khai
        public int Count
        {
            get { return items.Count; }
        }

        // Thuộc tính IsSynchronized không bắt buộc, trả về false trong trường hợp này
        public bool IsSynchronized
        {
            get { return false; }
        }

        // Thuộc tính SyncRoot không bắt buộc, trả về null trong trường hợp này
        public object SyncRoot
        {
            get { return null; }
        }

        // Phương thức GetEnumerator cần phải được triển khai
        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }

    class Program
    {
        static void Main()
        {
            // Sử dụng lớp MyCollection
            MyCollection myCollection = new MyCollection();
            myCollection.Add("Item 1");
            myCollection.Add("Item 2");

            foreach (var item in myCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
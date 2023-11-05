using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{ 
    public class MyList<T>
    {
            private T[] items;
            private int count;

            public MyList()
            {
                items = new T[4];
                count = 0;
            }

            public int Capacity
            {
                get { return items.Length; }
                set
                {
                    if (value < count)
                        throw new ArgumentException("Tutum cari hesablamadan kicik deyer ala bilmez.");
                    if (value != items.Length)
                    {
                        T[] newItems = new T[value];
                        Array.Copy(items, newItems, count);
                        items = newItems;
                    }
                }
            }

            public int Count
            {
                get { return count; }
            }

            public void Add(T item)
            {
                if (count == items.Length)
                {
                    Capacity *= 2;
                }
                items[count] = item;
                count++;
            }

            public void Clear()
            {
                Array.Clear(items, 0, count);
                count = 0;
            }

            public bool Exists(T item)
            {
                return Array.IndexOf(items, item, 0, count) >= 0;
            }

            public bool Remove(T item)
            {
                int index = Array.IndexOf(items, item, 0, count);
                if (index >= 0)
                {
                    for (int i = index; i < count - 1; i++)
                    {
                        items[i] = items[i + 1];
                    }
                    count--;
                    items[count] = default(T);
                    return true;
                }
                return false;
            }

            public void Reverse()
            {
                Array.Reverse(items, 0, count);
            }

            public int IndexOf(T item)
            {
                return Array.IndexOf(items, item, 0, count);
            }

            public int LastIndexOf(T item)
            {
                return Array.LastIndexOf(items, item, count - 1, count);
            }
    }
}


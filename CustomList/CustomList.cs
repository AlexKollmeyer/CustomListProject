using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable 
    {
        public IEnumerator GetEnumerator(T item)
        {
            foreach()
        }
        //Member Variables (HAS A)
        public T[] Items { get ; set; }

        public T this[int index]
        {
            get
            {
                return Items[index];
            }
            set
            {
                Items [index] = value;
            }
        }

        public int Capacity { get; set; }
        
        
        public int Count { get; private set; }


        //Constructor
        public CustomList()
        {
            Capacity = 4;
            Count = 0;
            Items = new T[Capacity];
        }

        //Member Methods (CAN DO)
        public void Add(T item)
        {
            if (Count < Capacity)
            {
                Items[Count] = item;
                Count++;
            }
            else 
            {
                Capacity = Capacity * 2;
                T[] temp = new T[Capacity];
                Items.CopyTo(temp, 0);
                Items = temp;
                Items[Count] = item;
                Count++;

            }
            //'item' parameter should be added to internal 'items' array
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array
        }

        public bool Remove(T item)
        {
            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.
            return false;
        }

        public override string ToString()
        {
            //returns a single string that contains all items from array
            return "";
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return null;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return null;
        }


    }
}

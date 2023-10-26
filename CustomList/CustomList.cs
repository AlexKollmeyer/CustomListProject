using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable where T : IEquatable<T>
    {

        private T[] items;
        private int capacity;
        private int count;
        //Member Variables (HAS A)
        public T[] Items { get { return items; }  set { items = value; } }

        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items [index] = value;
            }
        }

        public int Capacity { get { return capacity; } }
        
        
        public int Count { get { return count; } }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        //Constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[Capacity];
        }

        //Member Methods (CAN DO)
        public void Add(T item)
        {
            if (Count == Capacity)
            {
                capacity = Capacity * 2;
                T[] temp = new T[Capacity];
                Items.CopyTo(temp, 0);
                items = temp;
            }
            Items[Count] = item;
            count++;
            //'item' parameter should be added to internal 'items' array
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array
        }

        public bool Remove(T item) 
        {
            int X = Count;
            for (int i = 0; i < Items.Length; i++)
            {
                if (item.Equals(Items[i]))
                {
                    int index = i;
                    T[] temp = new T[Capacity];
                    for (int o=0; o < index; o++)
                    {
                            temp[o] = Items[o];

                           
                    }
                    for (int o = index+1; o < Items.Length; o++)
                    {

                    temp[o-1] = Items[o];

                    }

                    Items = temp;
                    count--;
                    break;
                }
            }
            if (X != Count)
            {

                return true;
             }

            else 
            {
                return false;
            }
            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.
        }

        public override string ToString()
        {
            string tempString = "";
            for(int i = 0; i<count; i++)
            {
                tempString += $"{items[i]}";
            }
            return tempString;
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> newList = new CustomList<T>();
            if (firstList.count != 0) 
            { 
                for (int i = 0; i < firstList.count; i++)
                {
                    newList.Add(firstList[i]);
                }
            }
            if (secondList.count != 0)
            {
                for (int i = 0; i < secondList.count; i++)
                {
                    newList.Add(secondList[i]);
                }
            }
            return newList;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> newList = new CustomList<T>();
            
            if (firstList.count != 0)
            {
                for (int i = 0; i < firstList.count; i++)
                {
                    newList.Add(firstList[i]);
                }
            }
            if (secondList.count != 0)
            {
                for (int x = 0; x < secondList.count; x++)
                {
                    for (int j = 0; j < firstList.count; j++)
                    {
                        if (firstList[j].Equals(secondList[x]))
                        {
                            newList.Remove(firstList[x]);
                        }
                    }
                }
            }
            return newList;
            
        }


    }
}

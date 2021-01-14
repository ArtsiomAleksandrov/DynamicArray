using System;
using System.Collections;
using System.Collections.Generic;

namespace DynamicArray
{
    public class DynamicArray<T> : IEnumerable<T>
    {
        private int size = 0;

        private long capacity = 0;  

        private T[] array;

        public int Size 
        {
            get { return size; }
        }

        public T this[int index]
        {
            get
            {
                if (index >= size || index<0)
                {
                    return default (T);
                }
                return array[index];
            }
        }

        public DynamicArray()
        {
            array = new T[1];
        } 
        public DynamicArray(long capacity)
        {
            this.capacity = capacity;
            array = new T[capacity];
        }

        public void Add(T elem)
        {
            if(size + 1 >= capacity)
            {
                if(capacity == 0) capacity = 1;

                else capacity*=2;

                T[] newArr = new T[capacity];

                for(int i = 0; i < size; i++)
                {
                    newArr[i] = array[i];
                }

                array = newArr;
            }

            array[size++] = elem;
        }

        public T RemoveAt(int index)
        {
            if (index >= size || index < 0) throw new IndexOutOfRangeException();

            T removedElem = array[index];

            T[] newArr = new T[size-1];

            for (int i = 0, j = 0; i < size; i++, j++)
            {
                if (i == index) j--; 

                else newArr[j] = array[i];
            }

            array = newArr;

            capacity = --size;

            return removedElem;
        }

        public int IndexOf(T elem)
        {
            for(int i = 0; i < size; i++)
            {
                if(array[i].Equals(elem)) return i;
            }
            return -1;
        }

        public bool Remove(T elem)
        {
            int index = IndexOf(elem);
            if(index == -1) return false;
            RemoveAt(index);
            return true;
        }
        
        public void Clear()
        {
            for(int i = 0; i < size; i++)
            {
                array[i] = default(T);
            }
            size = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < size; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
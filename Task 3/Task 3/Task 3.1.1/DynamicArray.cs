using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_3._1._1
{
    public class DynamicArray<T> : IEnumerable
    {
        protected T[] array;
        public int Length { get; private set; } = 0;
        public int Capacity
        {
            get => array.Length;
            set
            {
                Array.Resize(ref array, value);
            }
        }

        public DynamicArray()
        {
            array = new T[8];
            Capacity = 8;
        }

        public DynamicArray(int value)
        {
            if (value <= 0)
                throw new ArgumentException("Capacity can not be equal to or lower than 0");
            array = new T[value];
            Capacity = value;
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            array = new T[collection.Count()];
            collection.ToArray<T>().CopyTo(array, 0);
            Capacity = array.Length;
        }

        public void Add(T item)
        {
            if (Length == 0)
            {
                array[0] = item;
                Length++;
            }
            else if (Length == Capacity)
            {
                Array.Resize(ref array, Capacity * 2);
                array[Length] = item;
                Length++;
            }
            else
            {
                array[Length] = item;
                Length++;
            }
        }

        public void AddRange(IEnumerable<T> collection)
        {
            var count = collection.Count();
            if (count > Capacity)
            {
                Capacity += count;
                Array.Resize(ref array, Capacity);
            }
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public bool Remove(int index)
        {
            if (index < 0 || index >= Length)
                return false;

            for (int i = index; i < Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Length--;
            return true;
        }

        public bool Insert(T item, int index)
        {
            if (index < 0 || index > Length)
                return false;
            if (Length == Capacity)
                Array.Resize(ref array, Capacity * 2);
            for (int i = index + 1; i < Length; i++)
            {
                array[i] = array[i - 1];
            }
            array[index] = item;
            Length++;
            return true;
        }

        public T this[int i]
        {
            get
            {
                if (i < 0)
                {
                    i *= -1;
                    return array[^i];
                }
                return array[i];
            }
            set
            {
                if (i < 0)
                {
                    i *= -1;
                    array[^i] = value;
                }
                else
                    array[i] = value;
            }
        }

        public virtual IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public object Clone()
        {
            return array.Clone();
        }

        public T[] ToArray()
        {
            var arr = new T[Length];
            array.CopyTo(arr, 0);
            return arr;
        }
    }
}

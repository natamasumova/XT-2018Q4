using System;
using System.Collections;
using System.Collections.Generic;

namespace Epam.Task3._3
{
    public class DynamicArray<T> : IEnumerable<T>, ICloneable
    {
        private T[] MyArray { get; set; }
        private int Length { get; set; }
        private int Capacity { get; set; }

        public DynamicArray()
        {
            MyArray = new T[8];
            Capacity = 8;
        }
        public DynamicArray(int capacity)
        {
            MyArray = new T[capacity];
            Capacity = capacity;
        }
        public DynamicArray(IEnumerable<T> collection)
        {
            MyArray = new T[(collection as ICollection).Count];
            (collection as ICollection).CopyTo(MyArray, 0);
            Capacity = MyArray.Length;
        }

        public T this[int index]
        {
            get
            {
                if ((-index) + 1 > Length || index > Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (index > -1)
                {
                    return MyArray[index];
                }
                else
                {
                    return MyArray[Length + index - 1];
                }
            }

            set
            {
                if ((-index + 1) > Length || index > Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (index > -1)
                {
                    MyArray[index] = value;
                }
                else
                {
                    MyArray[Length + index - 1] = value;
                }
            }
        }

        public void Add(T item)
        {
            if (MyArray.Length == Capacity)
            {
                Capacity *= 2;
                T[] arr = new T[Capacity];
                MyArray.CopyTo(arr, 0);

                Array.Resize(ref arr, Capacity);
                MyArray = arr;
            }
            MyArray[MyArray.Length] = item;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            int increase = (collection as ICollection).Count;
            if ((MyArray.Length + increase) >= Capacity)
            {
                Capacity += increase;
                T[] arr = new T[MyArray.Length + increase];
                MyArray.CopyTo(arr, 0);

                Array.Resize(ref arr, Capacity);
                MyArray = arr;
            }
            foreach (var c in collection)
            {
                Add(c);
            }
        }

        public bool Remove(T item)
        {
            if (MyArray.Length == 0)
            {
                return false;
            }

            int index = 0;
            while (index < MyArray.Length)
            {
                if (MyArray[index].Equals(item))
                {
                    Array.Copy(MyArray, index + 1, MyArray, index, (MyArray.Length - index + 1));
                    break;
                }
                index++;
            }
            MyArray[MyArray.Length - 1] = default(T);
            return true;
        }

        public bool Insert(int index, T item)
        {
            if (index >= MyArray.Length)
            {
                return false;
            }
            Array.Copy(MyArray, index, MyArray, index + 1, MyArray.Length - index);
            MyArray[index] = item;
            return true;
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)this.GetEnumerator();
        }

        public T OnIndex(int index)
        {
            T item = default(T);
            if (index < 0 || index >= MyArray.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            int i = 0;
            while (i < MyArray.Length)
            {
                if (i == index)
                {
                    item = MyArray[i];
                }
                i++;
            }
            return item;
        }

        public void ChangeCapacity(int value)
        {
            this.Capacity = value;
        }

        public object Clone()
        {
            return new DynamicArray<T>
            {
                MyArray = this.MyArray,
                Length = this.Length,
                Capacity = this.Capacity
            };
        }

        public T[] ToArray()
        {
            return this.MyArray;
        }
    }
}

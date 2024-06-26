using System;
using System.Collections;
using System.Collections.Generic;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T itemZero;
        private T itemOne;
        private T itemTwo;

        public Guarda3()
        {
            itemZero = default(T);
            itemOne = default(T);
            itemTwo = default(T);
        }

        public T GetItem(int i)
        {
            return i switch
            {
                0 => itemZero,
                1 => itemOne,
                2 => itemTwo,
                _ => throw new IndexOutOfRangeException()
            };
        }

        public void SetItem(int i, T item)
        {
            switch (i)
            {
                case 0:
                    itemZero = item;
                    break;
                case 1:
                    itemOne = item;
                    break;
                case 2:
                    itemTwo = item;
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        public void Add(T item)
        {
            if (EqualityComparer<T>.Default.Equals(itemZero, default(T)))
            {
                itemZero = item;
            }
            else if (EqualityComparer<T>.Default.Equals(itemOne, default(T)))
            {
                itemOne = item;
            }
            else if (EqualityComparer<T>.Default.Equals(itemTwo, default(T)))
            {
                itemTwo = item;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return itemZero;
            yield return itemOne;
            yield return itemTwo;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
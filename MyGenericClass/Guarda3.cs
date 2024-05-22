using System;

namespace MyGenericClass
{
    public class Guarda3<T>
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
    }
}
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
    }
}
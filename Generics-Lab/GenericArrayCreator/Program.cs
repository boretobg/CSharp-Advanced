using System;
using System.Runtime.CompilerServices;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");
            int[] integers = ArrayCreator.Create(10, 33);

        }
    }

    public class ArrayCreator
    {

        public static T[] Create<T>(int lenght, T item)
        {
            var array = new T[lenght];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = item;
            }
            return array;
        }
    }
}

using System;

namespace SharpyNet.Extensions
{
    public static class ArrayExtensions
    {
        public static T[] InsertIn<T>(this T[] array, T o, int index)
        {
            if (index > array.Size())
                throw new Exception($"Index : {index} is out of collection scope.");

            var resultArray = new T[array.Size() + 1];

            for (int toIndex = 0, fromIndex = 0;;)
            {
                if (toIndex == index)
                    resultArray[toIndex++] = o;

                if (toIndex == resultArray.Size() || fromIndex == array.Size())
                    break;

                resultArray[toIndex++] = array[fromIndex++];
            }

            return resultArray;
        }
    }
}

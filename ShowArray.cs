using System;
using System.Collections.Generic;

namespace ForExample29062021
{
    public class ShowArray<T>
    {
        private T[] _array;

        public ShowArray(List<T> inputList)
        {
            _array = (T[])inputList.ToArray().Clone();
        }

        public void Show()
        {
            Console.WriteLine();
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine("item [" + i + "] = " + _array[i]);
            }
        }
    }
}

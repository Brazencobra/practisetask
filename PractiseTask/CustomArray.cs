using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseTask
{
    internal class CustomArray
    {

        string[] _arr;

        public string this[int i] 
        {
            get
            {
                if (!(i<_arr.Length))
                {
                    throw new ArgumentException();
                }
                return _arr[i];
            }
            set
            {
                if (!(i<_arr.Length))
                {
                    throw new ArgumentException();
                }
                _arr[i] = value;
            }
        }

        public CustomArray()
        {
            _arr = new string[0];
        }

        public CustomArray(int length)
        {
            _arr=new string[length];
        }

        public static void Add(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Massivin " + (i + 1) + ". elementini daxil edin : ");

                array[i] = Console.ReadLine();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class program2
    {
        public static void  GetArray (int[] array)
         {
            string netice = "";
            for (int i = 0; i < array.Length-1; i++)
            {
                netice += array[i];

                Console.WriteLine( netice);

            }
        }
        public static void GetSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                 sum += array[i];
               
            }
            Console.WriteLine(sum);
        }
        public static bool Menfi(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

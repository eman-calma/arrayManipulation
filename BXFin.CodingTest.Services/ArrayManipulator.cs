using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXFin.CodingTest.Services
{
    public class ArrayManipulator : IArrayManipulator
    {
        public int[] DeletePart(int position, int[] productIds)
        {
            int[] arr = new int[productIds.Length - 1];
            var count = 0;
            for (var i = 0; i <= productIds.Length - 1; i++)
            {
                if (i != (position - 1))
                {
                    arr[count] = productIds[i];
                    count = count + 1;
                }
            }

            return arr;
        }

        public int[] Reverse(int[] productIds)
        {
            int[] arr = new int[productIds.Length];
            var count = 0;
            for (var i = productIds.Length - 1; i >= 0; i--)
            {
                arr[count] = productIds[i];
                count = count + 1;
            }

            return arr;
        }
    }
}

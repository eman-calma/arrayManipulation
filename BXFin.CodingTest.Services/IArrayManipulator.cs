using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXFin.CodingTest.Services
{
    public interface IArrayManipulator
    {
        int[] Reverse(int[] productIds);
        int[] DeletePart(int position, int[] productIds);

    }
}

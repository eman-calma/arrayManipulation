using Microsoft.VisualStudio.TestTools.UnitTesting;
using BXFin.CodingTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXFin.CodingTest.Services.Tests
{
    [TestClass()]
    public class ArrayManipulatorTests
    {
        [TestMethod()]
        public void DeletePartTest()
        {
            var _arrayManipulator = new ArrayManipulator();
            int position = 3;
            int[] input = new int[] { 1, 2, 3, 4, 5 };
            int[] expectedResult = new int[] { 1, 2, 4, 5 };

            int[] actualResult = _arrayManipulator.DeletePart(position, input);

            CollectionAssert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod()]
        public void ReverseTest()
        {
            var _arrayManipulator = new ArrayManipulator();

            int[] input = new int[] { 1, 2, 3, 4, 5 };
            int[] expectedResult = new int[] { 5, 4, 3, 2, 1};

            int[] actualResult = _arrayManipulator.Reverse(input);

            CollectionAssert.AreEqual(actualResult, expectedResult);
        }
    }
}
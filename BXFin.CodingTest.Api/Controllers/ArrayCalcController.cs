using BXFin.CodingTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BXFin.CodingTest.Api.Controllers
{
    public class ArrayCalcController : ApiController
    {
        private IArrayManipulator _arrayManipulator;
        public ArrayCalcController(IArrayManipulator arrayManipulator)
        {
            _arrayManipulator = arrayManipulator;
        }

        [Route("api/arraycalc/reverse")]
        [HttpPost]
        public int[] Reverse([FromUri] int[] productIds)
        {
            return _arrayManipulator.Reverse(productIds);
        }

        [Route("api/arraycalc/deletepart")]
        [HttpPost]
        public int[] DeletePart([FromUri] int position, [FromUri] int[] productIds)
        {
            return _arrayManipulator.DeletePart(position, productIds);
        }
    }
}

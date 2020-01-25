using ListifyCodeTest.Filters;
using ListifyCodeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ListifyCodeTest.Controllers
{
    [ListifyExceptionFilters]
    public class ListifyController : ApiController
    {
        /// <summary>
        /// The API route that returns a value at the specified index in a list of values between, and including, the begin and end parameters.
        /// </summary>
        /// <param name="begin">The desired beginning of the list.</param>
        /// <param name="end">The desired end of the list.</param>
        /// <param name="index">The index of the value to return.</param>
        /// <returns>A value at the specified index in a list of values between, and including, the begin and end parameters.</returns>
        [Route("listify/{begin:int}/{end:int}/{index:int}")]
        [HttpGet]
        public int Listify(int begin, int end, int index)
        {
            var list = new Listify(begin, end);
            var indexedValue = list[index];

            return indexedValue;
        }

        /// <summary>
        /// The API route that returns a list of values between, and including, the begin and end parameters.
        /// </summary>
        /// <param name="begin">The desired beginning of the list.</param>
        /// <param name="end">The desired end of the list.</param>
        /// <returns>A list of values between and including the begin and end parameters.</returns>
        [Route("listify/{begin:int}/{end:int}")]
        [HttpGet]
        public IEnumerable<int> Listify(int begin, int end)
        {
            var list = new Listify(begin, end);

            return list.Range;
        }
    }
}

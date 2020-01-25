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
        [Route("listify/{begin:int}/{end:int}/{index:int}")]
        [HttpGet]
        public int Listify(int begin, int end, int index)
        {
            var list = new Listify(begin, end);
            var indexedValue = list[index];

            return indexedValue;
        }

        [Route("listify/{begin:int}/{end:int}")]
        [HttpGet]
        public IEnumerable<int> Listify(int begin, int end)
        {
            var list = new Listify(begin, end);

            return list.Range;
        }
    }
}

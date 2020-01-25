using ListifyCodeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ListifyCodeTest.Controllers
{
    public class ListifyController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Listify(int begin, int end, int index)
        {
            try
            {
                var list = new Listify(begin, end);
                var indexedValue = list[index];

                return Json(list);
            }
            catch (IndexOutOfRangeException indexException)
            {
                return Json("The index parameter was out of bounds.");
            }
            catch (ArgumentOutOfRangeException argumentException)
            {
                return Json("The begin was higher than end, or end was lower than begin.");
            }

        }
    }
}

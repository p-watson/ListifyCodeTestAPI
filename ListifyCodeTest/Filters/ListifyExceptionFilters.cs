using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace ListifyCodeTest.Filters
{
    public class ListifyExceptionFilters : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            if (context.Exception is IndexOutOfRangeException)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent(string.Format("Out of Bounds: The index parameter was out of bounds.")),
                    ReasonPhrase = "Index out of bounds."
                };

                context.Response = resp;
            }
            else if (context.Exception is ArgumentOutOfRangeException)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent(string.Format("Argument Out of Range: The begin parameter was larger than the end, or the end parameter was less than the begin.")),
                    ReasonPhrase = "Argument out of range."
                };

                context.Response = resp;
            }
        }
    }
}
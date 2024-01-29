using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using RoutePrefixAttribute = System.Web.Http.RoutePrefixAttribute;

namespace WEBAPI_prueba.Controllers
{
    [RoutePrefix("api/Operaciones")]
    public class OperacionesController : ApiController
    {
        // GET: Operaciones
        [HttpGet]
        public  string Suma(int a, int b)
        {
            return (a + b).ToString();
        }
    }
}
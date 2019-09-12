using simpleCalcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace simpleCalcApp.Controllers
{
    public class CalculadoraController : ApiController
    {
        //api/Calculadora
        public IHttpActionResult Get(Operacion poperacion)
        {
            return Ok(Operacion.procesar(poperacion));
        }
    }
}

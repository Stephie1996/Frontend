using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebBMI.Models;

namespace WebBMI.Controllers
{
    public class BMIController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post(BMIParam para)
        {
            para.height = para.height / 100;
            var bmi = para.weight / (para.height * para.height);
            var ret = new BMIResult() { BMI = bmi };
            return Ok(ret);
        }
    }
}

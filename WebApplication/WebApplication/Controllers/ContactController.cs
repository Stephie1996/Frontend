using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication.Controllers
{
    public class ContactController : ApiController
    {
        [HttpGet]
        public object GetAll()
        {
            string[,] dat = new string[,]
            { 
                { "Amy", "1990/01/01","0933456789","amy0101@gmail.com","台北市光復南路","客戶" },
                { "Eric", "1990/02/02", "0933456987", "Eric0202@gmail.com", "台北市光復南路","同學"}
            };
            return dat;

        }
    }
}

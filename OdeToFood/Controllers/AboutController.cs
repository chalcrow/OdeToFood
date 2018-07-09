using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("about")]
    public class AboutController : Controller
    {
        [Route("")]
        public string Phone()
        {
            return "phone";
        }

        [Route("address")]
        public string Address()
        {
            return "my address";
        }
    }
}
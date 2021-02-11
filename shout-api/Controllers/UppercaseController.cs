using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace shout_api.Controllers
{
    [Route("api/uppercase")]
    [ApiController]
    public class UppercaseController : ControllerBase
    {
        // POST api/<UppercaseController>
        [HttpPost]
        public string Post(Word word)
        {
            Uppercase uppercase = new Uppercase();
            return uppercase.toUppercase(word.Value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TFNValidator_FrontEnd.Controllers
{
    [Route("Static")]
    public class StaticContentController : Controller
    {
        [Route("AppBundle")]
        public IActionResult GetAppBundle()
        {
            FileStream stream = new (@"C:\\Side Projects\\TFNValidator\\TFNValidator_FrontEnd\\Bundle\\bundle.js", FileMode.Open, FileAccess.Read);
            return new FileStreamResult(stream, "text/javascript");
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TFNValidator_FrontEnd.Controllers
{
    [Route("/")]
    public class HomeController:Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View("~/Views/Index.cshtml");
        }

        [Route("Validate")]
        public async Task<IActionResult> ValidateTfn(string tfnString)
        {
            HttpRequestMessage request = new(HttpMethod.Get, $"http://localhost:22178/TfnValidator/Validate?tfnString={tfnString}");
            HttpClient client = _httpClientFactory.CreateClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                return Ok(await response.Content.ReadAsStringAsync());
            }
            return BadRequest(await response.Content.ReadAsStringAsync());

        }
    }
}

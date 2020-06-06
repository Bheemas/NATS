using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NATS_Web.Models;

namespace NATS_Web.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private string strOutput = String.Empty;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(string price)
        {
           // private string strOutput= "";
            try
            {
                var isNumeric = int.TryParse(price, out int n);

                if (isNumeric)
                {

                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response = await client.GetAsync("https://localhost:44367/api/PriceVerification/" + price);

                        if (response.IsSuccessStatusCode)
                        {
                            var ObjResponse = response.Content.ReadAsStringAsync().Result;
                            strOutput = ObjResponse.ToString();
                            Console.Write("Success");
                        }
                        else
                        {
                            Console.Write("Failure");
                        }

                        return Content($"Hello is the output from APi -  {strOutput}");
                    }
                }

                else
                {
                    return Content($"Please enter numeric value");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
           
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

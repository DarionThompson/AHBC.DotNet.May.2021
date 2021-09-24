using IntroToApis.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToApis.Controllers
{
    public class ToolsController : Controller
    {
        private readonly ToolsClient _starsWarsClient;

        
        public ToolsController(ToolsClient starsWarsClient)
        {
            _starsWarsClient = starsWarsClient;
        }

        public async Task<IActionResult> Index()
        {
            var thing = await _starsWarsClient.GetToolsAsync();
            return View(thing);
        }
    }
}

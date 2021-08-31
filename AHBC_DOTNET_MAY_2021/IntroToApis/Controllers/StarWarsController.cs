using IntroToApis.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace IntroToApis.Controllers
{
    public class StarWarsController : Controller
    {
        private readonly IStarWarsClient _starsWarsClient;

        public StarWarsController(IStarWarsClient starsWarsClient)
        {
            _starsWarsClient = starsWarsClient;
        }

        public async Task<IActionResult> Index()
        {
            var peopleModel = await _starsWarsClient.GetPeopleAsync();
            return View(peopleModel.results);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIExample.Context;
using WebAPIExample.Models;

namespace WebAPIExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartsController : ControllerBase
    {
        //CRUD
        private readonly ToolShopContext _contex;

        public PartsController(ToolShopContext contex)
        {
            _contex = contex;
        }

        [HttpGet]
        //api/Parts
        public IEnumerable<Part> GetParts()
        {
            //fetch product from database....
            //We need the DB context..
            var parts = _contex.Parts.ToList();

            return parts;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetaQuotes.TestApplication.Controllers
{
    [ApiController]
    public class LocationsController : ControllerBase
    {
        public LocationsController()
        {

        }

        [HttpGet("/ip/location")]
        public ActionResult<string> GetIpLocation(string ip)
        {
            return ip;
        }


        [HttpGet("/city/locations")]
        public ActionResult<string> GetCityLocations(string city)
        {
            return city;
        }
    }
}
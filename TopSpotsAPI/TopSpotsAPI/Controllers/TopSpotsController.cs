using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TopSpotsAPI.Models;
using System.IO;
using Newtonsoft.Json;

namespace TopSpotsAPI.Controllers
{
    public class TopSpotsController : ApiController
    {
        public IEnumerable<TopSpot> Get()
        {
                // read file into a string and deserialize JSON to a type
                TopSpot[] TopSpots = JsonConvert.DeserializeObject<TopSpot[]>(File.ReadAllText(@"C:\dev\05-SanDiegoTopSpots-Angular\topspots.json"));

                return TopSpots;
        }
     }
}

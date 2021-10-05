using Microsoft.AspNetCore.Mvc;
using SampleApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Controllers
{
    public class SamplesController : BaseApiController
    {
        [HttpGet]
        public ActionResult<IEnumerable<Sample>> GetSamples()
        {
            List<Sample> samples = new List<Sample>();
            samples.Add(new Sample(1, "first", 5.6, DateTime.Now));
            samples.Add(new Sample(2, "second", 7.4, DateTime.Now));
            samples.Add(new Sample(3, "third", 12.3, DateTime.Now));
            samples.Add(new Sample(4, "fourth", 3.8, DateTime.Now));
            samples.Add(new Sample(5, "fifth", 6.5, DateTime.Now));
            return Ok(samples);
        }
    }
}

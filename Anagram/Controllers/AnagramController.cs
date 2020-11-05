using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anagram.Models;
using Anagram.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Anagram.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnagramController : ControllerBase
    {
        private readonly IAnagramService _service;

        public AnagramController(IAnagramService service)
        {
            _service = service;
        }
        // GET: api/<AnagramController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AnagramController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AnagramController>
        [HttpPost]
        public ActionResult<bool> Post(AnagramanDto anagram)
        {
            return Ok(new
            {
                Result = _service.PostAnagram(anagram.Word1, anagram.Word2)
            });
        }

        // PUT api/<AnagramController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AnagramController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

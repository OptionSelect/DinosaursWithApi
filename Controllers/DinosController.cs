using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinosaursWithApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DinosaursWithApi.Controllers
{
    [Route("api/dinos")]
    public class DinosController : Controller
    {
        // GET api/dinosaurs
        [HttpGet]
        public IEnumerable<DinoAPIModel> Get()
        {
            var dino = new DinoAPIModel();
            IEnumerable<DinoAPIModel> dinos = dino.DinoListGetter();
            return dinos;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public DinoAPIModel Get(int id)
        {
            var dino = new DinoAPIModel();
            List<DinoAPIModel> dinos = dino.DinoListGetter();
            return dinos[id-1];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

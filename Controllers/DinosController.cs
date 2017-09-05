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

        // GET api/dinos/5
        [HttpGet("{id}")]
        public DinoAPIModel Get(int id)
        {
            var dino = new DinoAPIModel();
            List<DinoAPIModel> dinos = dino.DinoListGetter();
            return dinos[id - 1];
        }

        // POST api/dinos
        [HttpPost]
        public void Post([FromBody]int id, string name, string size, string habitats)
        {
            var dino = new DinoAPIModel();
            List<DinoAPIModel> dinos = dino.DinoListGetter();
            var newDino = new DinoAPIModel
            {
                ID = id,
                DinoName = name,
                DinoSize = size,
                DinoHabitats = habitats
            };
        }

        // PUT api/dinos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string name, string size, string habitats)
        {
            var dino = new DinoAPIModel();
            List<DinoAPIModel> dinos = dino.DinoListGetter();
            if (dinos.Any(i => i.ID == id))
            {
                var currentDino = dinos.SingleOrDefault(w => dino.ID == id);
                currentDino.DinoName = name;
                currentDino.DinoSize = size;
                currentDino.DinoHabitats = habitats;
            } else {
                var newDino = new DinoAPIModel
                {
                    ID = id,
                    DinoName = name,
                    DinoSize = size,
                    DinoHabitats = habitats
                };
                dinos.Add(newDino);
            }

        }

        // DELETE api/dinos/5
        [HttpDelete("{id}")]
        public List<DinoAPIModel> Delete(int id)
        {
            var dino = new DinoAPIModel();
            List<DinoAPIModel> dinos = dino.DinoListGetter();
            dino = dinos.SingleOrDefault(i => i.ID == id);
            dinos.Remove(dino);
            return dinos;
        }
    }
}

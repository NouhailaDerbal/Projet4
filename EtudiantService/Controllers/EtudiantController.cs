using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EtudiantService.Models;
using EtudiantService.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EtudiantService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtudiantController : ControllerBase
    {
        ModelContext db;

        public EtudiantController(ModelContext db)
        {
            this.db = db;
        }


        // GET: api/Etudiant
        [HttpGet]
        public IEnumerable<Etudiant> Get()
        {
            return db.Etudiants.ToList();
        }

        // GET: api/Etudiant/5
        [HttpGet("{id}", Name = "Get")]
        public Etudiant Get(int id)
        {
            return db.Etudiants.Find(id);
        }

        // POST: api/Etudiant
        [HttpPost]
        public IActionResult Post([FromBody] Etudiant model)
        {
            try
            {
                db.Etudiants.Add(model);
                db.SaveChanges();
                return StatusCode(StatusCodes.Status201Created,model);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);

                throw;
            }
        }

        // PUT: api/Etudiant/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

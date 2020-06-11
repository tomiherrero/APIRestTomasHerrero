using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIRestTomasHerrero.Data;
using System.Threading;
using APIRestTomasHerrero.Models;
namespace APIRestTomasHerrero.Controllers
{

    // Declaración de Ruta 
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {

        // Instancio la clase generada de migración.
        private readonly DataFields data;

        // Constructor de los controladores. 
        public StudentsController(DataFields data)
        {
            this.data = data;
        }

        //Genero las peticiones 
        [HttpGet]
        public ActionResult<IEnumerable<StudentsDB>> Get()
        {
            return data.Student.ToList();
        }

        [HttpGet("{id}", Name = "Student")]
        public ActionResult<StudentsDB> Get(int id)
        {
            // FirstOrDefault = funcion de ASP.Net para ordenar por ID 
            var student = data.Student.FirstOrDefault(x => x.id == id);
            if (student == null)
                return NotFound();

            return student;
        }

        [HttpPost]
        public ActionResult Post([FromBody] StudentsDB studentDB)
        {
            data.Student.Add(studentDB);
            data.SaveChanges();
            // CreatedAtRouteResult = funcion de ASP.Net para redireccionar lo que agrega 
            return new CreatedAtRouteResult("Student", new { id = studentDB.id }, studentDB);
        }
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] StudentsDB value)
        {
            if (id != value.id)
                return BadRequest();

            data.Entry(value).State = EntityState.Modified;
            data.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult<StudentsDB> Delete(int id)
        {
            var student = data.Student.FirstOrDefault(x => x.id == id);
            if (student == null)
                return NotFound();

            data.Student.Remove(student);
            data.SaveChanges();
            return student;
        }


    }
}

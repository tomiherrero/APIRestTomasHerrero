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
    public class StudentsController: ControllerBase
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



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace APIRestTomasHerrero.Models
{
    // Tabla para migrar con sus respectivos campos 
    public class StudentsDB
    {
        public int id { get; set; }

        public int dni { get; set; }
        public string names { get; set; }

        public string surnames { get; set; }

        public string course { get; set; }

        public int year { get; set; }

    }
}

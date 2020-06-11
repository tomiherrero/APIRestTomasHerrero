
using APIRestTomasHerrero.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace APIRestTomasHerrero.Data
{
    public class DataFields: DbContext //Ìnstancio Clase a DB (ASP.Net) 
    {
        // Constructor de DataSet para realizar Migración
        public DataFields(DbContextOptions<DataFields> options) : base(options) 
        {

        }

        // Nombre de la migración a DB, (Asi se llamara en la BD)
        public DbSet<StudentsDB> Student { get; set; } 
    }
}

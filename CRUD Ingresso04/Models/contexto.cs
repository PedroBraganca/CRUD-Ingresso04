using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CRUD_Ingresso04.Models
{
    public class contexto: DbContext
    {
        public DbSet<ing> ings { get; set; }
      
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_Ingresso04.Models
{
    public class ing
    {
        [Key]
        public int codigo { get; set; }
        public String filme { get; set;}
        public String sessoes { get; set; }
        public String salas { get; set; }
        public String cinemas { get; set; }
        public String cidade { get; set; }
    }
}
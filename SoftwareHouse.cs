using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace net_ef_videogame
{
    [Table("softwarehouses")]
    [Index(nameof(SoftwareHouse_id), IsUnique =true)]
   public class SoftwareHouse
    {
        public int SoftwareHouse_id { get; set; }
        public string? Name { get; set; }

        public long  IVA { get; set; }

        public string? City { get; set; }

        public string? Country { get; set; }

        public List<Videogame>? Videogames { get; set; }
    }
}

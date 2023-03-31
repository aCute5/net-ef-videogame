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
    [Table("Videogame")]
    [Index(nameof(VideogameId), IsUnique = true)]
    public class Videogame
    {
        public int VideogameId { get; set; }
        public string? Name { get; set; }
        public string? Overview { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int SoftwareHouse_id { get; set; }
        public SoftwareHouse? SoftwareHouse { get; set; }


    }
}

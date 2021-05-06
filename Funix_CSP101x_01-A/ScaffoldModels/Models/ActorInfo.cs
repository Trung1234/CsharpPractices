using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaffoldModels.Models
{
    public partial class ActorInfo
    {
        [Column("actor_id", TypeName = "smallint(5) unsigned")]
        public ushort ActorId { get; set; }
        [Required]
        [Column("first_name", TypeName = "varchar(45)")]
        public string FirstName { get; set; }
        [Required]
        [Column("last_name", TypeName = "varchar(45)")]
        public string LastName { get; set; }
        [Column("film_info", TypeName = "text")]
        public string FilmInfo { get; set; }
    }
}

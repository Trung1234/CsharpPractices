using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaffoldModels.Models
{
    [Table("film_actor")]
    public partial class FilmActor
    {
        [Key]
        [Column("actor_id", TypeName = "smallint(5) unsigned")]
        public ushort ActorId { get; set; }
        [Key]
        [Column("film_id", TypeName = "smallint(5) unsigned")]
        public ushort FilmId { get; set; }
        [Column("last_update", TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey(nameof(ActorId))]
        [InverseProperty("FilmActor")]
        public virtual Actor Actor { get; set; }
        [ForeignKey(nameof(FilmId))]
        [InverseProperty("FilmActor")]
        public virtual Film Film { get; set; }
    }
}

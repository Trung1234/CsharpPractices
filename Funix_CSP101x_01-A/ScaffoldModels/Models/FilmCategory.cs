using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaffoldModels.Models
{
    [Table("film_category")]
    public partial class FilmCategory
    {
        [Key]
        [Column("film_id", TypeName = "smallint(5) unsigned")]
        public ushort FilmId { get; set; }
        [Key]
        [Column("category_id", TypeName = "tinyint(3) unsigned")]
        public byte CategoryId { get; set; }
        [Column("last_update", TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("FilmCategory")]
        public virtual Category Category { get; set; }
        [ForeignKey(nameof(FilmId))]
        [InverseProperty("FilmCategory")]
        public virtual Film Film { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaffoldModels.Models
{
    public partial class NicerButSlowerFilmList
    {
        [Column("FID", TypeName = "smallint(5) unsigned")]
        public ushort? Fid { get; set; }
        [Column("title", TypeName = "varchar(128)")]
        public string Title { get; set; }
        [Column("description", TypeName = "text")]
        public string Description { get; set; }
        [Required]
        [Column("category", TypeName = "varchar(25)")]
        public string Category { get; set; }
        [Column("price", TypeName = "decimal(4,2)")]
        public decimal? Price { get; set; }
        [Column("length", TypeName = "smallint(5) unsigned")]
        public ushort? Length { get; set; }
        [Column("rating", TypeName = "enum('G','PG','PG-13','R','NC-17')")]
        public string Rating { get; set; }
        [Column("actors", TypeName = "text")]
        public string Actors { get; set; }
    }
}

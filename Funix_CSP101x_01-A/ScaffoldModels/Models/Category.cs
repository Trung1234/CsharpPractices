using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaffoldModels.Models
{
    [Table("category")]
    public partial class Category
    {
        public Category()
        {
            FilmCategory = new HashSet<FilmCategory>();
        }

        [Key]
        [Column("category_id", TypeName = "tinyint(3) unsigned")]
        public byte CategoryId { get; set; }
        [Required]
        [Column("name", TypeName = "varchar(25)")]
        public string Name { get; set; }
        [Column("last_update", TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }

        [InverseProperty("Category")]
        public virtual ICollection<FilmCategory> FilmCategory { get; set; }
    }
}

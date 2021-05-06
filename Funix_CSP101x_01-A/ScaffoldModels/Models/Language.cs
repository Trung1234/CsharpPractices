using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaffoldModels.Models
{
    [Table("language")]
    public partial class Language
    {
        public Language()
        {
            FilmLanguage = new HashSet<Film>();
            FilmOriginalLanguage = new HashSet<Film>();
        }

        [Key]
        [Column("language_id", TypeName = "tinyint(3) unsigned")]
        public byte LanguageId { get; set; }
        [Required]
        [Column("name", TypeName = "char(20)")]
        public string Name { get; set; }
        [Column("last_update", TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }

        [InverseProperty(nameof(Film.Language))]
        public virtual ICollection<Film> FilmLanguage { get; set; }
        [InverseProperty(nameof(Film.OriginalLanguage))]
        public virtual ICollection<Film> FilmOriginalLanguage { get; set; }
    }
}

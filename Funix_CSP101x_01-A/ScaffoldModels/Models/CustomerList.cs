using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaffoldModels.Models
{
    public partial class CustomerList
    {
        [Column("ID", TypeName = "smallint(5) unsigned")]
        public ushort Id { get; set; }
        [Column("name", TypeName = "varchar(91)")]
        public string Name { get; set; }
        [Required]
        [Column("address", TypeName = "varchar(50)")]
        public string Address { get; set; }
        [Column("zip code", TypeName = "varchar(10)")]
        public string ZipCode { get; set; }
        [Required]
        [Column("phone", TypeName = "varchar(20)")]
        public string Phone { get; set; }
        [Required]
        [Column("city", TypeName = "varchar(50)")]
        public string City { get; set; }
        [Required]
        [Column("country", TypeName = "varchar(50)")]
        public string Country { get; set; }
        [Required]
        [Column("notes", TypeName = "varchar(6)")]
        public string Notes { get; set; }
        [Column("SID", TypeName = "tinyint(3) unsigned")]
        public byte Sid { get; set; }
    }
}

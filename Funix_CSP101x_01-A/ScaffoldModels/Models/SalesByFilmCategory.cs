using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaffoldModels.Models
{
    public partial class SalesByFilmCategory
    {
        [Required]
        [Column("category", TypeName = "varchar(25)")]
        public string Category { get; set; }
        [Column("total_sales", TypeName = "decimal(27,2)")]
        public decimal? TotalSales { get; set; }
    }
}

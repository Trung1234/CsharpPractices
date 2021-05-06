using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaffoldModels.Models
{
    public partial class SalesByStore
    {
        [Column("store", TypeName = "varchar(101)")]
        public string Store { get; set; }
        [Column("manager", TypeName = "varchar(91)")]
        public string Manager { get; set; }
        [Column("total_sales", TypeName = "decimal(27,2)")]
        public decimal? TotalSales { get; set; }
    }
}

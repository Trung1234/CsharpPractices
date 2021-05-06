using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaffoldModels.Models
{
    [Table("payment")]
    public partial class Payment
    {
        [Key]
        [Column("payment_id", TypeName = "smallint(5) unsigned")]
        public ushort PaymentId { get; set; }
        [Column("customer_id", TypeName = "smallint(5) unsigned")]
        public ushort CustomerId { get; set; }
        [Column("staff_id", TypeName = "tinyint(3) unsigned")]
        public byte StaffId { get; set; }
        [Column("rental_id", TypeName = "int(11)")]
        public int? RentalId { get; set; }
        [Column("amount", TypeName = "decimal(5,2)")]
        public decimal Amount { get; set; }
        [Column("payment_date", TypeName = "datetime")]
        public DateTime PaymentDate { get; set; }
        [Column("last_update", TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty("Payment")]
        public virtual Customer Customer { get; set; }
        [ForeignKey(nameof(RentalId))]
        [InverseProperty("Payment")]
        public virtual Rental Rental { get; set; }
        [ForeignKey(nameof(StaffId))]
        [InverseProperty("Payment")]
        public virtual Staff Staff { get; set; }
    }
}

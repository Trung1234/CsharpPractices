using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaffoldModels.Models
{
    [Table("rental")]
    public partial class Rental
    {
        public Rental()
        {
            Payment = new HashSet<Payment>();
        }

        [Key]
        [Column("rental_id", TypeName = "int(11)")]
        public int RentalId { get; set; }
        [Column("rental_date", TypeName = "datetime")]
        public DateTime RentalDate { get; set; }
        [Column("inventory_id", TypeName = "mediumint(8) unsigned")]
        public uint InventoryId { get; set; }
        [Column("customer_id", TypeName = "smallint(5) unsigned")]
        public ushort CustomerId { get; set; }
        [Column("return_date", TypeName = "datetime")]
        public DateTime? ReturnDate { get; set; }
        [Column("staff_id", TypeName = "tinyint(3) unsigned")]
        public byte StaffId { get; set; }
        [Column("last_update", TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty("Rental")]
        public virtual Customer Customer { get; set; }
        [ForeignKey(nameof(InventoryId))]
        [InverseProperty("Rental")]
        public virtual Inventory Inventory { get; set; }
        [ForeignKey(nameof(StaffId))]
        [InverseProperty("Rental")]
        public virtual Staff Staff { get; set; }
        [InverseProperty("Rental")]
        public virtual ICollection<Payment> Payment { get; set; }
    }
}

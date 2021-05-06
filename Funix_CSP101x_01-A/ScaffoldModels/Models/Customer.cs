using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaffoldModels.Models
{
    [Table("customer")]
    public partial class Customer
    {
        public Customer()
        {
            Payment = new HashSet<Payment>();
            Rental = new HashSet<Rental>();
        }

        [Key]
        [Column("customer_id", TypeName = "smallint(5) unsigned")]
        public ushort CustomerId { get; set; }
        [Column("store_id", TypeName = "tinyint(3) unsigned")]
        public byte StoreId { get; set; }
        [Required]
        [Column("first_name", TypeName = "varchar(45)")]
        public string FirstName { get; set; }
        [Required]
        [Column("last_name", TypeName = "varchar(45)")]
        public string LastName { get; set; }
        [Column("email", TypeName = "varchar(50)")]
        public string Email { get; set; }
        [Column("address_id", TypeName = "smallint(5) unsigned")]
        public ushort AddressId { get; set; }
        [Required]
        [Column("active")]
        public bool? Active { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime CreateDate { get; set; }
        [Column("last_update", TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey(nameof(AddressId))]
        [InverseProperty("Customer")]
        public virtual Address Address { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Customer")]
        public virtual Store Store { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<Payment> Payment { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<Rental> Rental { get; set; }
    }
}

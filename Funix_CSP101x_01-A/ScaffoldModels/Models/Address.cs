using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaffoldModels.Models
{
    [Table("address")]
    public partial class Address
    {
        public Address()
        {
            Customer = new HashSet<Customer>();
            Staff = new HashSet<Staff>();
            Store = new HashSet<Store>();
        }

        [Key]
        [Column("address_id", TypeName = "smallint(5) unsigned")]
        public ushort AddressId { get; set; }
        [Required]
        [Column("address", TypeName = "varchar(50)")]
        public string Address1 { get; set; }
        [Column("address2", TypeName = "varchar(50)")]
        public string Address2 { get; set; }
        [Required]
        [Column("district", TypeName = "varchar(20)")]
        public string District { get; set; }
        [Column("city_id", TypeName = "smallint(5) unsigned")]
        public ushort CityId { get; set; }
        [Column("postal_code", TypeName = "varchar(10)")]
        public string PostalCode { get; set; }
        [Required]
        [Column("phone", TypeName = "varchar(20)")]
        public string Phone { get; set; }
        [Column("last_update", TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey(nameof(CityId))]
        [InverseProperty("Address")]
        public virtual City City { get; set; }
        [InverseProperty("Address")]
        public virtual ICollection<Customer> Customer { get; set; }
        [InverseProperty("Address")]
        public virtual ICollection<Staff> Staff { get; set; }
        [InverseProperty("Address")]
        public virtual ICollection<Store> Store { get; set; }
    }
}

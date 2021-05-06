using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaffoldModels.Models
{
    [Table("store")]
    public partial class Store
    {
        public Store()
        {
            Customer = new HashSet<Customer>();
            Inventory = new HashSet<Inventory>();
            Staff = new HashSet<Staff>();
        }

        [Key]
        [Column("store_id", TypeName = "tinyint(3) unsigned")]
        public byte StoreId { get; set; }
        [Column("manager_staff_id", TypeName = "tinyint(3) unsigned")]
        public byte ManagerStaffId { get; set; }
        [Column("address_id", TypeName = "smallint(5) unsigned")]
        public ushort AddressId { get; set; }
        [Column("last_update", TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey(nameof(AddressId))]
        [InverseProperty("Store")]
        public virtual Address Address { get; set; }
        [ForeignKey(nameof(ManagerStaffId))]
        [InverseProperty("StoreNavigation")]
        public virtual Staff ManagerStaff { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<Customer> Customer { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<Inventory> Inventory { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<Staff> Staff { get; set; }
    }
}

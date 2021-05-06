using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaffoldModels.Models
{
    [Table("inventory")]
    public partial class Inventory
    {
        public Inventory()
        {
            Rental = new HashSet<Rental>();
        }

        [Key]
        [Column("inventory_id", TypeName = "mediumint(8) unsigned")]
        public uint InventoryId { get; set; }
        [Column("film_id", TypeName = "smallint(5) unsigned")]
        public ushort FilmId { get; set; }
        [Column("store_id", TypeName = "tinyint(3) unsigned")]
        public byte StoreId { get; set; }
        [Column("last_update", TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey(nameof(FilmId))]
        [InverseProperty("Inventory")]
        public virtual Film Film { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Inventory")]
        public virtual Store Store { get; set; }
        [InverseProperty("Inventory")]
        public virtual ICollection<Rental> Rental { get; set; }
    }
}

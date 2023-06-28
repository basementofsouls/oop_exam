namespace load_button_card
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        public int InventoryNumber { get; set; }

        public byte[] Image { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? Size { get; set; }

        public int? Weight { get; set; }

        [StringLength(100)]
        public string Type { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int? Amount { get; set; }

        public int? Price { get; set; }

        public int? ManufacturerId { get; set; }

        public int? StorekeeperId { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public virtual Storekeeper Storekeeper { get; set; }
    }
}

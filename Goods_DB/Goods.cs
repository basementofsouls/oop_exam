namespace Goods_DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Goods
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int good_id { get; set; }

        [StringLength(50)]
        public string good_name { get; set; }

        public int? good_year { get; set; }
    }
}

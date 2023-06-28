namespace load_button_card
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Card")]
    public partial class Card
    {
        public Card()
        {
        }

        public Card(string v1, string v2, string v3)
        {
            this.number = v1;
            this.name = v2;
            this.srok = v3;
        }

        [Key]
        [StringLength(50)]
        public string number { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string srok { get; set; }
    }
}

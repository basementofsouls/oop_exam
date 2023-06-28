namespace EXAM2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stud")]
    public partial class Stud
    {
      

        public Stud(string text, int val1, int val2, int val3)
        {
            this.lastname = text;
            this.value1 = val1;
            this.value2 = val2;
            this.value3 = val3;
        }

        [Key]
        [StringLength(50)]
        public string lastname { get; set; }

        public int? value1 { get; set; }

        public int? value2 { get; set; }

        public int? value3 { get; set; }
    }
}

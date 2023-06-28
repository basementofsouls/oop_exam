namespace Student_name_age
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Students
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? kurs { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int? age { get; set; }
    }
}

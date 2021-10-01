namespace EF3Last
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string Fname { get; set; }

        [StringLength(50)]
        public string Lname { get; set; }

        [StringLength(10)]
        public string title { get; set; }

        public int? salary { get; set; }

        public int? DepId { get; set; }

        public virtual Department Department { get; set; }
    }
}
